using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._8_leon_xpplg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangiPilihan;

            do
            {
                // --- Blok proses yang akan diulangi ---
                Console.WriteLine("----------------------");
                Console.Write("Masukkan nama anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama}! Proses telah selesai.");
                //--------------------------------------
                // Pertannyaan untuk mengulang
                Console.Write("Apakah anda inngin mengulangi lagi? (ya/tidak): ");
                ulangiPilihan = Console.ReadLine().ToLower(); // Megambil iput dan mengubah ke huruf kecil

                Console.WriteLine(); //  Baris kosong untuk kerapian

                // Kondisi diperiksa di  akhir: Ulagni selama pengguna mengetik "ya"
            } while (ulangiPilihan == "ya");
            Console.WriteLine("Terima kasih.Program selesai");
        }
    }
}
