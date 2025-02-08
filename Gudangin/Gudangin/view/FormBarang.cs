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
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        Barang m_barang = new Barang();
        BarangController barang = new BarangController();
        public FormBarang()
        {
            InitializeComponent();
        }

        private void buttonBarang_Click(object sender, EventArgs e)
        {
            panelStats.Height = buttonBarang.Height;
            panelStats.Top = buttonBarang.Top;
            panelDataBarang.Visible = true;

        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            panelStats.Height = buttonTransaksi.Height;
            panelStats.Top = buttonTransaksi.Top;
            panelDataBarang.Visible = false;
            this.Hide();
            FormTransaksi formTransaksi = new FormTransaksi();
            formTransaksi.ShowDialog();
            this.Close();
        }

        private void buttonLaporan_Click(object sender, EventArgs e)
        {
            panelStats.Height = buttonLaporan.Height;
            panelStats.Top = buttonLaporan.Top;

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNamaBrg.Text) || string.IsNullOrWhiteSpace(textBoxStok.Text))
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_barang.Nama_barang = textBoxNamaBrg.Text;
                m_barang.Kategori = comboBoxKategori.SelectedItem.ToString();
                m_barang.Stok = textBoxStok.Text;

                if (barang.Insert(m_barang))
                {
                    Reset();
                    Tampil();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Tampil()
        {
            dataGridViewDataBarang.DataSource = koneksi.ShowData("SELECT * FROM barang");
            dataGridViewDataBarang.Columns[0].HeaderText = "id";
            dataGridViewDataBarang.Columns[1].HeaderText = "nama_barang";
            dataGridViewDataBarang.Columns[2].HeaderText = "kategori";
            dataGridViewDataBarang.Columns[3].HeaderText = "stok";
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }
        public void Reset()
        {
            textBoxNamaBrg.Text = "";
            textBoxStok.Text = "";
            textBoxCari.Text = "";
            comboBoxKategori.SelectedIndex = -1;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                if (barang.Delete(textBoxCari.Text))
                {
                    Reset();
                    Tampil();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNamaBrg.Text) || string.IsNullOrWhiteSpace(textBoxStok.Text))
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_barang.Id = textBoxCari.Text;
                m_barang.Nama_barang = textBoxNamaBrg.Text;
                m_barang.Kategori = comboBoxKategori.SelectedItem.ToString();
                m_barang.Stok = textBoxStok.Text;

                if (barang.Update(m_barang, textBoxCari.Text))
                {
                    Reset();
                    Tampil();
                }
                else
                {
                    MessageBox.Show("Gagal mengubah data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM barang WHERE id LIKE '%" + textBoxCari.Text + "%' OR nama_barang LIKE '%" + textBoxCari.Text + "%'";
            dataGridViewDataBarang.DataSource = koneksi.ShowData(query);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            Tampil();
        }

        private void dataGridViewDataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxNamaBrg.Text = dataGridViewDataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxKategori.SelectedItem = dataGridViewDataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxStok.Text = dataGridViewDataBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
