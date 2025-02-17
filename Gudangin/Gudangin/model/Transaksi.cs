using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gudangin.model
{
    internal class Transaksi
    {
        string id, id_barang, jenis_transaksi, jumlah, tanggal;
       

        public Transaksi() { }

        public Transaksi(string id, string id_barang, string jenis_transaksi, string jumlah, string tanggal)
        {
            this.Id = id;
            this.Id_barang = id_barang;
            //this.NamaBarang = namaBarang;
            this.Jenis_transaksi = jenis_transaksi;
            this.Jumlah = jumlah;
            this.Tanggal = tanggal;
        }

        public string Id { get => id; set => id = value; }
        public string Id_barang { get => id_barang; set => id_barang = value; }

        //public string NamaBarang { get; set; }
        public string Jenis_transaksi { get => jenis_transaksi; set => jenis_transaksi = value; }
        public string Jumlah { get => jumlah; set => jumlah = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
    }
}
