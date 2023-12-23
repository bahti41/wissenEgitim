namespace P06_NumberMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 40;
            //int number2 = 60;
            //Console.WriteLine($"En Küçük: {Math.Min(number1,number2)}");
            //Console.WriteLine($"En Büyük: {Math.Max(number1,number2)}");

            //int sayi = 4;
            //int us = 2;

            //int sonuc = Convert.ToInt32(Math.Pow(sayi, us));
            //double sonuc2 = Math.Pow(sayi, us);
            //Console.WriteLine(sonuc);
            //Console.Write("Bir sayı giriniz: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Bir sayı daha giriniz: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number1+number2);

            //Kullanıcıdan taban ve üs sayılarını alıp, tabanın üssüncü kuvvetini hesaplayarak konsola yazdıran kodu yazınız.

            //Console.Write("Taban Bilgisini Giriniz: ");
            //int taban = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Üs Bilgisini Giriniz: ");
            //int us = Convert.ToInt32(Console.ReadLine());

            //int sonuc = Convert.ToInt32(Math.Pow(taban, us));
            //Console.WriteLine($"{taban} sayısının {us}. kuvveti: {sonuc}");

            double sayi = 5.493486;
            Console.WriteLine(sayi);
            Console.WriteLine($"Ceiling: {Math.Ceiling(sayi)}");
            Console.WriteLine($"Floor: {Math.Floor(sayi)}");
            Console.WriteLine($"Round: {Math.Round(sayi)}");
            Console.WriteLine($"Round2: {Math.Round(sayi,2)}");
            Console.WriteLine($"Round2: {Math.Round(sayi,4)}");


            Console.ReadLine();
        }
    }
}
