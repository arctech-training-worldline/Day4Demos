using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Demos
{
    internal class Demo1stHalf
    {
        public static void Demo1()
        {
            int x = 20, y = 10, z = 5;

            int answer1 = x / y * z;
            int answer2 = x * y / z;

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
        }

        public static void Demo2()
        {
            int x = 10, y = 20, z = 30;

            int answer1 = x + y++ * z;
            //y = y + 1;


            //z = z - 1;
            int answer2 = x + --z - y;

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
        }

        public static void Demo3()
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

        public static void Demo4()
        {
            int i = 1;
            int j = 1;

            int ans1 = i++;         // j = j + 1
            int ans2 = j += 100;    // j = j + 100
        }

        public static void Demo5()
        {
            string userName, password;

            Console.Write("Username:");
            userName = Console.ReadLine();
            Console.Write("Password:");
            password = Console.ReadLine();

            //&& || !
            if (userName == "mickey" && password == "mouse")
            {
                Console.WriteLine("Welcome");
                Console.Write("How old are you?");
                string answer = Console.ReadLine();

                bool isAdult = Convert.ToInt32(answer) >= 18;

                if (!isAdult)
                    Console.WriteLine("Get OUT!!");
                else
                    Console.WriteLine("Welcome again!!");

                if (isAdult)
                    Console.WriteLine("Welcome again!!");
                else
                    Console.WriteLine("Get OUT!!");
            }
            else
                Console.WriteLine("Wrong Password");

            Console.WriteLine(userName + password);
            Console.WriteLine($"{userName}{password}");
            StringBuilder sb = new StringBuilder();
            sb.Append(userName).Append(password);
            Console.WriteLine(sb.ToString());
            string text = string.Format("{0}{1}", userName, password);
            Console.WriteLine(text);
            Console.WriteLine("{0}{1}", userName, password);
        }

        /// <summary>
        /// Accept the work experience in years and the education qualification in years
        /// If the candidate has fulfilled any of the following criteria, then allow them entry into Executive MBA program
        /// 1. 10 years of work experience 
        /// 2. 16 years of education
        /// 3. if 15 years of education then 15 years of work experience needed
        /// 4. If they dont qualify for either then if they have 80%+ in 10th, 75%+ in 12 and 70%+ in graduation
        /// </summary>
        public static void Demo6()
        {
            string name;
            int workExperienceYears, educationYears;
            Console.Write("Enter you name: ");
            name = Console.ReadLine();

            Console.Write("Enter you work experience in years: ");
            string answer1 = Console.ReadLine();
            workExperienceYears = int.Parse(answer1);

            Console.Write("How many years of formal education have you completed: ");
            string answer2 = Console.ReadLine();
            educationYears = int.Parse(answer2);

            // Simple if else logic
            if (workExperienceYears >= 10 || educationYears >= 16)
                Console.WriteLine("Welcome to our Executive MBA program");
            else if (educationYears == 15 && workExperienceYears >= 15)
                Console.WriteLine("Welcome to our Executive MBA program");
            else
            {
                Console.Write("Enter your percentage for 10th: ");
                string answer10 = Console.ReadLine();
                Console.Write("Enter your percentage for 12th: ");
                string answer12 = Console.ReadLine();
                Console.Write("Enter your percentage for Graduation: ");
                string answerGrad = Console.ReadLine();

                int percent10 = int.Parse(answer10);
                int percent12 = int.Parse(answer12);
                int percentGrad = int.Parse(answerGrad);

                if (percent10 >= 80 && percent12 >= 75 && percentGrad >= 70)
                {
                    Console.WriteLine("Welcome to our Executive MBA program");
                }
            }

            /*
            // shortned code but complex if else logic
            Console.Write("Enter your percentage for 10th: ");
            string answer10 = Console.ReadLine();
            Console.Write("Enter your percentage for 12th: ");
            string answer12 = Console.ReadLine();
            Console.Write("Enter your percentage for Graduation: ");
            string answerGrad = Console.ReadLine();

            int percent10 = int.Parse(answer10);
            int percent12 = int.Parse(answer12);
            int percentGrad = int.Parse(answerGrad);

            if (workExperienceYears >= 10 || educationYears >= 16 ||
                (educationYears == 15 && workExperienceYears >= 15) ||
                (percent10 >= 80 && percent12 >= 75 && percentGrad >= 70))
            {
                Console.WriteLine("Welcome to our Executive MBA program");
            }
            else
                Console.WriteLine($"Sorry {name} you are not accepted into our program");
            */
        }

        public static void Demo7()
        {
            double answer = 100 / 5 % 13 * 20;
            // 20 % 13 * 20
            // 7 * 20 = 140
            Console.WriteLine(answer);

            double answer2 = 10 + (20 % 5) - 3 + (2 * 30 / 2) - 9;
            Console.WriteLine(answer2);
        }

        public static void Demo8()
        {
            int a = 15;
            int b = 4;
            float c = a / b;
            float d = (float)3;
            float e = (float)a / b;
            //15.0 / 4 = 3.75

            Console.WriteLine(c); // 3
            Console.WriteLine(d); // 3
            Console.WriteLine(e); // 3.75
        }
    }
}
