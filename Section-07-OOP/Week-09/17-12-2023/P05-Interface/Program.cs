namespace P05_Interface
{
    public interface IPerson
    {
        public string Deparment { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public void Info();
    }
    public interface IPersonal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public interface IEmployee
    {
        public string SubDepartment { get; set; }
    }
    public class Admin : IPerson, IPersonal
    {
        public string Deparment { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public void Info()
        {
            Console.WriteLine($"{City}");
        }
    }
    public class Guest : IPersonal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Employee : IPerson, IPersonal, IEmployee
    {
        public string Deparment { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string SubDepartment { get; set; }

        public void Info()
        {
            Console.WriteLine($"{City}-{SubDepartment}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            admin.City = "Kocaeli";
            admin.Info();




            Console.ReadLine();

            /*
             * Bir class sadece bir classtab miras alabilir
             * abstract class yada Interfaceden yeni bir nesne üretilemez.(new yapılamaz)
             * Bir abstract class icinde hem soyut hem somu memberler bulunabilir.
             * Dolayısyla bir abstract classa hem soyut hem somu memberlarımız varsa ihtiyac duyarız. eger sadece soyut yapılara ihtiyacımız varsa Interface kullanuırız yani Interfece icerigimiz tüm memberlar soyuttur.!
             * Eger bir class hem Interface hem de classtan miras alacaksa , önce class ismi yazılmak zorundadır. Sonrasında birden fazla interface yazılarak implemete edilebilir.
             */


        }
    }
}
