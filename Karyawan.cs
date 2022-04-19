using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4317
{
    class Karyawan
    {
        private string nik;
        private string nama;
        private int gajiBulanan;

        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
       

        public Karyawan(string nik, string nama, int gajiBulanan)
        {
            this.nik = nik;
            this.nama = nama;
            this.gajiBulanan = gajiBulanan < 0 ? 0 : gajiBulanan;
        }

        public void Data()
        {
            Console.WriteLine("{0} {1}      {2}", nik, nama, gajiBulanan);
        }

        public void naikGaji()
        {
            int kenaikan;

            kenaikan = gajiBulanan * 110;
            gajiBulanan = kenaikan / 100;

            Console.WriteLine("asyiiik naik gaji 10%");
        }
    }



}
