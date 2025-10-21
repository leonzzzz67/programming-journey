using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._6_leon_xpplg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;

            // Blok 'do' akan dieksekui minimal satu kali
            do
            {
             Console.WriteLine("Masukkan angka genap: ");
             // Mencoba membaca input dari pengguna
             if (!int.TryParse(Console.ReadLine(), out angka))
             {
              Console.WriteLine("Input tdiak valid. Silahkan masukkan angka.");
              // Jika input tidak valid, set angka 1 (ganjil) agar loop berlanjut
              angka = 1;
             continue; // Lanjutkan ke literasi berikutnya
             }
                // Memeriksa apakah angka tersebut ganjil
                if (angka % 2 != 0)
                {
                    Console.WriteLine($"Angka {angka} adalah ganjil. Coba lagi.");
                }
            // Kondisi diperiksa di akhir. Loop berlanjut selama angka Ganjil.
                } while (angka % 2 != 0);
            Console.WriteLine($"Selamat! Anda memasukkan angka genap: {angka}");

        }
    }
}
