using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4317
{
    public class Program
    {
        static void Main(string[] args)
        {
            Karyawan Paijo = new Karyawan("190302123", "Paijo", 4000000);
            Karyawan Jono = new Karyawan("190302124", "Jono",  2000000);


            Console.WriteLine("No nik / nama        Gaji bulanan");
            Console.WriteLine("---------------------------------");
            Console.Write("1 ");Paijo.Data();
            Console.Write("2 ");Jono.Data();
            Console.WriteLine();

            Paijo.naikGaji();
            Jono.naikGaji();

            Console.WriteLine();
            Console.WriteLine("No nik/nama          Gaji bulanan");
            Console.WriteLine("---------------------------------");
            Console.Write("1 ");Paijo.Data();
            Console.Write("2 ");Jono.Data();

            Console.ReadKey();

            

        }
    }
}
