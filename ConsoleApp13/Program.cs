using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");

            try
            {
                string input = Console.ReadLine();
                Console.WriteLine("Hello " + input);
                Console.ReadKey(true);
            }
            catch
            {

            }
        }
    }
}
