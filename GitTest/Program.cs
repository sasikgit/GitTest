using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("hello world {0}", a + b - i);
            }
            Console.WriteLine("hello world {0}", a + b);
            Console.ReadKey();
        }
    }
}
