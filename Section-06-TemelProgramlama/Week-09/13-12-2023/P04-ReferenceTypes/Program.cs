namespace P04_ReferenceTypes
{   static class Product
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*int number1 = 50;

            Console.WriteLine(number1);*/

            Random random = new Random();
            int sayı1 = random.Next();
            int sayı2;

            sayı2 = 45;
            Console.WriteLine(sayı1);

            Product urun1 = new Product();
            Product urun2 = new Product();
            Product urun3;

            Console.ReadLine();
        }
    }
}
