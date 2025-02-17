using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gudangin.model
{
    internal class Transaksi
    {
        public int Id { get; set; }
        public int IdBarang { get; set; }
        public string NamaBarang { get; set; }
        public string JenisTransaksi { get; set; }
        public int Jumlah { get; set; }
        public DateTime Tanggal { get; set; }

        public Transaksi() { }

        public Transaksi(int id, int idBarang, string namaBarang, string jenisTransaksi, int jumlah, DateTime tanggal)
        {
            this.Id = id;
            this.IdBarang = idBarang;
            this.NamaBarang = namaBarang;
            this.JenisTransaksi = jenisTransaksi;
            this.Jumlah = jumlah;
            this.Tanggal = tanggal;
        }
    }
}
