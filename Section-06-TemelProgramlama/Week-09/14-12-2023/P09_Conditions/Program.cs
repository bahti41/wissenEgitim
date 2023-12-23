namespace P09_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Intro
            //Console.Write("Yaş: ");
            //int yas = int.Parse(Console.ReadLine());
            //if (yas>=18)
            //{
            //    Console.WriteLine("Giriş yapabilirsiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Giremezsin!");
            //}
            #endregion

            #region Tek Satırlık If
            //if(true) Console.WriteLine("Doğru");
            //Console.WriteLine("Bitti...");
            #endregion

            #region If-ElseIf
            //int age = 5;
            //if (age<18)
            //{
            //    Console.WriteLine("Çocuk");
            //}else if (age<40)
            //{
            //    Console.WriteLine("Genç");
            //}
            //else
            //{
            //    Console.WriteLine("Yaşlı");
            //}
            #endregion

            #region TernaryIf
            //int age = 30;
            ////Console.WriteLine(age < 18 ? "çocuk" : "genç");
            //string message = age < 18 ? "Çocuk" : "Genç";
            //Console.WriteLine(message);
            #endregion

            #region SwitchCase
            //int x = 11;
            //switch (x)
            //{
            //    case 5:
            //        Console.WriteLine("Bugün ayın beşi");
            //        break;
            //    case 10:
            //        Console.WriteLine("Bugün ayın onu");
            //        break;
            //    case 15:
            //        Console.WriteLine("Bugün ayın onbeşi");
            //        break;
            //    case 20:
            //        Console.WriteLine("Bugün ayın yirmisi");
            //        break;
            //    case 25:
            //        Console.WriteLine("Bugün ayın yirmibeşi");
            //        break;
            //    case 30:
            //        Console.WriteLine("Bugün ayın otuzu");
            //        break;
            //    default:
            //        Console.WriteLine("Söylenecek bişey yok...");
            //        break;
            //}
            #endregion
            #region SwitchCase2
            int x = 21;
            switch (x)
            {
                case 5:
                case 10:
                case 15:
                case 20:
                case 25:
                case 30:
                    Console.WriteLine("Beşin katı...");
                    break;
                default:
                    Console.WriteLine("Söylenecek bişey yok...");
                    break;
            }
            #endregion
            Console.ReadLine();
        }
    }
}
