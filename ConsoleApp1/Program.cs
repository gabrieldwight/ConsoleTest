using System;
using Console.DB;

namespace ConsoleApp1
{
    class Program
    {
        private static Class1 d = new Class1();
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // calling interface methods from the class implementing the methods
            d.connect();

            System.Console.WriteLine(d.display());
            System.Threading.Thread.Sleep(10000);
        }
    }
}
