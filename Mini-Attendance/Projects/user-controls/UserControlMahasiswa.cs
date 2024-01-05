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
    public partial class UserControlMahasiswa : UserControl, IUserControlClearAndDisable
    {
        private SqlConnection connection;
        private int selectedMhsID;
        private bool isEditing = false;

        public UserControlMahasiswa()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();

            DisplayDataMhs();
            ClearAndDisable();
        }

        public void ClearAndDisable()
        {
            TextBoxHelper.ClearTextBoxes(textBoxNM, textBoxNI, textBoxEM, textBoxPW,
                                         textBoxNM1, textBoxNI1, textBoxEM1, textBoxPW1);
            TextBoxHelper.EnableTextBoxes(false, textBoxNM1, textBoxNI1, textBoxEM1, textBoxPW1);
            btEdi.Enabled = false;
            btDel.Enabled = false;
        }

        private void DisplayDataMhs()
        {
            string query = "SELECT * FROM Mahasiswa";
            dataGridViewMhs.DataSource = DatabaseManager.ExecuteQuery(query).DefaultView;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string namaMhs = textBoxNM.Text;
                string nimMhs = textBoxNI.Text;
                string email = textBoxEM.Text;
                string password = textBoxPW.Text;

                if (string.IsNullOrEmpty(namaMhs) || string.IsNullOrEmpty(nimMhs) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Semua kolom harus diisi.");
                    return;
                }

                string query = "INSERT INTO Mahasiswa (Nama, NIM, Email, Password) VALUES (@Nama, @NIM, @Email, @Password)";
                DatabaseManager.ExecuteNonQuery(query, "@Nama", namaMhs, "@NIM", nimMhs, "@Email", email, "@Password", password);
                ClearAndDisable();
                MessageBox.Show("Data berhasil ditambahkan.");
                DisplayDataMhs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UserControlMahasiswa_Leave(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                ClearAndDisable();
            }
        }

        private void dataGridViewMhs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewMhs.Rows[e.RowIndex];

                selectedMhsID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                TextBoxHelper.FillTextBoxes(selectedRow, textBoxNM1, textBoxNI1, textBoxEM1, textBoxPW1);
                TextBoxHelper.EnableTextBoxes(true, textBoxNM1, textBoxNI1, textBoxEM1, textBoxPW1);
                btEdi.Enabled = true;
                btDel.Enabled = true;
                isEditing = true;
            }
        }

        private void btEdi_Click(object sender, EventArgs e)
        {
            try
            {
                string namaMhs = textBoxNM1.Text;
                string nimMhs = textBoxNI1.Text;
                string email = textBoxEM1.Text;
                string password = textBoxPW1.Text;

                string query = "UPDATE Mahasiswa SET Nama = @Nama, NIM = @NIM, Email = @Email, Password = @Password WHERE ID = @ID";

                DatabaseManager.ExecuteNonQuery(query, "@ID", selectedMhsID, "@Nama", namaMhs, "@NIM", nimMhs, "@Email", email, "@Password", password);

                MessageBox.Show("Data berhasil diupdate.");
                DisplayDataMhs();

                ClearAndDisable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedMhsID != 0)
                {
                    DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM Mahasiswa WHERE ID = @ID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", selectedMhsID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil dihapus.");
                                DisplayDataMhs();
                                ClearAndDisable();
                            }
                            else
                            {
                                MessageBox.Show("Gagal menghapus data.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pilih baris untuk dihapus.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
