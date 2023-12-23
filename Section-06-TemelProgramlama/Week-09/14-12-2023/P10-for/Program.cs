namespace P10_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}
            #endregion

            #region ForEach
            //string[] names = { "Ayşenur", "Zeynep", "Ece", "Ferda", "Murat" };
            //foreach (string x in names)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = {1,2,3,4,5};
            //int[] newNumbers = new int[5];
            //int index = 0;
            //foreach (var number in numbers)
            //{
            //    newNumbers[index] = number * 2;
            //    index++;
            //}

            //Klavyeden girilecek bir sayıya kadar olan sayıların içinden kaç tanesinin çift, kaç tanesinin üçün katı sayı olduğunu buldurup konsola yazdıralım.
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int ciftSayiAdedi = 0;
            int ucunKatiSayiAdedi = 0;
            for (int i = 0; i <= sayi; i++)
            {
                if(i % 2 == 0) ciftSayiAdedi++;
                if(i % 3 == 0) ucunKatiSayiAdedi++;
            }
            Console.Clear();
            Console.WriteLine("SONUÇ");
            Console.WriteLine("-----");
            Console.WriteLine($"0-{sayi} Arasındaki Çift Sayıların Adedi: {ciftSayiAdedi}");
            Console.WriteLine($"0-{sayi} Arasındaki Üçün Katı Sayıların Adedi: {ucunKatiSayiAdedi}");
            #endregion

            Console.ReadLine();
        }
    }
}
