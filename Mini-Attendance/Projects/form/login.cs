using Mini_Attendance.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mini_Attendance
{
    public partial class login : Form
    {
        private SqlConnection connection;
        private string sql = @"Data Source = .\SQLEXPRESS;
                        Initial Catalog = db_attendance;
                        Integrated Security = True;";

        public login()
        {
            InitializeComponent();
            pictureBoxError.Visible = false;
            labelError.Visible = false;
            textBoxPW.UseSystemPasswordChar = true;
            connection = new SqlConnection(sql); // Initialize the class-level connection
        }

        private void pictureBoxMin_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxMin,"Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMasuk_Click(object sender, EventArgs e)
        {
            string username = textBoxUN.Text;
            string password = textBoxPW.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                labelError.Text = "Username dan password harus diisi.";
                pictureBoxError.Visible = true;
                labelError.Visible = true;
                return;
            }

            string userRole = string.Empty;
            string originalUsername = string.Empty;
            SqlDataReader reader = null;

            string query = "SELECT * FROM Administrator WHERE Username = @username AND Password = @password " +
                           "OR EXISTS (SELECT * FROM Dosen WHERE NIP = @username AND Password = @password) " +
                           "OR EXISTS (SELECT * FROM Mahasiswa WHERE NIM = @username AND Password = @password)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();

                        var result = DetermineUserRole(username);
                        userRole = result.userRole;
                        originalUsername = result.username;
                        MessageBox.Show($"Username: {originalUsername}", "Username Result", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        main mainForm = new main(userRole, originalUsername);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        labelError.Text = "Username atau password salah!";
                        labelError.Visible = true;
                        pictureBoxError.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                labelError.Text = "Error: " + ex.Message;
                labelError.Visible = true;
                pictureBoxError.Visible = true;
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHide, "Sembunyikan Password");
        }

        private void pictureBoxUnhide_Click(object sender, EventArgs e)
        {
            textBoxPW.UseSystemPasswordChar = !textBoxPW.UseSystemPasswordChar;
            pictureBoxUnhide.Visible = false;
            pictureBoxHide.Visible = true;
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPW.UseSystemPasswordChar = true;
            pictureBoxHide.Visible = false;
            pictureBoxUnhide.Visible = true;
        }

        private void pictureBoxUnhide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxUnhide, "Perlihatkan Password");
        }

        private (string userRole, string username) DetermineUserRole(string username)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT * FROM Administrator WHERE Username = @username";

                using (SqlCommand adminCommand = new SqlCommand(query, connection))
                {
                    adminCommand.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader adminReader = adminCommand.ExecuteReader())
                    {
                        if (adminReader.Read())
                        {
                            return ("Admin", username);
                        }
                    }
                }

                query = "SELECT * FROM Dosen WHERE NIP = @username";

                using (SqlCommand dosenCommand = new SqlCommand(query, connection))
                {
                    dosenCommand.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader dosenReader = dosenCommand.ExecuteReader())
                    {
                        if (dosenReader.Read())
                        {
                            return ("Dosen", username);
                        }
                    }
                }

                query = "SELECT * FROM Mahasiswa WHERE NIM = @username";

                using (SqlCommand mahasiswaCommand = new SqlCommand(query, connection))
                {
                    mahasiswaCommand.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader mahasiswaReader = mahasiswaCommand.ExecuteReader())
                    {
                        if (mahasiswaReader.Read())
                        {
                            return ("Mahasiswa", username);
                        }
                    }
                }
                return ("Unknown", username);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }




        private void labelError_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelError.Text);
            Clipboard.SetText(labelError.Text);
            MessageBox.Show("Error message copied to clipboard", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
