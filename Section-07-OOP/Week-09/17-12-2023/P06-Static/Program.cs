using P06_Static.Helper;
namespace P06_Static
{
    
    internal class Program
    {
        static void Metot()
        {

        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string name = "Alex?de?Souza";
            //HelperMethods helper = new HelperMethods();
            //Console.WriteLine(helper.EditText(name));
            Console.WriteLine(HelperMethods.EditText(name));
            Console.ReadLine();
        }
    }
}
