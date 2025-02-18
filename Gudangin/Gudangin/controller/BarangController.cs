using Gudangin.model;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gudangin.controller
{
    internal class BarangController
    {
        Koneksi koneksi = new Koneksi();

        // Insert Data Barang
        public bool Insert(Barang barang)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                string query = "INSERT INTO t_barang (nama_barang, kategori, stok) VALUES (@nama, @kategori, @stok)";
                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);
                cmd.Parameters.AddWithValue("@nama", barang.Nama_barang);
                cmd.Parameters.AddWithValue("@kategori", barang.Kategori);
                cmd.Parameters.AddWithValue("@stok", barang.Stok);
                cmd.ExecuteNonQuery();
                status = true;

                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal menambahkan data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        // Update Data Barang
        public bool Update(Barang barang, string id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                string query = "UPDATE t_barang SET nama_barang = @nama, kategori = @kategori, stok = @stok WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);
                cmd.Parameters.AddWithValue("@nama", barang.Nama_barang);
                cmd.Parameters.AddWithValue("@kategori", barang.Kategori);
                cmd.Parameters.AddWithValue("@stok", barang.Stok);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                status = true;

                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal mengubah data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        // Delete Data Barang
        public bool Delete(string id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                string query = "DELETE FROM t_barang WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                status = true;

                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal menghapus data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public DataTable GetStokHampirHabis()
        {
            string query = "SELECT nama_barang, stok FROM t_barang WHERE stok <= 10";
            return koneksi.ShowData(query);
        }
    }
}
