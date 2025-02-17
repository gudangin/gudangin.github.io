using Gudangin.controller;
using Gudangin.model;
using MySql.Data.MySqlClient;
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
    public partial class FormTransaksi : Form
    {
        Koneksi koneksi = new Koneksi();
        TransaksiController transaksi = new TransaksiController();
        Transaksi m_transaksi = new Transaksi();
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            TampilTransaksi();
            LoadBarang();
        }

        private void TampilTransaksi()
        {
            DataTransaksi.DataSource = koneksi.ShowData("SELECT t_transaksi.id_transaksi, t_barang.nama_barang, t_transaksi.jenis_transaksi, t_transaksi.jumlah, t_transaksi.tanggal FROM t_transaksi JOIN t_barang ON t_transaksi.id_barang = t_barang.id");
            DataTransaksi.Columns[0].HeaderText = "ID Transaksi";
            DataTransaksi.Columns[1].HeaderText = "Nama Barang";
            DataTransaksi.Columns[2].HeaderText = "Jenis Transaksi";
            DataTransaksi.Columns[3].HeaderText = "Jumlah";
            DataTransaksi.Columns[4].HeaderText = "Tanggal";
        }
        private void LoadBarang()
        {
            MySqlDataReader reader = koneksi.reader("SELECT nama_barang FROM t_barang");
            while (reader.Read())
            {
                comboBoxNamaBarang.Items.Add(reader["nama_barang"].ToString());
            }
            reader.Close();
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
            int Jumlah = int.Parse(tbJumlah.Text);
            string Tanggal = dateTimePicker.Value.ToString("yyyy-MM-dd");

            // Cek ID barang berdasarkan nama barang
            MySqlDataReader reader = koneksi.reader($"SELECT id, stok FROM t_barang WHERE nama_barang = '{Nama_barang}'");
            int Id_barang = 0, stokSekarang = 0;

            if (reader.Read())
            {
                Id_barang = Convert.ToInt32(reader["id"]);
                stokSekarang = Convert.ToInt32(reader["stok"]);
            }
            reader.Close();

            if (Id_barang == 0)
            {
                MessageBox.Show("Barang tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Jenis_transaksi == "Keluar" && Jumlah > stokSekarang)
            {
                MessageBox.Show("Stok tidak mencukupi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simpan transaksi
            //transaksi.id_barang = Id_barang.ToString();
            //transaksi.jenis_transaksi = Jenis_transaksi;
            //transaksi.jumlah = Jumlah.ToString();
            //transaksi.tanggal = Tanggal;

            //if (transaksi.Insert(transaksi))
            //{
            //    ResetForm();
            //    TampilTransaksi();
            //}
        }
    }
}
