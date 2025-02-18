using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gudangin.model
{
    internal class Permintaan
    {
        public int Id_permintaan { get; set; }
        public int Id_user { get; set; }
        public int Id_barang { get; set; }
        public int Jumlah { get; set; }
        public string Status { get; set; }
        public DateTime Tanggal_permintaan { get; set; }

        public Permintaan() { }

        public Permintaan(int idUser, int idBarang, int jumlah)
        {
            this.Id_user = idUser;
            this.Id_barang = idBarang;
            this.Jumlah = jumlah;
            this.Status = "Pending"; // Status default
            this.Tanggal_permintaan = DateTime.Now;
        }
    }
}

