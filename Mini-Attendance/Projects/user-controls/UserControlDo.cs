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
    public partial class UserControlDo : UserControl, IUserControlClearAndDisable
    {
        private SqlConnection connection;
        private int selectedDosenID;
        private bool isEditing = false;

        public UserControlDo()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();

            DisplayDataDosen();
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

        private void UserControlDo_Leave(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                ClearAndDisable();
            }
        }

        private void DisplayDataDosen()
        {
            string query = "SELECT * FROM Dosen";
            dataGridViewDosen.DataSource = DatabaseManager.ExecuteQuery(query).DefaultView;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string namaDosen = textBoxNM.Text;
                string nipDosen = textBoxNI.Text;
                string emailDosen = textBoxEM.Text;
                string passwordDosen = textBoxPW.Text;

                if (string.IsNullOrEmpty(namaDosen) || string.IsNullOrEmpty(nipDosen) ||
                    string.IsNullOrEmpty(emailDosen) || string.IsNullOrEmpty(passwordDosen))
                {
                    MessageBox.Show("Semua kolom harus diisi.");
                    return;
                }

                string query = "INSERT INTO Dosen (Nama, NIP, Email, Password) VALUES (@Nama, @NIP, @Email, @Password)";
                DatabaseManager.ExecuteNonQuery(query, "@Nama", namaDosen, "@NIP", nipDosen, "@Email", emailDosen, "@Password", passwordDosen);
                ClearAndDisable();
                MessageBox.Show("Data berhasil ditambahkan.");
                DisplayDataDosen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridViewDosen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewDosen.Rows[e.RowIndex];

                selectedDosenID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

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
                string namaDosen = textBoxNM1.Text;
                string nipDosen = textBoxNI1.Text;
                string emailDosen = textBoxEM1.Text;
                string passwordDosen = textBoxPW1.Text;

                string query = "UPDATE Dosen SET Nama = @Nama, NIP = @NIP, Email = @Email, Password = @Password WHERE ID = @ID";

                DatabaseManager.ExecuteNonQuery(query, "@ID", selectedDosenID, "@Nama", namaDosen, "@NIP", nipDosen, "@Email", emailDosen, "@Password", passwordDosen);

                MessageBox.Show("Data berhasil diupdate.");
                DisplayDataDosen();
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
                if (selectedDosenID != 0)
                {
                    DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM Dosen WHERE ID = @ID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", selectedDosenID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil dihapus.");
                                DisplayDataDosen();
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
