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
    public partial class UserControlMahasiswa : UserControl
    {
        private SqlConnection connection;

        public UserControlMahasiswa()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();

            DisplayDataMhs();
        }

        private void DisplayDataMhs()
        {
            string query = "SELECT * FROM mahasiswa";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataTable.Columns["mhsID"].ColumnName = "ID";
                    dataTable.Columns["namaMhs"].ColumnName = "Nama";
                    dataTable.Columns["nimMhs"].ColumnName = "NIM";
                    dataTable.Columns["emailMhs"].ColumnName = "Email";
                    dataTable.Columns["password"].ColumnName = "Password";

                    dataGridViewMhs.DataSource = dataTable;
                }
            }
        }
    }
}
