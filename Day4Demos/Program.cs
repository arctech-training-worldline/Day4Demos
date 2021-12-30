using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            Demo3();
        }

        private static void Demo1()
        {
            int x = 20, y = 10, z = 5;

            int answer1 = x / y * z;
            int answer2 = x * y / z;

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
        }

        static void Demo2()
        {
            int x = 10, y = 20, z = 30;

            int answer1 = x + y++ * z;
            //y = y + 1;


            //z = z - 1;
            int answer2 = x + --z - y;

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
        }

        private static void Demo3()
        {
            int j = 1, k = 1;
            Console.WriteLine("===========================");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"i={i}, j={j++}, k={++k}");
            }

            Console.WriteLine("===========================");
            Console.WriteLine($"RAW Value => j={j}, k={k}");

            //Expected output
            //===========================
            //i=0, j=1, k=2
            //i=1, j=2, k=3
            //i=2, j=3, k=4
            //i=3, j=4, k=5
            //i=4, j=5, k=6
            //===========================
            //RAW Value => j=6, k=6

            Console.WriteLine("===========================");
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine($"i={i}, j={j++}, k={++k}");
            }
            Console.WriteLine("===========================");

            //Expected output
            //===========================
            //i=0, j=6, k=7
            //i=1, j=7, k=8
            //i=2, j=8, k=9
            //i=3, j=9, k=10
            //i=4, j=10, k=11
            //===========================
        }
    }
}
