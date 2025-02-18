using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gudangin.controller
{
    internal class Koneksi
    {
        private string connectionString = "Server=localhost;Database=eventory;Uid=root;Pwd=";
        public MySqlConnection kon;

        public Koneksi()
        {
            kon = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                if (kon.State == ConnectionState.Closed)
                {
                    kon.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Koneksi Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (kon.State == ConnectionState.Open)
                {
                    kon.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Menutup Koneksi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int ExecuteQuery(string query)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand(query, kon);
                int affectedRows = command.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Kesalahan Eksekusi Query!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }


        public DataTable ShowData(string query)
        {
            try
            {
                OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, kon);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                CloseConnection();
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Kesalahan Saat Mengambil Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public MySqlDataReader reader(string query)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, kon);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection); // Koneksi akan tertutup otomatis setelah reader selesai digunakan
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Kesalahan Saat Membaca Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
