using Gudangin.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gudangin.controller
{
    internal class PermintaanController
    {
        Koneksi koneksi = new Koneksi();

        public bool TambahPermintaan(Permintaan permintaan)
        {
            try
            {
                string query = $"INSERT INTO t_permintaan (id_user, id_barang, jumlah, status, tanggal_permintaan) " +
                               $"VALUES ({permintaan.Id_user}, {permintaan.Id_barang}, {permintaan.Jumlah}, " +
                               $"'Pending', CURDATE())";

                koneksi.ExecuteQuery(query); // Jalankan query
                return true; // Jika berhasil
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false; // Jika gagal
            }
        }

        public DataTable GetPermintaanUser(int idUser)
        {
            string query = $"SELECT p.id_permintaan, b.nama_barang, p.jumlah, p.status, p.tanggal_permintaan " +
                           $"FROM t_permintaan p JOIN t_barang b ON p.id_barang = b.id " +
                           $"WHERE p.id_user = {idUser} ORDER BY p.tanggal_permintaan DESC";

            return koneksi.ShowData(query);
        }

        public bool HapusPermintaan(int idPermintaan)
        {
            try
            {
                string query = $"DELETE FROM t_permintaan WHERE id_permintaan = {idPermintaan} AND status = 'Pending'";

                koneksi.ExecuteQuery(query); // Jalankan query
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public DataTable GetPermintaanPending()
        {
            string query = $"SELECT p.id_permintaan, b.nama_barang, p.jumlah, p.status, p.tanggal_permintaan, u.username " +
                   $"FROM t_permintaan p " +
                   $"JOIN t_barang b ON p.id_barang = b.id " +
                   $"JOIN t_user u ON p.id_user = u.id_user " +
                   $"WHERE p.status = 'Pending' " +
                   $"ORDER BY p.tanggal_permintaan DESC";

            DataTable dt = koneksi.ShowData(query);

            if (dt == null)
            {
                MessageBox.Show("Query tidak mengembalikan data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt ?? new DataTable(); // Hindari null reference
        }

        public bool UpdateStatusPermintaan(int idPermintaan, string newStatus)
        {
            try
            {
                string query = $"UPDATE t_permintaan SET status = '{newStatus}' WHERE id_permintaan = {idPermintaan}";
                koneksi.ExecuteQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
