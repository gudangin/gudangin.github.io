using Gudangin.controller;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gudangin.model
{
    internal class User
    {
        string id_user, username, password, role;

        public User()
        {
        }

        public User(string id_user, string username, string password, string role)
        {
            this.Id_user = id_user;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public string Id_user { get => id_user; set => id_user = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
