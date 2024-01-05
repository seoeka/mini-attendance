using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

using System.Data.Common;
using System.IO;

namespace Mini_Attendance.Projects.user_controls
{
    public partial class UserControlLaporan : UserControl
    {
        private SqlConnection connection;
        private bool isRentangWaktuAktif;

        public UserControlLaporan()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();

            ClearAndDisable();

            isRentangWaktuAktif = false;
            dateTimePickerEnd.Enabled = isRentangWaktuAktif;
            dateTimePickerSet.Enabled = isRentangWaktuAktif;
        }

        private void checkBoxRentang1_CheckedChanged(object sender, EventArgs e)
        {
            isRentangWaktuAktif = checkBox1.Checked;
            dateTimePickerEnd.Enabled = isRentangWaktuAktif;
            dateTimePickerSet.Enabled = isRentangWaktuAktif;
        }

        private void DisplayData(string jenisData, string filterNama, bool isRentangWaktuAktif, DateTime dateSet, DateTime dateEnd)
        {
            string query = string.Empty;

            switch (jenisData)
            {
                case "Kelas":
                    query = $"SELECT M.Nama AS Mahasiswa, K.Nama AS Kelas, KA.Tanggal, KA.status " +
                            $"FROM Kehadiran KA " +
                            $"INNER JOIN Mahasiswa M ON KA.mhsID = M.ID " +
                            $"INNER JOIN Kelas K ON KA.kelasID = K.ID " +
                            $"WHERE K.Nama = COALESCE('{filterNama}', K.Nama)";
                    break;

                case "Dosen":
                    query = $"SELECT K.Nama AS Kelas, M.Nama AS Mahasiswa, KA.Tanggal, KA.status " +
                            $"FROM Kehadiran KA " +
                            $"INNER JOIN Mahasiswa M ON KA.mhsID = M.ID " +
                            $"INNER JOIN Kelas K ON KA.kelasID = K.ID " +
                            $"INNER JOIN Dosen D ON K.dosenID = D.ID " +
                            $"WHERE D.Nama = COALESCE('{filterNama}', D.Nama)";
                    break;

                case "Mahasiswa":
                    query = $"SELECT K.Nama AS Kelas, KA.Tanggal, KA.status " +
                            $"FROM Kehadiran KA " +
                            $"INNER JOIN Kelas K ON KA.kelasID = K.ID " +
                            $"INNER JOIN Mahasiswa M ON KA.mhsID = M.ID " +
                            $"WHERE M.Nama = COALESCE('{filterNama}', M.Nama) " +
                            (isRentangWaktuAktif ? $"AND KA.Tanggal BETWEEN '{dateSet:yyyy-MM-dd}' AND '{dateEnd:yyyy-MM-dd}'" : "") +
                            $"UNION " +
                            $"SELECT E.Nama AS Event, EA.Tanggal, 'Hadir' AS status " +
                            $"FROM Event_Attendance EA " +
                            $"INNER JOIN Event E ON EA.eventID = E.ID " +
                            $"INNER JOIN Mahasiswa M ON EA.mhsID = M.ID " +
                            $"WHERE M.Nama = COALESCE('{filterNama}', M.Nama)" +
                            (isRentangWaktuAktif ? $"AND EA.Tanggal BETWEEN '{dateSet:yyyy-MM-dd}' AND '{dateEnd:yyyy-MM-dd}'" : "");
                    break;

                case "Event":
                    query = $"SELECT E.Nama AS Event, M.Nama AS Mahasiswa, EA.Tanggal, 'Hadir' AS status " +
                            $"FROM Event_Attendance EA " +
                            $"INNER JOIN Event E ON EA.eventID = E.ID " +
                            $"INNER JOIN Mahasiswa M ON EA.mhsID = M.ID " +
                            $"WHERE E.Nama = COALESCE('{filterNama}', E.Nama)" +
                            (isRentangWaktuAktif ? $"AND EA.Tanggal BETWEEN '{dateSet:yyyy-MM-dd}' AND '{dateEnd:yyyy-MM-dd}'" : "");
                    break;

                default:
                    MessageBox.Show("Jenis data tidak valid.");
                    return;
            }

            if (!isRentangWaktuAktif)
            {
                query = query.Replace("AND KA.Tanggal BETWEEN", "").Replace("AND EA.Tanggal BETWEEN", "");
            }

            string fullQuery = $"SELECT * FROM ({query}) AS ReportData";
            DataTable resultTable = DatabaseManager.ExecuteQuery(fullQuery);

            dataGridViewKelas.DataSource = resultTable;
        }

        private void ClearAndDisable()
        {
            comboBoxJD.SelectedIndex = -1;
            comboBoxFN.SelectedIndex = -1;
            dateTimePickerSet.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
            dateTimePickerEnd.Enabled = false;
            dateTimePickerSet.Enabled = false;
            btPrint.Enabled = false;
        }

        private void btLihat_Click(object sender, EventArgs e)
        {
            try
            {
                string jenisData = comboBoxJD.SelectedItem?.ToString();
                string filterNama = comboBoxFN.SelectedItem?.ToString();
                DateTime dateSet = dateTimePickerSet.Value;
                DateTime dateEnd = dateTimePickerEnd.Value;

                if (string.IsNullOrEmpty(jenisData) || string.IsNullOrEmpty(filterNama))
                {
                    MessageBox.Show("Pilih jenis data dan nama yang valid.");
                    return;
                }

                if (isRentangWaktuAktif && dateSet > dateEnd)
                {
                    MessageBox.Show("Rentang waktu tidak valid. Tanggal mulai tidak dapat lebih besar dari tanggal akhir.");
                    return;
                }

                DisplayData(jenisData, filterNama, isRentangWaktuAktif, dateSet, dateEnd);
                btPrint.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadFilterNama(string jenisData)
        {
            comboBoxFN.Items.Clear();

            switch (jenisData)
            {
                case "Kelas":
                    LoadKelasDataToComboBox();
                    break;
                case "Dosen":
                    LoadDosenDataToComboBox();
                    break;
                case "Mahasiswa":
                    LoadMahasiswaDataToComboBox();
                    break;
                case "Event":
                    LoadEventDataToComboBox();
                    break;
                default:
                    MessageBox.Show("Pilih jenis data yang valid.");
                    break;
            }
        }

        private void LoadKelasDataToComboBox()
        {
            string query = "SELECT Nama FROM Kelas";
            DataTable dataTable = DatabaseManager.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                comboBoxFN.Items.Add(row["Nama"].ToString());
            }
        }

        private void LoadDosenDataToComboBox()
        {
            string query = "SELECT Nama FROM Dosen";
            DataTable dataTable = DatabaseManager.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                comboBoxFN.Items.Add(row["Nama"].ToString());
            }
        }

        private void LoadMahasiswaDataToComboBox()
        {
            string query = "SELECT Nama FROM Mahasiswa";
            DataTable dataTable = DatabaseManager.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                comboBoxFN.Items.Add(row["Nama"].ToString());
            }
        }

        private void LoadEventDataToComboBox()
        {
            string query = "SELECT Nama FROM Event";
            DataTable dataTable = DatabaseManager.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                comboBoxFN.Items.Add(row["Nama"].ToString());
            }
        }

        private void comboBoxJD_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFilterNama(comboBoxJD.SelectedItem?.ToString());
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataToPrint = (DataTable)dataGridViewKelas.DataSource;

                if (dataToPrint == null || dataToPrint.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data untuk dicetak.");
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf|CSV File (*.csv)|*.csv";
                saveFileDialog.Title = "Simpan File Cetak";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (filePath.EndsWith(".pdf"))
                    {
                        ExportToPdf(dataToPrint, filePath);
                    }
                    else if (filePath.EndsWith(".csv"))
                    {
                        ExportToCsv(dataToPrint, filePath);
                    }

                    MessageBox.Show("Cetak berhasil.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ExportToPdf(DataTable dataTable, string filePath)
        {
            try
            {
                using (var writer = new PdfWriter(filePath))
                {
                    using (var pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);
                        document.Add(new Paragraph("Data Grid to PDF"));

                        Table pdfTable = new Table(dataTable.Columns.Count);

                        // Add header cells
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            if (!isRentangWaktuAktif || column.DataType != typeof(DateTime))
                                pdfTable.AddHeaderCell(column.ColumnName);
                        }

                        // Add data cells
                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (DataColumn column in dataTable.Columns)
                            {
                                if (!isRentangWaktuAktif || column.DataType != typeof(DateTime))
                                {
                                    string cellValue = row[column].ToString();
                                    pdfTable.AddCell(cellValue);
                                }
                            }
                        }

                        document.Add(pdfTable);
                    }
                }

                MessageBox.Show("Cetak berhasil.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ExportToCsv(DataTable dataTable, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                foreach (DataColumn col in dataTable.Columns)
                {
                    if (!isRentangWaktuAktif || col.DataType != typeof(DateTime))
                        csv.WriteField(col.ColumnName);
                }

                csv.NextRecord();

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        if (!isRentangWaktuAktif || col.DataType != typeof(DateTime))
                            csv.WriteField(row[col]);
                    }

                    csv.NextRecord();
                }
            }
        }
    }
}
