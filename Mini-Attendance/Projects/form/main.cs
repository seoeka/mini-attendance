using Mini_Attendance.Projects.user_controls;
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

namespace Mini_Attendance.form
{
    public partial class main : Form
    {
        private SqlConnection connection;
        private string userRole, usernama;
        private login loginForm;

        public main(string role, string userName)
        {
            InitializeComponent();

            userRole = role;
            usernama = userName;
            UpdateRoleLabel();

            if (role == "Dosen")
            {
                buttonKelas.Visible = false;
                buttonDosen.Visible = false;
                buttonAcara.Visible = false;
            }
            else if (role == "Mahasiswa")
            {
                buttonKelas.Visible = false;
                buttonMhs.Visible = false;
                buttonDosen.Visible = false;
            }

            loginForm = new login();

            connection = DatabaseManager.GetConnection();
        }

        private void UpdateRoleLabel()
        {
            if (userRole == "Mahasiswa")
            {
                labelUserName.Text = GetMahasiswaName(usernama);
            }
            else if (userRole == "Dosen")
            {
                labelUserName.Text = GetDosenName(usernama);
            }
            else if (userRole == "Admin")
            {
                labelUserName.Text = userRole;
            }
        }

        private string GetMahasiswaName(string username)
        {
            using (SqlCommand command = new SqlCommand("SELECT namaMhs FROM mahasiswa WHERE nimMhs = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["namaMhs"].ToString();
                    }
                }
            }   
            return string.Empty;
        }

        private string GetDosenName(string username)
        {
            using (SqlCommand command = new SqlCommand("SELECT namaDosen FROM dosen WHERE nipDosen = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["namaDosen"].ToString();
                    }
                }
            }
            return string.Empty;
        }

        private void ucActive(Control button)
        {
            panelActive.Location = new Point(button.Location.X, button.Location.Y);
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Memeriksa hasil pilihan pengguna
            if (result == DialogResult.Yes)
            {
                this.Close();
                loginForm.Show();
            }
        }

        private void buttonBeranda_Click(object sender, EventArgs e)
        {
            ucActive(buttonBeranda);
            userControlBeranda1.Visible = true;
            userControlDo1.Visible = false;
            userControlMahasiswa1.Visible = false;
        }

        private void buttonDosen_Click(object sender, EventArgs e)
        {
            ucActive(buttonDosen);
            userControlBeranda1.Visible = false;
            userControlDo1.Visible = true;
            userControlMahasiswa1.Visible = false;
        }

        private void buttonMhs_Click(object sender, EventArgs e)
        {
            ucActive(buttonMhs);
            userControlBeranda1.Visible = false;
            userControlDo1.Visible = false;
            userControlMahasiswa1.Visible = true;
        }

        private void buttonKelas_Click(object sender, EventArgs e)
        {
            ucActive(buttonKelas);
            userControlBeranda1.Visible = false;
            userControlDo1.Visible = false;
            userControlMahasiswa1.Visible = false;
        }

        private void buttonHadir_Click(object sender, EventArgs e)
        {
            ucActive(buttonHadir);
            userControlBeranda1.Visible = false;
            userControlDo1.Visible = false;
            userControlMahasiswa1.Visible = false;
        }

        private void buttonAcara_Click(object sender, EventArgs e)
        {
            ucActive(buttonAcara);
            userControlBeranda1.Visible = false;
            userControlDo1.Visible = false;
            userControlMahasiswa1.Visible = false;
        }

        private void buttonLapor_Click(object sender, EventArgs e)
        {
            ucActive(buttonLapor);
            userControlBeranda1.Visible = false;
            userControlDo1.Visible = false;
            userControlMahasiswa1.Visible = false;
        }

        private void pictureBoxMin_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxMin, "Minimize");
        }
    }
}
