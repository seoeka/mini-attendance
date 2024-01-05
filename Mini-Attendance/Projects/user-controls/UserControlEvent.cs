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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mini_Attendance.Projects.user_controls
{
    public partial class UserControlEvent : UserControl
    {
        public string UserRole { get; set; }
        public int UserID { get; set; }

        private SqlConnection connection;
        private int selectedEventID;

        public UserControlEvent()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();

            DisplayEvent();
            btEdi.Enabled = false;
            btDel.Enabled = false;

            if (UserRole == "Mahasiswa" || UserRole == "Dosen")
            {
                btAdd1.Enabled = true;
                btEdi1.Enabled = true;
                btDel1.Enabled = true;
                labelTitle.Visible = true;
                labelDesc.Visible = true;
                chooseEvent.Visible = true;
            }
        }

        private void DisplayEvent()
        {
            string query = "SELECT ID, Nama, Lokasi, Tanggal, Peserta FROM Event";
            dataGridViewKelas.DataSource = DatabaseManager.ExecuteQuery(query).DefaultView;
        }

        public void ClearAndDisable()
        {
            btEdi.Enabled = false;
            btDel.Enabled = false;
            dateTimePicker.Value = DateTime.Now;
            TextBoxHelper.ClearTextBoxes(textBoxLK, textBoxNM);
            comboBoxPS.SelectedIndex = -1;
        }

        private void InsertEvent(string namaEvent, string lokasiEvent, DateTime dateEvent, string psEvent, string gbEvent)
        {
            string query = "INSERT INTO Event (Nama, Lokasi, Tanggal, Peserta, Gambar) VALUES (@Nama,  @Lokasi, @Tanggal, @Peserta, @Gambar)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nama", namaEvent);
                command.Parameters.AddWithValue("@Lokasi", lokasiEvent);
                command.Parameters.AddWithValue("@Tanggal", dateEvent);
                command.Parameters.AddWithValue("@Peserta", psEvent);
                command.Parameters.AddWithValue("@Gambar", psEvent);

                command.ExecuteNonQuery();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string namaEvent = textBoxNM.Text;
                string lkEvent = textBoxLK.Text;
                DateTime dateEvent = dateTimePicker.Value;
                string psEvent = comboBoxPS.SelectedItem?.ToString();
                string gbEvent;

                if (psEvent == "Mahasiswa")
                {
                    gbEvent = "icons-mhs";
                }
                else if (psEvent == "Dosen")
                {
                    gbEvent = "icons-ds";
                }
                else
                {
                    gbEvent = "icons-um";
                }
                 
                InsertEvent(namaEvent, lkEvent, dateEvent, psEvent, gbEvent);
                ClearAndDisable();
                MessageBox.Show("Data kelas berhasil ditambahkan.");
                DisplayEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btEdi_Click(object sender, EventArgs e)
        {
            try
            {
                string namaEvent = textBoxNM.Text;
                string lokasiEvent = textBoxLK.Text;
                DateTime dateEvent = dateTimePicker.Value;
                string pesertaEvent = comboBoxPS.SelectedItem?.ToString();
                string gbEvent;

                if (pesertaEvent == "Mahasiswa")
                {
                    gbEvent = "icons-mhs";
                }
                else if (pesertaEvent == "Dosen")
                {
                    gbEvent = "icons-ds";
                }
                else
                {
                    gbEvent = "icons-um";
                }

                UpdateEvent(selectedEventID, namaEvent, lokasiEvent, dateEvent, pesertaEvent, gbEvent);
                ClearAndDisable();
                MessageBox.Show("Data event berhasil diperbarui.");
                DisplayEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateEvent(int eventID, string namaEvent, string lokasiEvent, DateTime dateEvent, string pesertaEvent, string gbEvent)
        {
            string query = "UPDATE Event SET Nama = @Nama, Lokasi = @Lokasi, Tanggal = @Tanggal, Peserta = @Peserta, Gambar = @Gambar WHERE ID = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", eventID);
                command.Parameters.AddWithValue("@Nama", namaEvent);
                command.Parameters.AddWithValue("@Lokasi", lokasiEvent);
                command.Parameters.AddWithValue("@Tanggal", dateEvent);
                command.Parameters.AddWithValue("@Peserta", pesertaEvent);
                command.Parameters.AddWithValue("@Gambar", gbEvent);

                command.ExecuteNonQuery();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data event ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent(selectedEventID);
                    ClearAndDisable();
                    MessageBox.Show("Data event berhasil dihapus.");
                    DisplayEvent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteEvent(int eventID)
        {
            string query = "DELETE FROM Event WHERE ID = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", eventID);
                command.ExecuteNonQuery();
            }
        }


        private void dataGridViewKelas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewKelas.Rows[e.RowIndex];

                selectedEventID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                textBoxNM.Text = selectedRow.Cells["Nama"].Value.ToString();
                textBoxLK.Text = selectedRow.Cells["Lokasi"].Value.ToString();
                dateTimePicker.Value = Convert.ToDateTime(selectedRow.Cells["Tanggal"].Value);
                comboBoxPS.SelectedItem = selectedRow.Cells["Peserta"].Value.ToString();
                btEdi.Enabled = true;
                btDel.Enabled = true;
            }
        }
    }
}
