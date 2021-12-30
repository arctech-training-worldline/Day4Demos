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
            //Demo1stHalf.Demo1();
            //Demo1stHalf.Demo2();
            //Demo1stHalf.Demo3();
            //Demo1stHalf.Demo5();
            //Demo1stHalf.Demo6();
            //Demo1stHalf.Demo7();
            //Demo1stHalf.Demo8();

            //DemoBitWise.Demo1();
            //DemoBitWise.Demo2();
            //DemoBitWise.Demo3();

            //Demo1();
            //Demo2();
            //Demo3();
            Demo4();
        }

        static void Demo4()
        {
            int i = 10;

            long l = i;

            int j = (int)l;
            
            Console.WriteLine("Enter a large number:");
            string answer = Console.ReadLine();
            long l2 = long.Parse(answer);

            int i2 = (int)l2;
            Console.WriteLine($"The large number in an int variable = {i2}");
        }

        static void Demo2()
        {
            Employee e = new Employee();
            int x = 10;

            Console.WriteLine($"{typeof(Employee)}, {typeof(int)}");

            // is and as operators to be covered tomorrow 31st Dec            
        }

        static void Demo3()
        {
            TestTypeOf(10);
            TestTypeOf("Avinash");
        }

        static void TestTypeOf(object x)
        {
            Console.WriteLine(x.GetType());

            //if(x.GetType() == typeof(int))    // Old style
            if(x is int)                        // New style from C# 7.0
            {
                int num = (int)x;
                Console.WriteLine($"You passed a number parameter. Its cube is {num*num*num}!");
            }
            //else if (x.GetType() == typeof(string))
            else if(x is string)                // New style from C# 7.0
            {
                string str = (string)x;
                Console.WriteLine($"You passed a string parameter. Let me encrypt it!!!");
            }            
        }

        static void Demo1()
        {
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            // Using if
            if (password == "zoom")
                Console.WriteLine("Please enter these gates");
            else
                Console.WriteLine("Return from where you came!");

            // using ?: operator
            string str = password == "zoom" ? "Please enter these gates" : "Return from where you came!";
            Console.WriteLine(str);
        }
    }
}
