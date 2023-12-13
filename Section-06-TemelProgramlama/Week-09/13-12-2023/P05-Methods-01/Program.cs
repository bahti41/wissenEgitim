namespace P05_Methods_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StringMethods
            /*            string name = "halil Umut Meler";*/

            /*int len = name.Length;
            Console.WriteLine(name + "degerinin uzunlugu: " + len + "karakterdir.");*/
            /*            Console.WriteLine(name.ToUpper());
                        Console.WriteLine(name.ToLower());*/

            /*            string m1 = "Bahcesehir";
                        string m2 = "üniversitesi";
                        int year = 1996;
                        Console.WriteLine(m1 + " " + m2);
                        Console.WriteLine(String.Concat(m1," ",m2));
                        Console.WriteLine(m1+ " " + m2 + " " + year + "yılında kurulmustur");
                        Console.WriteLine(String.Concat(m1," ",m2," ",year,"yılında kurulmuştur" ));
                        string result = $"{m1} {m2}";
                        string result2 = $"{m1} {m2} {year} yılında kurulmustur";
                        Console.WriteLine(result);
                        Console.WriteLine(result2);*/

            /*  string name = "ece";
              int age = 13;
              string scool = "Yedi tepe iöo";
              string result = $"Ad: {name}\nYas: {age}\nOkul: {scool}";
              Console.WriteLine(result);
              Console.WriteLine($"{name}\t{age}\t{scool}");*/


            /*string courseName = "FullStack Web Developer Egitimi";
            string findText = "WEB";
            bool result = courseName.ToLower().Contains(findText.ToLower());
            Console.WriteLine(result);*/



            /*            string name = "Zeyno";
                        Console.WriteLine(name.IndexOf('y'));
                        Console.WriteLine(name.StartsWith("Zey"));
                        Console.WriteLine(name.EndsWith("o"));*/


            /*  string school = "Yeditepe İlkogretim Mehtebi";
              string result = school.Replace("Mehtebi", "Okulu");
              Console.WriteLine(result);
  */
            /*string title = "C#'ta Metinsel işlemler";
            Console.WriteLine(title.Replace(" ","-").ToLower());
            string text = "Bugün hava cok güzeldi ama akşama dogru hava bozdu. öyle bozdu, öyle bozduki. daha da ";
            Console.WriteLine(text.Replace("a", "").Replace(".",""));*/

            string title = "Tesla, 2 milyon'dan fazla aracı otopilot yazılımını güncellemek için geri çağıracak!";
            Console.WriteLine(title);
            title = title.ToLower();
            title = title.Replace(" ","-");
            title = title.Replace(",","");
            title = title.Replace("'","");
            title = title.Replace("ı","i");
            title = title.Replace("ç","c");
            Console.WriteLine(title);
            
            #endregion

            Console.ReadLine();
        }
    }
}
