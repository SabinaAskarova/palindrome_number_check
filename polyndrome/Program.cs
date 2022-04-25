using System;

namespace polyndrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int number = Int32.Parse( Console.ReadLine() );
            int mainnumber = number;
            int reversenum=0;
            while (number>0)
            {
                reversenum = reversenum*10+ number % 10;
                number = number / 10;
            }
            if (mainnumber==reversenum)
            {
                Console.WriteLine("Polindrome ededdir.");

            }
            else
            {
                Console.WriteLine("Polindrome eded deyil.");

            }
            Console.ReadKey();
        }
    }
}
