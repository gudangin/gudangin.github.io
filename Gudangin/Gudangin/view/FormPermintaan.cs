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

namespace Gudangin.view
{
    public partial class FormPermintaan : Form
    {
        private PermintaanController permintaanController = new PermintaanController();
        private Koneksi koneksi = new Koneksi();
        private int selectedIdPermintaan = -1; // ID permintaan yang dipilih
        public FormPermintaan()
        {
            InitializeComponent();
        }

        private void FormPermintaan_Load(object sender, EventArgs e)
        {
            LoadPermintaanPending();
        }

        private void LoadPermintaanPending()
        {
            if (permintaanController == null)
            {
                MessageBox.Show("permintaanController belum diinisialisasi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = permintaanController.GetPermintaanPending();

            if (dt == null)
            {
                MessageBox.Show("Gagal mengambil data permintaan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt.Rows.Count > 0)
            {
                dataGridViewDataPermintaan.DataSource = dt;
                dataGridViewDataPermintaan.Columns[0].HeaderText = "ID Permintaan";
                dataGridViewDataPermintaan.Columns[1].HeaderText = "Nama Barang";
                dataGridViewDataPermintaan.Columns[2].HeaderText = "Jumlah";
                dataGridViewDataPermintaan.Columns[3].HeaderText = "Status";
                dataGridViewDataPermintaan.Columns[4].HeaderText = "Tanggal Permintaan";
                dataGridViewDataPermintaan.Columns[5].HeaderText = "User";
            }
            else
            {
                MessageBox.Show("Tidak ada permintaan pending.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewDataPermintaan.DataSource = null;
            }
        }

        private void dataGridViewDataPermintaan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDataPermintaan.Rows[e.RowIndex];

                selectedIdPermintaan = Convert.ToInt32(row.Cells[0].Value); // Simpan ID permintaan

                // Debugging untuk memastikan ID terbaca
                MessageBox.Show($"ID Permintaan Dipilih: {selectedIdPermintaan}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tombol aktif jika ada data yang dipilih
                buttonSetuju.Enabled = true;
                buttonTolak.Enabled = true;
            }
        }

        private void buttonSetuju_Click(object sender, EventArgs e)
        {
            if (selectedIdPermintaan == -1)
            {
                MessageBox.Show("Pilih permintaan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (permintaanController.UpdateStatusPermintaan(selectedIdPermintaan, "Disetujui"))
            {
                MessageBox.Show("Permintaan berhasil disetujui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPermintaanPending(); // Refresh daftar permintaan
            }
            else
            {
                MessageBox.Show("Gagal menyetujui permintaan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTolak_Click(object sender, EventArgs e)
        {
            if (selectedIdPermintaan == -1)
            {
                MessageBox.Show("Pilih permintaan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (permintaanController.UpdateStatusPermintaan(selectedIdPermintaan, "Ditolak"))
            {
                MessageBox.Show("Permintaan berhasil ditolak.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPermintaanPending(); // Refresh daftar permintaan
            }
            else
            {
                MessageBox.Show("Gagal menolak permintaan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            userController.Logout(this);
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            FormTransaksi formTransaksi = new FormTransaksi();
            formTransaksi.ShowDialog();
            this.Close();
        }

        private void buttonBarang_Click(object sender, EventArgs e)
        {
          
            
            this.Hide();
            FormBarang formBarang = new FormBarang();
            formBarang.ShowDialog();
            this.Close();

        }
    }
}
