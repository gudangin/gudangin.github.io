using Gudangin.controller;
using Gudangin.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gudangin.view
{
    public partial class FormLogin : Form
    {
        UserController userController = new UserController();
        User m_user = new User(); // Model User dibuat di dalam FormLogin
        public FormLogin()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            m_user.Username = tbUsername.Text.Trim();
            m_user.Password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(m_user.Username) || string.IsNullOrEmpty(m_user.Password))
            {
                MessageBox.Show("Username dan password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userController.Authenticate(m_user))
            {
                MessageBox.Show("Login berhasil sebagai " + m_user.Role, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if (m_user.Role == "admin")
                {
                    FormBarang formMain = new FormBarang();
                    formMain.Show();
                }
                else
                {
                    FormUser userDashboard = new FormUser();
                    userDashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
