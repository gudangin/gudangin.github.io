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
        BarangController barangController = new BarangController(); // Tambahkan controller barang
        User m_user = new User();

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

                // **Tambahkan pengecekan stok sebelum membuka form utama**
                CekStokHampirHabis();

                this.Hide();

                if (m_user.Role == "admin")
                {
                    FormBarang formMain = new FormBarang();
                    formMain.ShowDialog();
                }
                else
                {
                    FormUser userDashboard = new FormUser(Convert.ToInt32(m_user.Id_user));
                    userDashboard.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CekStokHampirHabis()
        {
            DataTable dt = barangController.GetStokHampirHabis();

            if (dt.Rows.Count > 0)
            {
                string pesan = "Barang berikut hampir habis:\n";
                foreach (DataRow row in dt.Rows)
                {
                    pesan += $"{row["nama_barang"]} - Stok: {row["stok"]}\n";
                }
                MessageBox.Show(pesan, "Peringatan Stok Hampir Habis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
