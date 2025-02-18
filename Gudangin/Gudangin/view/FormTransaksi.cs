using Gudangin.controller;
using Gudangin.model;
using Gudangin.lib;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gudangin.view
{
    public partial class FormTransaksi : Form
    {
        Koneksi koneksi = new Koneksi();
        TransaksiController transaksi = new TransaksiController();
        Transaksi m_transaksi = new Transaksi();
        public FormTransaksi()
        {
            InitializeComponent();
            TampilTransaksi();
        }

        private void TampilTransaksi()
        {
            DataTable dt = koneksi.ShowData("SELECT t_transaksi.id_transaksi, t_barang.nama_barang, t_transaksi.jenis_transaksi, t_transaksi.jumlah, t_transaksi.tanggal FROM t_transaksi JOIN t_barang ON t_transaksi.id_barang = t_barang.id");

            if (dt != null && dt.Rows.Count > 0)
            {
                DataTransaksi.DataSource = dt;
                DataTransaksi.Refresh(); // Paksa DataGridView untuk update data

                DataTransaksi.Columns[0].HeaderText = "ID Transaksi";
                DataTransaksi.Columns[1].HeaderText = "Nama Barang";
                DataTransaksi.Columns[2].HeaderText = "Jenis Transaksi";
                DataTransaksi.Columns[3].HeaderText = "Jumlah";
                DataTransaksi.Columns[4].HeaderText = "Tanggal";
            }
            else
            {
                MessageBox.Show("Tidak ada data transaksi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTransaksi.DataSource = null;
            }
        }
        private Dictionary<string, int> barangDict = new Dictionary<string, int>();

        private void LoadBarang()

        {
            try
            {
                koneksi.OpenConnection();
                MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string namaBarang = reader["nama_barang"].ToString();
                        comboBoxNamaBarang.Items.Add(namaBarang);
                    }
                }
                else
                {
                    MessageBox.Show("Tidak ada barang yang tersedia!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
                koneksi.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data barang: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            comboBoxJenisTransaksi.SelectedIndex = -1;
            comboBoxNamaBarang.SelectedIndex = -1;
            tbJumlah.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }

        private void buttonBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBarang formBarang = new FormBarang();
            formBarang.ShowDialog();
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (comboBoxJenisTransaksi.SelectedItem == null || comboBoxNamaBarang.SelectedItem == null || string.IsNullOrWhiteSpace(tbJumlah.Text))
            {
                MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Jenis_transaksi = comboBoxJenisTransaksi.SelectedItem.ToString();
            string Nama_barang = comboBoxNamaBarang.SelectedItem.ToString();
            int Jumlah;

            if (!int.TryParse(tbJumlah.Text, out Jumlah) || Jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tanggal = dateTimePicker.Value.ToString("yyyy-MM-dd");

            // Cari ID Barang berdasarkan nama barang
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader($"SELECT id, stok FROM t_barang WHERE nama_barang = '{Nama_barang}'");

            int Id_barang = -1;
            int stokSekarang = 0;

            if (reader.Read())
            {
                Id_barang = reader.GetInt32("id");
                stokSekarang = reader.GetInt32("stok");
            }
            reader.Close();
            koneksi.CloseConnection();

            if (Id_barang == -1)
            {
                MessageBox.Show("Barang tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi stok barang jika transaksi keluar
            if (Jenis_transaksi == "Keluar")
            {
                if (Jumlah > stokSekarang)
                {
                    MessageBox.Show($"Stok tidak mencukupi! Stok saat ini: {stokSekarang}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kurangi stok barang
                koneksi.ExecuteQuery($"UPDATE t_barang SET stok = stok - {Jumlah} WHERE id = {Id_barang}");
            }
            else if (Jenis_transaksi == "Masuk")
            {
                // Tambah stok barang
                koneksi.ExecuteQuery($"UPDATE t_barang SET stok = stok + {Jumlah} WHERE id = {Id_barang}");
            }

            // Simpan transaksi ke database
            m_transaksi.Id_barang = Id_barang.ToString();
            m_transaksi.Jenis_transaksi = Jenis_transaksi;
            m_transaksi.Jumlah = Jumlah.ToString();
            m_transaksi.Tanggal = tanggal;

            if (transaksi.Insert(m_transaksi))
            {
                ResetForm();
                TampilTransaksi();
            }
        }
                private void comboBoxNamaBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNamaBarang.SelectedItem != null)
            {
                string Nama_barang = comboBoxNamaBarang.SelectedItem.ToString();
                MessageBox.Show($"Barang dipilih: {Nama_barang}", "Informasi Barang", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadBarang();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            save.FileName = "Report Transaksi.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string directory = Path.GetDirectoryName(save.FileName);
                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(save.FileName);
                string extension = Path.GetExtension(save.FileName);
                int count = 1;
                string filePath = save.FileName;
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(directory, $"{fileNameWithoutExt}({count}){extension}");
                    count++;
                }

                //Membuat instance dari kelas Excel
                Excel excel_lib = new Excel();

                //Memanggil metode ExportToExcel
                excel_lib.ExportToExcel(DataTransaksi, filePath);

                //Notifikasi berhasil
                MessageBox.Show("Data berhasil diekspor ke file Excel.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }

        private void buttonPesanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPermintaan formPermintaan = new FormPermintaan();
            formPermintaan.ShowDialog();
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            userController.Logout(this);
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            LoadBarang();
        }
    }
    }
