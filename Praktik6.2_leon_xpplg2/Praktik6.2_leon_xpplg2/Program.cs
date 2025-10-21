using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._2_leon_xpplg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable untuk menyimpan hasil penjjumlahan
            int total = 0;

            Console.WriteLine("Menghitung jumlah anka dari 1 sampai 5");

            // Perulangan for dari 1 hingga 5
            for (int i = 1; i <= 5; i++)
            {
                // Tambahkan nialai i saat ini ke variable total
                total = total + i; // bisa juga ditulis sebagai: total += i;

                // Tampilkan proses penjumlahan di setiap langkah
                Console.WriteLine("Menambahkan " + i + ", total sementara = " + total);

                // Tampilkan  hasil akhir  setelah perulangan selesai
                Console.WriteLine("\nHasil akhir penjumlahan adalah: " + total);
            }
        }
    }
}
