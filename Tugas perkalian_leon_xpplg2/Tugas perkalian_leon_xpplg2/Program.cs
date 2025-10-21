using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_perkalian_leon_xpplg2
{
    internal class Program
    {
        static double Hasil(double angka1, double angka2, double angka3)
        {
            double Hasil = angka1 * angka2 * angka3;
            return Hasil;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            double angka1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka ketiga: ");
            double angka3 = Convert.ToDouble(Console.ReadLine());

            double hasil = Hasil(angka1, angka2, angka3);
            Console.WriteLine("Hasil nya adalah: " + hasil);
        }
    }
}
