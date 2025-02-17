using Gudangin.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gudangin.controller
{
    internal class UserController
    {
        Koneksi koneksi = new Koneksi();

        // Login User
        public bool Authenticate(User user)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                string query = "SELECT * FROM t_user WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user.Id_user = reader["id_user"].ToString();
                    user.Role = reader["role"].ToString();
                    status = true;
                }
                reader.Close();
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

    }
}
