using Mini_Attendance;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

public static class DatabaseUtilities
{
    private static SqlConnection connection = DatabaseManager.GetConnection();

    public static int GetMahasiswaIDByNIM(string nim)
    {
        int mahasiswaID = -1; // Default value jika tidak ditemukan

        // Buka koneksi sebelum mengambil data
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }

        string query = "SELECT ID FROM Mahasiswa WHERE NIM = @NIM";
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@NIM", nim);

            try
            {
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    mahasiswaID = (int)result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }

        return mahasiswaID;
    }
}