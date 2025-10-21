using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._3_leon_xpplg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi variable untuk menyimpan input
            string inputUser = "";

            Console.WriteLine("Program akan terus berjalan  hingga anda mengetik 'keluar' ");

            // Perulangan selama isi variable inputUser TIDAK SAMA DENGAN "keluar"
            while (inputUser.ToLower() != "keluar") 
            {
                Console.WriteLine("\n Ketik sesuatau (atau 'keluar' untuk berhenti): ");
                inputUser = Console.ReadLine(); // Baca input dari user

                Console.WriteLine("Anda mengetik: " + inputUser);
            }

            Console.WriteLine("\nProgram selesai. Teerima Kasih!");
             }
            }
        }
    

