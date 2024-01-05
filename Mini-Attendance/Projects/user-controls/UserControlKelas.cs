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
using static Mini_Attendance.form.main;

namespace Mini_Attendance.Projects.user_controls
{
    public partial class UserControlKelas : UserControl, IUserControlClearAndDisable
    {
        private SqlConnection connection;
        private int selectedKelasID;
        private bool isEditing = false;
        public UserControlKelas()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();

            DisplayDataKelas();
        }

        public void ClearAndDisable()
        {
            TextBoxHelper.ClearTextBoxes(textBoxNM, textBoxNM1);
            TextBoxHelper.EnableTextBoxes(false, textBoxNM1);
            btEdi.Enabled = false;
            btDel.Enabled = false;

            comboBoxDS.SelectedIndex = -1;
            comboBoxDS1.SelectedIndex = -1;
            comboBoxDS1.Enabled = false;

            dateTimePickerSet.Value = DateTime.Now;  
            dateTimePickerEnd.Value = DateTime.Now;

            dateTimePickerSet1.Value = DateTime.Now; 
            dateTimePickerSet1.Enabled = false;

            dateTimePickerEnd1.Value = DateTime.Now;
            dateTimePickerEnd1.Enabled = false;
        }

        private void UserControlKelas_Leave(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                ClearAndDisable();
            }
        }

        private void DisplayDataKelas()
        {
            string query = "SELECT * FROM Kelas";
            dataGridViewKelas.DataSource = DatabaseManager.ExecuteQuery(query).DefaultView;
        }

        private void PopulateDosenComboBox()
        {
            string query = "SELECT ID, Nama FROM Dosen";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int dosenID = Convert.ToInt32(reader["ID"]);
                        string dosenNama = reader["Nama"].ToString();
                        comboBoxDS.Items.Add(new DosenItem(dosenID, dosenNama));
                    }
                }
            }
        }

        private void UserControlKelas_Load(object sender, EventArgs e)
        {
            PopulateDosenComboBox();
            PopulateDosenComboBox1();
        }

        private int GetSelectedDosenID()
        {
            if (comboBoxDS.SelectedItem is DosenItem selectedDosen)
            {
                return selectedDosen.ID;
            }
            return 0;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string namaKelas = textBoxNM.Text;
                DateTime startDate = dateTimePickerSet.Value;
                DateTime endDate = dateTimePickerEnd.Value;
                int dosenID = GetSelectedDosenID();

                if (string.IsNullOrEmpty(namaKelas) || dosenID == 0)
                {
                    MessageBox.Show("Nama kelas dan dosen harus diisi, serta pilih tanggal awal dan akhir.");
                    return;
                }

                InsertClass(namaKelas, startDate, endDate, dosenID);
                ClearAndDisable();
                MessageBox.Show("Data kelas berhasil ditambahkan.");
                DisplayDataKelas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void InsertClass(string className, DateTime startDate, DateTime endDate, int dosenID)
        {
            string query = "INSERT INTO Kelas (Nama, Tanggal, TanggalAkhir, dosenID) VALUES (@Nama, @Tanggal, @TanggalAkhir, @DosenID)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nama", className);
                command.Parameters.AddWithValue("@Tanggal", startDate);
                command.Parameters.AddWithValue("@TanggalAkhir", endDate);
                command.Parameters.AddWithValue("@DosenID", dosenID);

                command.ExecuteNonQuery();
            }
        }

        public class DosenItem
        {
            public int ID { get; set; }
            public string Nama { get; set; }

            public DosenItem(int id, string nama)
            {
                ID = id;
                Nama = nama;
            }

            public override string ToString()
            {
                return Nama;
            }
        }

        private void dataGridViewKelas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewKelas.Rows[e.RowIndex];

                selectedKelasID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                textBoxNM1.Text = selectedRow.Cells["Nama"].Value.ToString();

                dateTimePickerSet1.Value = Convert.ToDateTime(selectedRow.Cells["Tanggal"].Value);

                // Ganti dateTimePickerEnd1 dengan tanggal akhir dari data kelas yang dipilih
                dateTimePickerEnd1.Value = GetEndDate(selectedRow);

                comboBoxDS1.Enabled = true;
                int dosenID = Convert.ToInt32(selectedRow.Cells["dosenID"].Value);
                SelectDosenInComboBox1(dosenID);

                TextBoxHelper.EnableTextBoxes(true, textBoxNM1);
                dateTimePickerSet1.Enabled = true;
                dateTimePickerEnd1.Enabled = true;
                btEdi.Enabled = true;
                btDel.Enabled = true;
                isEditing = true;
            }
        }

        private DateTime GetEndDate(DataGridViewRow row)
        {
            int kelasID = Convert.ToInt32(row.Cells["ID"].Value);
            string query = "SELECT MAX(Tanggal) FROM Kelas WHERE ID = @KelasID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@KelasID", kelasID);

                object result = command.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToDateTime(result);
                }
            }
            return DateTime.Now;
        }


        private void PopulateDosenComboBox1()
        {
            string query = "SELECT ID, Nama FROM Dosen";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int dosenID = Convert.ToInt32(reader["ID"]);
                        string dosenNama = reader["Nama"].ToString();
                        comboBoxDS1.Items.Add(new DosenItem(dosenID, dosenNama));
                    }
                }
            }
        }

        private void SelectDosenInComboBox1(int dosenID)
        {
            foreach (DosenItem item in comboBoxDS1.Items)
            {
                if (item.ID == dosenID)
                {
                    comboBoxDS1.SelectedItem = item;
                    break;
                }
            }
        }

        private void btEdi_Click(object sender, EventArgs e)
        {
            try
            {
                string editedClassName = textBoxNM1.Text;
                DateTime editedStartDate = dateTimePickerSet1.Value;
                DateTime editedEndDate = dateTimePickerEnd1.Value;
                int editedDosenID = GetSelectedDosenID1();

                if (string.IsNullOrEmpty(editedClassName) || editedDosenID == 0)
                {
                    MessageBox.Show("Nama kelas dan dosen harus diisi, serta pilih tanggal awal dan akhir.");
                    return;
                }

                UpdateClasses(selectedKelasID, editedClassName, editedStartDate, editedEndDate, editedDosenID);
                ClearAndDisable();
                MessageBox.Show("Data kelas berhasil diperbarui.");
                DisplayDataKelas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GetSelectedDosenID1()
        {
            if (comboBoxDS1.SelectedItem is DosenItem selectedDosen)
            {
                return selectedDosen.ID;
            }
            return 0;
        }

        private void UpdateClasses(int kelasID, string className, DateTime startDate, DateTime endDate, int dosenID)
        {
            string query = "UPDATE Kelas SET Nama = @Nama, Tanggal = @Tanggal, TanggalAkhir = @TanggalAkhir, dosenID = @DosenID WHERE ID = @KelasID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@KelasID", kelasID);
                command.Parameters.AddWithValue("@Nama", className);
                command.Parameters.AddWithValue("@Tanggal", startDate);
                command.Parameters.AddWithValue("@TanggalAkhir", endDate);
                command.Parameters.AddWithValue("@DosenID", dosenID);

                command.ExecuteNonQuery();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedKelasID > 0)
                {
                    DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus kelas ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteClass(selectedKelasID);
                        ClearAndDisable();
                        MessageBox.Show("Data kelas berhasil dihapus.");
                        DisplayDataKelas();
                    }
                }
                else
                {
                    MessageBox.Show("Pilih kelas yang akan dihapus terlebih dahulu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteClass(int kelasID)
        {
            string query = "DELETE FROM Kelas WHERE ID = @KelasID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@KelasID", kelasID);

                command.ExecuteNonQuery();
            }
        }

    }
}
