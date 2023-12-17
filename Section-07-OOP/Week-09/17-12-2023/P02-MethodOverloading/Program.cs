namespace P02_MethodOverloading
{
    internal class Program
    {
        /// <summary>
        /// Bu Method aldıgı 2 tam sayıyı toplayıp sonucu tam sayı olaraka kullanır
        /// </summary>
        /// <param name="sayı1">Toplanacak ilk tam sayı deger</param>
        /// <param name="sayı2">Toplanacak ikinci tam sayı degr</param>
        /// <returns>Geriye tam sayı bir deger döndürür</returns>
        static int Topla(int sayı1,int sayı2)
        {
            return sayı1 + sayı2;
        }
        static int Topla(int sayı1, int sayı2, int sayı3)
        {
            return sayı1 * sayı2 + sayı3;
        }
        static double Topla(double sayı1, double sayı2)
        {
            return sayı1 + sayı2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(5,6));
            Console.WriteLine(Topla(4,7,8));
            
            Console.ReadLine();
        }
    }
}
