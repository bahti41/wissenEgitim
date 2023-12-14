using System;

namespace P06_NumberMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 40;
            //int number2 = 60;
            //Console.WriteLine($"En Kücük: {Math.Min(number1,number2)}");
            //Console.WriteLine($"En Kücük: {Math.Max(number1,number2)}");

            //int sayı = 4;
            //int us = 2;
            //int sonuc = Convert.ToInt32(Math.Pow(sayı, us));
            //double sonuc2 = Math.Pow(sayı, us);
            //Console.WriteLine(sonuc);

            //Console.Write("Bir sayı giriniz: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Bir sayı daha giriniz: ");
            //int number2 = (Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number1 + number2);

            //kullanıcan taban ve üs sayılarını alıp , tabanı üssüncü kuvvetini hasaplayarak konsala yazdıran kodu yazınız.

            //Console.Write("taban bilgilerini giriniz:");
            //int taban = Convert.ToInt32(Console.ReadLine());
            //Console.Write("üst bilgisini giriniz: ");
            //int us = Convert.ToInt32(Console.ReadLine());

            //int sonuc = Convert.ToInt32(Math.Pow(taban, us));
            //Console.WriteLine($"{taban} sayısının {us} kuvveti: {sonuc}");

            double sayı = 5.493486;
            Console.WriteLine(sayı);
            Console.WriteLine($"Ceiling: {Math.Ceiling(sayı)}");
            Console.WriteLine($"Floor: {Math.Floor(sayı)}");
            Console.WriteLine($"Round: {Math.Round(sayı)}");
            Console.WriteLine($"Round2: {Math.Round(sayı,2)}");
            Console.WriteLine($"Round2: {Math.Round(sayı,4)}");

            Console.ReadLine();
        }
    }
}
