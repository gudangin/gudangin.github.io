using Gudangin.model;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gudangin.controller
{
    internal class TransaksiController
    {
        Koneksi koneksi = new Koneksi();

        // Insert Data Transaksi
        public bool Insert(Transaksi transaksi)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                // Validasi stok jika transaksi adalah "Keluar"
                if (transaksi.Jenis_transaksi == "Keluar")
                {
                    string cekStokQuery = "SELECT stok FROM t_barang WHERE id = @id_barang";
                    MySqlCommand cekStokCmd = new MySqlCommand(cekStokQuery, koneksi.kon);
                    cekStokCmd.Parameters.AddWithValue("@id_barang", transaksi.Id_barang);
                    int stokSekarang = Convert.ToInt32(cekStokCmd.ExecuteScalar());

                    if (stokSekarang < Convert.ToInt32(transaksi.Jumlah))
                    {
                        MessageBox.Show("Stok tidak mencukupi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        koneksi.CloseConnection();
                        return false;
                    }
                }

                // Query Insert dengan parameterized query
                string query = "INSERT INTO t_transaksi (id_barang, jenis_transaksi, jumlah, tanggal) " +
                               "VALUES (@id_barang, @jenis_transaksi, @jumlah, @tanggal)";
                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);
                cmd.Parameters.AddWithValue("@id_barang", transaksi.Id_barang);
                cmd.Parameters.AddWithValue("@jenis_transaksi", transaksi.Jenis_transaksi);
                cmd.Parameters.AddWithValue("@jumlah", transaksi.Jumlah);
                cmd.Parameters.AddWithValue("@tanggal", transaksi.Tanggal);
                cmd.ExecuteNonQuery();

                // Update stok di t_barang jika transaksi masuk atau keluar
                if (transaksi.Jenis_transaksi == "Masuk")
                {
                    string updateQuery = "UPDATE t_barang SET stok = stok + @jumlah WHERE id = @id_barang";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, koneksi.kon);
                    updateCmd.Parameters.AddWithValue("@jumlah", transaksi.Jumlah);
                    updateCmd.Parameters.AddWithValue("@id_barang", transaksi.Id_barang);
                    updateCmd.ExecuteNonQuery();
                }
                else if (transaksi.Jenis_transaksi == "Keluar")
                {
                    string updateQuery = "UPDATE t_barang SET stok = stok - @jumlah WHERE id = @id_barang";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, koneksi.kon);
                    updateCmd.Parameters.AddWithValue("@jumlah", transaksi.Jumlah);
                    updateCmd.Parameters.AddWithValue("@id_barang", transaksi.Id_barang);
                    updateCmd.ExecuteNonQuery();
                }

                status = true;
                MessageBox.Show("Transaksi berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal menambahkan transaksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                koneksi.CloseConnection();
            }
            return status;
        }

        // Update Data Transaksi
        public bool Update(Transaksi transaksi, string id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                string query = "UPDATE t_transaksi SET id_barang = @id_barang, jenis_transaksi = @jenis_transaksi, " +
                               "jumlah = @jumlah, tanggal = @tanggal WHERE id_transaksi = @id";
                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);
                cmd.Parameters.AddWithValue("@id_barang", transaksi.Id_barang);
                cmd.Parameters.AddWithValue("@jenis_transaksi", transaksi.Jenis_transaksi);
                cmd.Parameters.AddWithValue("@jumlah", transaksi.Jumlah);
                cmd.Parameters.AddWithValue("@tanggal", transaksi.Tanggal);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                status = true;
                MessageBox.Show("Data transaksi berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal mengubah transaksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                koneksi.CloseConnection();
            }
            return status;
        }

        // Delete Data Transaksi
        public bool Delete(string id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                string query = "DELETE FROM t_transaksi WHERE id_transaksi = @id";
                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                status = true;
                MessageBox.Show("Data transaksi berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal menghapus transaksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                koneksi.CloseConnection();
            }
            return status;
        }
    }
}
