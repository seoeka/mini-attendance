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

namespace Mini_Attendance
{
    public partial class login : Form
    {
        private string sql = @"Data Source = .\SQLEXPRESS;
                        Initial Catalog = db_attendance;
                        Integrated Security = True;";


        public login()
        {
            InitializeComponent();
            pictureBoxError.Visible = false;
            labelError.Visible = false;
            textBoxPW.UseSystemPasswordChar = true;
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
            Close();
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

            try
            {
                using (SqlConnection connection = new SqlConnection(sql))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM mahasiswa WHERE nimMhs = @username AND password = @password OR " +
                                                               "EXISTS (SELECT * FROM dosen WHERE nipDosen = @username AND password = @password)", connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                main mainForm = new main();
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
                }
            }
            catch (Exception ex)
            {
                labelError.Text = "Error: " + ex.Message;
                labelError.Visible = true;
                pictureBoxError.Visible = true;
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
    }
}
