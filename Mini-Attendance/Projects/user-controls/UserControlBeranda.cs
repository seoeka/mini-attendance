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

namespace Mini_Attendance.Projects.user_controls
{
    public partial class UserControlBeranda : UserControl
    {
        private SqlConnection connection;
        public string UserRole { get; set; }

        public UserControlBeranda()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
            DisplayLabel();
            DisplayEvents();
        }
        private void DisplayLabel()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                labelRole.Text = UserRole;

                SqlCommand cmdKelas = new SqlCommand("SELECT COUNT(*) FROM Kelas", connection);
                int jumlahKelas = (int)cmdKelas.ExecuteScalar();
                labelJK.Text = $"{jumlahKelas}";

                SqlCommand cmdDosen = new SqlCommand("SELECT COUNT(*) FROM Dosen", connection);
                int jumlahDosen = (int)cmdDosen.ExecuteScalar();
                labelJD.Text = $"{jumlahDosen}";

                SqlCommand cmdMahasiswa = new SqlCommand("SELECT COUNT(*) FROM Mahasiswa", connection);
                int jumlahMahasiswa = (int)cmdMahasiswa.ExecuteScalar();
                labelJM.Text = $"{jumlahMahasiswa}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void DisplayEvents()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmdEvents = new SqlCommand("SELECT * FROM Event ORDER BY Tanggal ASC", connection);
                SqlDataReader reader = cmdEvents.ExecuteReader();

                while (reader.Read())
                {
                    Panel panelEvent = new Panel
                    {
                        Size = new Size(552, 70),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(0, 0, 0, 10)
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        ImageLocation = reader["Gambar"].ToString(),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new Size(50, 50),
                        Location = new Point(0, 0)
                    };
                    panelEvent.Controls.Add(pictureBox);

                    Label labelEventInfo = new Label
                    {
                        Text = $"Nama Event: {reader["Nama"]}\nTanggal Event: {Convert.ToDateTime(reader["Tanggal"]).ToShortDateString()}\nLokasi Event: {reader["Lokasi"]}",
                        Location = new Point(80, 0),
                        AutoSize = true
                    };
                    panelEvent.Controls.Add(labelEventInfo);

                    panelEvents.Controls.Add(panelEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}