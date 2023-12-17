namespace P06_Static
{
    public static class Deneme
    {
        public static int Sayı { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Hello, World!");
            Deneme.Sayı = 45;
            
        }
    }
}
