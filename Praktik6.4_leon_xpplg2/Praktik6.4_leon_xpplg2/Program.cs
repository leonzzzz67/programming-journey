using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._4_leon_xpplg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Inisialisasi variable penghitung(counter)
            int hitungan = 5;

            Console.WriteLine("Memulai hitungan mundur");
            // 2. Perulangaan 'while'
            // Kondisi: Selama nialai 'hitungan' lebih besar dai 0
            while (hitungan > 0)
            {
                // Blok kode didalam perulangan
                Console.WriteLine($"Hitungan: {hitungan}");

                // 3. Update variable penghitungan (decrement/pengurangan)
                // Ini PENTING agar perulangan tidak menjadi loop tak terbatas (infinite loop)
                hitungan = hitungan - 1;
                // atau bisa juga ditulis: hitugan--;

                // Kode setelah perulangan selesai
                Console.WriteLine("Selesai! Hitungan mundur telah berakhir. ");
            }
        }
    }
}
