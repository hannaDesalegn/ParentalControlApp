using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParentalControlApp.DB
{
    static class DBConnection
    {
        static string _connectionString = @"Data Source=NATHY-PC\SQLEXPRESS;
                                           Initial Catalog=ParentalControlDB;
                                           Integrated Security=True;
                                           Trust Server Certificate=True";
        public static SqlConnection _connection = new SqlConnection(_connectionString);

        public static void Initialize()
        {
            try
            {
                _connection.Open();
            }

            catch(Exception ex)
            {
                MessageBox.Show($"Unable to connect. \n {ex.Message}", "DB error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
