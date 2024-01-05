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
using System.Windows.Forms.VisualStyles;
using static Mini_Attendance.form.main;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mini_Attendance.Projects.user_controls
{
    public partial class UserControlHadir : UserControl, IUserControlClearAndDisable
    {
        private SqlConnection connection;
        private int selectedKehadiranKelasID;
        private bool isEditing = false;
        public string UserRole { get; set; }

        public UserControlHadir()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();

            FillComboBoxKLS();
            FillComboBoxMHS();
            FillComboBoxMHS1();

            ClearAndDisable();
            dataGridViewKehadiranKelas.DataSource = GetInitialDataTable();
            DisplayDataKehadiranKelas();
        }


        private DataTable GetInitialDataTable()
        {
            DataTable initialTable = new DataTable();
            initialTable.Columns.Add("Message", typeof(string));
            initialTable.Rows.Add("Silahkan pilih kelas terlebih dahulu.");
            return initialTable;
        }

        public void ClearAndDisable()
        {
            btEdi.Enabled = false;
            btDel.Enabled = false;

            comboBoxMHS.SelectedIndex = -1;
            comboBoxKLS.SelectedIndex = -1;
            comboBoxMHS1.Enabled = false;

            comboBoxSTT.SelectedIndex = -1;
            comboBoxSTT1.SelectedIndex = -1;
            comboBoxSTT1.Enabled = false;

            dateTimePicker.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void UserControlKelas_Leave(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                ClearAndDisable();
            }
        }
        private void comboBoxKLS_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDataKehadiranKelas();
        }

        private void DisplayDataKehadiranKelas()
        {
            if (comboBoxKLS.SelectedIndex == -1)
            {
                dataGridViewKehadiranKelas.DataSource = GetInitialDataTable();
                DisableComponents();
            }
            else
            {
                string selectedClass = comboBoxKLS.SelectedItem.ToString();
                DataTable actualData = FetchActualDataForClass(selectedClass);
                dataGridViewKehadiranKelas.DataSource = actualData;
                EnableComponents();
            }
        }

        private void DisableComponents()
        {
            comboBoxMHS.Enabled = false;
            comboBoxSTT.Enabled = false;
            dateTimePicker.Enabled = false;
            btAdd.Enabled = false;
        }

        private void EnableComponents()
        {
            comboBoxMHS.Enabled = true;
            comboBoxSTT.Enabled = true;
            dateTimePicker.Enabled = true;
            btAdd.Enabled = true;
            if (UserRole == "Mahasiswa")
            {
                comboBoxMHS.Enabled = false;
                comboBoxMHS1.Enabled = false;
            }
        }

        private DataTable FetchActualDataForClass(string selectedClass)
        {
            string query = "SELECT mhs.Nama AS Mahasiswa, kelas.Nama AS Kelas, kehadiran.Tanggal, kehadiran.Status " +
                           "FROM Kehadiran kehadiran " +
                           "JOIN Mahasiswa mhs ON kehadiran.mhsID = mhs.ID " +
                           "JOIN Kelas kelas ON kehadiran.kelasID = kelas.ID " +
                           "WHERE kelas.Nama = @SelectedClass";

            DataTable dataTable = new DataTable();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SelectedClass", selectedClass);

                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dataTable;
        }

        private void FillComboBoxKLS()
        {
            comboBoxKLS.Items.Clear();

            string query = "SELECT ID, Nama FROM kelas WHERE TanggalAkhir >= @CurrentDate";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CurrentDate", DateTime.Now.Date);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int kelasID = Convert.ToInt32(reader["ID"]);
                        string kelasNama = reader["Nama"].ToString();
                        comboBoxKLS.Items.Add(new KelasItem(kelasID, kelasNama));
                    }
                }
            }
        }

        public class KelasItem
        {
            public int ID { get; set; }
            public string Nama { get; set; }

            public KelasItem(int id, string nama)
            {
                ID = id;
                Nama = nama;
            }

            public override string ToString()
            {
                return Nama;
            }
        }

        private void FillComboBoxMHS()
        {
            comboBoxMHS.Items.Clear();

            string query = "SELECT ID, Nama FROM Mahasiswa";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int mahasiswaID = Convert.ToInt32(reader["ID"]);
                        string mahasiswaNama = reader["Nama"].ToString();
                        comboBoxMHS.Items.Add(new MahasiswaItem(mahasiswaID, mahasiswaNama));
                    }
                }
            }
        }

        private void FillComboBoxMHS1()
        {
            comboBoxMHS1.Items.Clear();

            string query = "SELECT ID, Nama FROM Mahasiswa";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int mahasiswaID = Convert.ToInt32(reader["ID"]);
                        string mahasiswaNama = reader["Nama"].ToString();
                        comboBoxMHS1.Items.Add(new MahasiswaItem(mahasiswaID, mahasiswaNama));
                    }
                }
            }
        }

        public class MahasiswaItem
        {
            public int ID { get; set; }
            public string Nama { get; set; }

            public MahasiswaItem(int id, string nama)
            {
                ID = id;
                Nama = nama;
            }

            public override string ToString()
            {
                return Nama;
            }
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxKLS.SelectedItem is KelasItem selectedKelas)
            {
                int selectedKelasID = selectedKelas.ID;
                int selectedMahasiswaID;

                if (UserRole == "Mahasiswa")
                {
                    selectedMahasiswaID = Convert.ToInt32(UserRole);
                }
                else
                {
                    if (comboBoxMHS.SelectedItem is MahasiswaItem selectedMahasiswa)
                    {
                        selectedMahasiswaID = selectedMahasiswa.ID;
                    }
                    else
                    {
                        MessageBox.Show("Silahkan pilih Mahasiswa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string status = comboBoxSTT.SelectedItem?.ToString();

                DateTime tanggal = dateTimePicker.Value.Date;

                string query = "INSERT INTO Kehadiran (mhsID, kelasID, Tanggal, status) VALUES (@mhsID, @kelasID, @Tanggal, @status)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mhsID", selectedMahasiswaID);
                    command.Parameters.AddWithValue("@kelasID", selectedKelasID);
                    command.Parameters.AddWithValue("@Tanggal", tanggal);
                    command.Parameters.AddWithValue("@status", status);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data kehadiran berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayDataKehadiranKelas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silahkan pilih Kelas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
