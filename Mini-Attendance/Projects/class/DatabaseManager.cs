using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Attendance
{
    internal class DatabaseManager
    {
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                InitializeConnection();
            }

            return connection;
        }

        private static void InitializeConnection()
        {
            string sql = @"Data Source = .\SQLEXPRESS; Initial Catalog = db_attendance; Integrated Security = True;";
            connection = new SqlConnection(sql);
            connection.Open();
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand(query, GetConnection()))
            {
                command.Parameters.AddRange(parameters);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public static void ExecuteNonQuery(string query, params object[] parameters)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                for (int i = 1; i < parameters.Length; i += 2)
                {
                    command.Parameters.Add(parameters[i - 1].ToString(), SqlDbType.NVarChar).Value = parameters[i];
                }

                command.ExecuteNonQuery();
            }
        }
    }
}
