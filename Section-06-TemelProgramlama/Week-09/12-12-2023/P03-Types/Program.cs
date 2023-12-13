namespace P03_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region #TAMSAYILAR


            //C#'ta veri tipleri çok önemlidir. Çeşitli veri tipleri bulunmaktadır. Özellikle sayılar ve sayı olmayanlar şeklinde incelemek iyi olacaktır.
            //TAM SAYILAR
            //byte sayi1 = 255;
            //sbyte sayi2 = 15;
            //Console.WriteLine(sayi1 + " sayısının alabileceği minimum değer: " + byte.MinValue);
            //Console.WriteLine(sayi1 + " sayısının alabileceği maksimum değer: " + byte.MaxValue);
            //Console.WriteLine(sayi1 + " sayısının bellekte kapladığı alan: " + sizeof(byte) + " byte");
            //Console.WriteLine(sayi2 + "-" + sizeof(double) + " byte");

            //byte sayı1 = 10;
            //ushort say2 = 10;
            //uint sayı3 = 40;
            //ulong say4 = 50;

            //sbyte sbyte5 = -50;
            //short sbyte6 = -6;
            //int sbyte7 = -7;
            //long sbyte8 = -8;



            //Console.WriteLine(ushort.MinValue);
            //Console.WriteLine(ushort.MaxValue);
            //console.WriteLink(sizeof(int)+ "byte");
            //#endregion
            #endregion
            #region ONDALIKLI SAYILAR

            #endregion
            #region METİN VE KARAKTERLER
            /*char answer = 'T';
            string name = "ali veli";

            Console.WriteLine(answer + "tipi" + answer.GetType() + "-min:" + char.MinValue);
            Console.WriteLine(name[4]);*/

            #endregion
            #region MANTIKSAL
            bool isActive = true;
            Console.WriteLine()
            #endregion
            #region TARİH SAAT
            DateTime birthDay = new DateTime(1997, 2, 2);
            Console.WriteLine(birthDay);
             #endregion

            Console.ReadLine();

        }
    }
}
