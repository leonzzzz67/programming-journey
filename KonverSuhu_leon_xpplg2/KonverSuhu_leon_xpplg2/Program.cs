using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonverSuhu_leon_xpplg2
{
    internal class Program
    {
        // *Buat fungsi KonversiSuhu untuk mengubah suhu dari Celcius ke Fahrenheit dengan rumus: F = (C * 9/5) + 32
        // Tampilkan hasil konversi pada prrogram utama
        static double ConvertCelciusToFahrenheit(double celcius)
        {
            double fahrenheit = (celcius * 9 / 5) + 32;
            return fahrenheit;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program Konversi suhu dari Celcius ke Fahrenheit.");
            Console.Write("Masukkan angka suhu ke dalam Celcius: ");
            double celcius =Convert.ToDouble(Console.ReadLine());
            double fahrenheit = ConvertCelciusToFahrenheit((double)celcius);
            Console.WriteLine($"{celcius}°C = {fahrenheit}°F");
        }
    }
}
