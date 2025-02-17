using Gudangin.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                koneksi.ExecuteQuery("INSERT INTO t_transaksi (id_barang, jenis_transaksi, jumlah, tanggal) " +
                                     "VALUES ('" + transaksi.Id_barang + "', '" + transaksi.Jenis_transaksi + "', '" + transaksi.Jumlah + "', '" + transaksi.Tanggal + "')");

                // Update stok di t_barang jika transaksi masuk atau keluar
                if (transaksi.Jenis_transaksi == "Masuk")
                {
                    koneksi.ExecuteQuery("UPDATE t_barang SET stok = stok + " + transaksi.Jumlah + " WHERE id = '" + transaksi.Id_barang + "'");
                }
                else if (transaksi.Jenis_transaksi == "Keluar")
                {
                    koneksi.ExecuteQuery("UPDATE t_barang SET stok = stok - " + transaksi.Jumlah + " WHERE id = '" + transaksi.Id_barang + "'");
                }

                status = true;
                MessageBox.Show("Transaksi berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal menambahkan transaksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                koneksi.ExecuteQuery("UPDATE t_transaksi SET id_barang='" + transaksi.Id_barang + "', jenis_transaksi='" + transaksi.Jenis_transaksi +
                                     "', jumlah='" + transaksi.Jumlah + "', tanggal='" + transaksi.Tanggal + "' WHERE id_transaksi='" + id + "'");
                status = true;
                MessageBox.Show("Data transaksi berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal mengubah transaksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                koneksi.ExecuteQuery("DELETE FROM t_transaksi WHERE id_transaksi='" + id + "'");
                status = true;
                MessageBox.Show("Data transaksi berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal menghapus transaksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
