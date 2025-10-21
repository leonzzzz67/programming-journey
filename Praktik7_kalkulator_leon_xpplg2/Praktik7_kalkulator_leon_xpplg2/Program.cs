using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7_kalkulator_leon_xpplg2
{
    internal class Program
    {
        // Method Main adalah titik awal eksekusi program
        static void Main(string[] args)
        {
            string hitunglagi; // Variable untuk menyimpan pilihan pengguna(y/n)

            // Perulangan do-while akan menjalankan blok kode setidaknya satu kali
            // dan akan terus berjalan selama kondisi while terpenuhi
            do
            {
                Console.Clear(); // Membersihkan layar konsol untuk setiap perhitungan baru
                Console.WriteLine("--- KALKULATOR SEDERHANA ---");

                // Memanggil fungsi untuk mendapatkan input angka dari user
                TampilkanMenu();

                Console.Write("Masukkan pilihan operasi (1-4): ");
                string pilihan = Console.ReadLine();

                // Variable untuk menampung angka dan hasil
                double angka1, angka2, hasil = 0;

                // Memanggil fungsi  untuk mendapatkan input angka dari user 
                // dan memastikan input adalah angka yang valid
                if (AmbilInputAngka(out angka1, out angka2))
                {
                    // Struktur pemilihan switch-case untuk menentukan operasi
                    switch (pilihan)
                    {
                        case "1": // penjumlahan 
                            hasil = Tambah(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} + {angka2} = {hasil}");
                            break;

                        case "2": // pengurangan
                            hasil = Kurang(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} - {angka2} = {hasil}");
                            break;

                        case "3": // perkalian
                            hasil = Kali(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} * {angka2} = {hasil}");
                            break;

                        case "4": // pembagian
                                  // penanganan khusu untuk pembagian dengan nol
                            if (angka2 == 0)
                            {
                                Console.WriteLine("\nERROR: Tidak dapat melakukan pembagian dengan angka nol.");
                            }
                            else
                            {
                                hasil = Bagi(angka1, angka2);
                                Console.WriteLine($"\nHasil: {angka1} / {angka2} = {hasil}");
                                  }
                            break;
                        default: // Jika pilihan tidak ada di case 1-4
                            Console.WriteLine("\nPilihan yang anda masukkan tidak valid. ");
                            break;
                    }
                }
                // Menanyakan kepada pengguna apakah ingin menghitung lagi
                Console.Write("\n Apakah anda ingin menghitungkemali? (y/n): ");
                hitunglagi = Console.ReadLine();
                // .ToLower() membuat input menjadi huruf kecil,jadi 'Y' atau 'y'  akan sama

            } while (hitunglagi.ToLower() == "y");

            // Pesan penuup jika pengguna memilih keluar
            Console.WriteLine("\nTerima kasih telah menggunakan kalkulator ini. " + "Tekan tombol apa saja untuk keluar.");
            Console.ReadKey();
        }

        // --- FUNGSI - FUNGSI BANTUAN ---

        // Fungsi untuk menamplkan menu pilihan
        static void TampilkanMenu()
        {
            Console.WriteLine("Pilih operasi matematika");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

        }

        // Fungsi untuk mengambil input angka dari pegguna
        // Menggunakkan 'out' karena fungsi ini mengembaliksn lebih dari satu nilai
        static bool AmbilInputAngka(out double angka1, out double angka2)
        {
            Console.Write("Masukkan angka pertama: ");
            // double.TryParse akan mencoba mengkonversi string ke double.
            // Jika berhasil, return true dan nilainya disimpan di vaariable 'angka'.
            // Jika gagal, return false.
            if (!double.TryParse(Console.ReadLine(), out angka1))
            {
                Console.WriteLine("Input untuk angka pertama tidak valid.");
                angka2 = 0; // Beri niali default agar tidak error
                return false;
            }

            Console.Write("Masukkann angka kedua: ");
            if (double.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("Input untuk angka kedua tidak valid.");
            }

            return true; // Jika input kedua tidak valid
        }
        // Fungsi untuk operasi penjumlahan
        static double Tambah(double a, double b)
        {
            return a + b;
        }
        // Fungsi untuk operasi pengurangan
        static double Kurang(double a, double b)
        {
            return a - b;
        }
        // Fungsi untuk operasi perkalian
        static double Kali(double a, double b)
        {
            return a * b;
        }
        // Fungsi untuk operasi pembagian
        static double Bagi(double a, double b)
        {
            return a / b;
        }
    }

}
