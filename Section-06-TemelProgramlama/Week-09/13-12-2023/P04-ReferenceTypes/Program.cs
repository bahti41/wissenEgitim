namespace P04_ReferenceTypes
{
    class Product
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1=50;

            //Console.WriteLine(number1);

            Random random = new Random();
            int sayi1 = random.Next();
            int sayi2;

            sayi2 = 45;
            Console.WriteLine(sayi1);

            Product urun1 = new Product();
            Product urun2 = new Product();
            Product urun3;
  
            urun3 = new Product();
            Console.ReadLine();
        }
    }
}
