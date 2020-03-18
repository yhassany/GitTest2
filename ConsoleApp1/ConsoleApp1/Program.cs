using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("update1");

            Console.WriteLine("branch1 update1");
            Console.WriteLine("branch1 update2");
            
            Console.WriteLine("conflict1");

            Console.WriteLine("whatever");
            
            Console.WriteLine("conflict2");

            Console.WriteLine("branch2 update1");

            Console.ReadLine();
        }
    }
}
