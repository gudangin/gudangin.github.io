using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Gudangin.controller
{
    internal class Koneksi
    {
        string conectionstring = "Server=localhost;Database=eventory;Uid=root;Pwd=";
        MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(conectionstring);
            kon.Open();
        }
        public void CloseConnection()
        {
            kon.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, kon);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conectionstring);
            DataSet data = new DataSet();

            adapter.Fill(data);
            Object datatable = data.Tables[0];
            return datatable;
        }

        public MySqlDataReader reader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, kon);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
