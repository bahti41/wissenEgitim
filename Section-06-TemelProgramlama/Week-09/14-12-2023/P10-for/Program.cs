namespace P10_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region intro
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("hello word")   
            //}

            //Console.WriteLine();
            #endregion

            #region Foreach
            //string[] names = { "ayşenur", "numan", "ece", "ferda", "murat" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            int[] number = { 1, 2, 3 ,4,5};
            int[] newNumber = new int[5];
            int index =0;
            foreach (var item in number)
            {
                newNumber[index] = item * 2;
                index++;
            }
            #endregion

            Console.ReadLine();
        }
    }
}
