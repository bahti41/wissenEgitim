namespace P08_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            /*
             uygulamalrımız calıştıkları esnada bir takım hatalar dolayı durabilir
            bu tüy hatalara ru time errors deniz
            run time errorsı kontrol altına alabbilmek icin try-Catch
             */

            /*
             *  try
             *  {
             *  calışması bekledigimz kodlaro byraya yazacagız 
             *  } 
            */
            /*
             * catch
             * {
             * eger try dcope unu
             * }
             */
            /*
             * finally
             * {
             * try yada
             * }
             */





            #endregion
            #region Sample01
            Console.Write("lütfen karesi alınacak sayı giriniz");
            try
            {
                int sayı = Convert.ToInt32(Console.ReadLine());
                int sonuc = Convert.ToInt32(Math.Pow(sayı, 2));
                Console.WriteLine(sonuc);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            #endregion
            #region Sample02
            try
            {
                Console.Write("bölünen: ");
                int bolunen = int.Parse(Console.ReadLine());
                Console.Write("Bölen: ");
                int bolen = int.Parse(Console.ReadLine());
                int sonuc = bolunen / bolen;
                Console.WriteLine($"{bolunen} / {bolen} = {sonuc}");
               
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("0'a bölme yapılamz!");                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("lütfen gecerli bair sayı giriniz");
            }
            catch   (Exception ex)
            {
                Console.WriteLine("hata var");
            }
            #endregion
            Console.ReadLine();
        }
    }
}
