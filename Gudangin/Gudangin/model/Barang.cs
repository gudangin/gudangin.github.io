using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gudangin.model
{
    internal class Barang
    {
        string id, nama_barang, kategori, stok;

        public Barang()
        {
        }

        public Barang(string id, string nama_barang, string kategori, string stok)
        {
            this.Id = id;
            this.Nama_barang = nama_barang;
            this.Kategori = kategori;
            this.Stok = stok;
        }

        public string Id { get => id; set => id = value; }
        public string Nama_barang { get => nama_barang; set => nama_barang = value; }
        public string Kategori { get => kategori; set => kategori = value; }
        public string Stok { get => stok; set => stok = value; }
    }
}