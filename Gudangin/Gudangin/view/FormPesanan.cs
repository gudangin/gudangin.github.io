using Gudangin.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Gudangin.view
{
    public partial class FormPesanan : Form
    {
        private PermintaanController permintaanController = new PermintaanController();
        private Koneksi koneksi = new Koneksi();
        private int id_user; // ID user yang sedang login
        private int selectedIdPermintaan = -1;
        private string selectedStatus = ""; // Menyimpan status pesanan

        public FormPesanan(int userId)
        {
            InitializeComponent();
            this.id_user = userId;
        }

        private void FormPesanan_Load(object sender, EventArgs e)
        {
            LoadPesananUser();
        }

        private void LoadPesananUser()
        {
            DataTable dt = permintaanController.GetPermintaanUser(id_user);

            if (dt.Rows.Count > 0)
            {
                dataGridViewDataPesanan.DataSource = dt;
                dataGridViewDataPesanan.Columns[0].HeaderText = "ID Permintaan";
                dataGridViewDataPesanan.Columns[1].HeaderText = "Nama Barang";
                dataGridViewDataPesanan.Columns[2].HeaderText = "Jumlah";
                dataGridViewDataPesanan.Columns[3].HeaderText = "Status";
                dataGridViewDataPesanan.Columns[4].HeaderText = "Tanggal Permintaan";
            }
            else
            {
                dataGridViewDataPesanan.DataSource = null;
                MessageBox.Show("Tidak ada pesanan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewDataPesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDataPesanan.Rows[e.RowIndex];

                selectedIdPermintaan = Convert.ToInt32(row.Cells[0].Value); // Simpan ID permintaan
                textBoxNamaBrg.Text = row.Cells[1].Value.ToString();
                textBoxJumlah.Text = row.Cells[2].Value.ToString();
                selectedStatus = row.Cells[3].Value.ToString(); // Simpan status

                // Hanya bisa membatalkan pesanan jika status masih "Pending"
                buttonBatal.Enabled = selectedStatus == "pending";
            }
        }

        private void buttonBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUser formUser = new FormUser(id_user);
            formUser.ShowDialog();
            this.Close();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            if (selectedIdPermintaan == -1)
            {
                MessageBox.Show("Pilih pesanan yang ingin dibatalkan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi pembatalan
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin membatalkan pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (permintaanController.HapusPermintaan(selectedIdPermintaan))
                {
                    MessageBox.Show("Pesanan berhasil dibatalkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPesananUser(); // Refresh daftar pesanan
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Gagal membatalkan pesanan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void ResetForm()
        {
            selectedIdPermintaan = -1;
            textBoxNamaBrg.Clear();
            textBoxJumlah.Clear();
            buttonBatal.Enabled = false;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            userController.Logout(this);
        }
    }
}
