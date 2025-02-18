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
    public partial class FormUser : Form
    {
        private PermintaanController permintaanController = new PermintaanController();
        private Koneksi koneksi = new Koneksi();
        private int id_user;

        public FormUser(int id_user)
        {
            InitializeComponent();
            this.id_user = id_user;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            LoadDataBarang();  // Tampilkan daftar barang
        }

        private void LoadDataBarang()
        {
            DataTable dt = koneksi.ShowData("SELECT id, nama_barang, kategori, stok FROM t_barang");

            if (dt.Rows.Count > 0)
            {
                dataGridViewDataBarang.DataSource = dt;
                dataGridViewDataBarang.Columns[0].HeaderText = "ID";
                dataGridViewDataBarang.Columns[1].HeaderText = "Nama Barang";
                dataGridViewDataBarang.Columns[2].HeaderText = "Kategori";
                dataGridViewDataBarang.Columns[3].HeaderText = "Stok";
            }
            else
            {
                MessageBox.Show("Tidak ada data barang!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewDataBarang.DataSource = null;
            }
        }

        private void dataGridViewDataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDataBarang.Rows[e.RowIndex];

                textBoxNamaBrg.Text = row.Cells[1].Value.ToString(); // Nama Barang
                comboBoxKategori.Text = row.Cells[2].Value.ToString(); // Kategori
                textBoxJumlah.Text = ""; // Kosongkan jumlah, harus diisi user

                // Simpan ID barang ke dalam Tag TextBox
                textBoxNamaBrg.Tag = row.Cells[0].Value.ToString();
            }
        }

        private void buttonPesan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxJumlah.Text) || !int.TryParse(textBoxJumlah.Text, out int jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Masukkan jumlah yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxNamaBrg.Tag == null)
            {
                MessageBox.Show("Pilih barang terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBarang = Convert.ToInt32(textBoxNamaBrg.Tag);

            // Buat objek permintaan
            Permintaan permintaan = new Permintaan(id_user, idBarang, jumlah);

            // Simpan ke database menggunakan Controller
            if (permintaanController.TambahPermintaan(permintaan))
            {
                MessageBox.Show("Pesanan berhasil dikirim ke admin!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNamaBrg.Clear();
                comboBoxKategori.Text = "";
                textBoxJumlah.Clear();
            }
            else
            {
                MessageBox.Show("Gagal mengirim pesanan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBarang_Click(object sender, EventArgs e)
        {
            panelStats.Height = buttonBarang.Height;
            panelStats.Top = buttonBarang.Top;
            panelDataBarang.Visible = true;
        }

        private void buttonStatusPesanan_Click(object sender, EventArgs e)
        {
            panelStats.Height = buttonStatusPesanan.Height;
            panelStats.Top = buttonStatusPesanan.Top;
            panelDataBarang.Visible = false;
            this.Hide();
            FormPesanan formPesanan = new FormPesanan(id_user);
            formPesanan.ShowDialog();
            this.Close();
        }
    }
}
