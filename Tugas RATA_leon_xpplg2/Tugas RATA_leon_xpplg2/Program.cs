using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_RATA_leon_xpplg2
{
    internal class Program
    {
        static double Hasil(double nilai, double nilai2, double nilai3)
        {
            double Hasil = (nilai + nilai2 + nilai3) / 3;
            return Hasil;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            double nilai1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double nilai2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka ketiga: ");
            double nilai3 = Convert.ToDouble(Console.ReadLine());

            double hasil = Hasil(nilai1, nilai2, nilai3);
            Console.WriteLine("Hasil Rata-ratanya nya adalah: " + hasil);
        }
    }
}
