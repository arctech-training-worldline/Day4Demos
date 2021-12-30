using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Demos
{
    internal class DemoBitWise
    {
        public static void Demo1()
        {
            char ch = 'A';
            int a = 65;
            int b = 0b1000001;

            Console.WriteLine("Display values in decimal numbering system (default)");
            Console.WriteLine($"ch = {(int)ch}, asciiValue={a}, binaryValue={b}");

            Console.WriteLine("Display values in binary numbering system");
            string chBinary = Convert.ToString(ch, 2).PadLeft(8, '0');
            string numberBinary = Convert.ToString(a, 2).PadLeft(8, '0');
            string binary = Convert.ToString(b, 2).PadRight(8, '0');
            Console.WriteLine($"ch = {chBinary}, asciiValue={numberBinary}, binaryValue={binary}");

            Console.WriteLine("Display values in hexadecimal numbering system");
            string chHexadecimal = Convert.ToString(ch, 16);
            string numberHexadecimal = Convert.ToString(a, 16);
            string hexadecimal = Convert.ToString(b, 16);
            Console.WriteLine($"ch = 0x{chHexadecimal}, asciiValue=0x{numberHexadecimal}, binaryValue=0x{hexadecimal}");
        }

        public static void Demo2()
        {
            // Ask user to enter a character on keyboard, and display the character,
            // and it's ascii value in decimal, binary and hex

            Console.Write("Enter a character: ");
            int ch = Console.Read();
            string chBinary = Convert.ToString(ch, 2).PadLeft(8, '0');
            string chHexadecimal = Convert.ToString(ch, 16);

            Console.WriteLine($"Character entered is = {(char)ch}, ascii value is decimal:{ch}, binary: {chBinary}, hex=0x{chHexadecimal}");
        }

        public static void Demo3()
        {
            byte i = 5;
            byte j = 10;
            int c = ~i;

            Console.WriteLine($"Complement Operator=> i={i}, c={c}");

            int ans1 = i | j;
            Console.WriteLine($"Bitwise OR=> i={i}, j={j}, ans1={ans1}");

            int ans2 = i & j;
            Console.WriteLine($"Bitwise AND=> i={i}, j={j}, ans2={ans2}");

            int ans3 = i ^ j;
            Console.WriteLine($"Bitwise XOR=> i={i}, j={j}, ans3={ans3}");

            int ans4 = i << 2;
            Console.WriteLine($"Bitwise LEFT SHIFT=> i={i}, ans3={ans4}");

            int ans5 = j >> 2;
            Console.WriteLine($"Bitwise RIGHT SHIFT=> i={i}, ans3={ans5}");

            j |= 200;
        }
    }
}
