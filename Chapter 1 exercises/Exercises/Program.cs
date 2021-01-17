using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ex11();
        }

        //Write a console application that prints your first and last name on the console.
        static void ex6()
        {
            Console.WriteLine("Emil Grouleff");
        }

        //Write a program that prints the following numbers on the console 1, 101, 1001, each on a new line.
        static void ex7()
        {
            Console.WriteLine("1");
            Console.WriteLine("101");
            Console.WriteLine("1001");
        }

        //Write a program that prints on the console the current date and time.
        static void ex8()
        {
            Console.WriteLine(DateTime.Now);
        }

        //Write a program that prints the square root of 12345.
        static void ex9()
        {
            Console.WriteLine(Math.Sqrt(12345));
        }

        //Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.
        static void ex10()
        {
            bool minus = true;
            for (int i = 2; i < 103; i++)
            {
                if (minus)
                {
                    Console.WriteLine(i);
                    minus = false;
                }
                else
                {
                    Console.WriteLine("-"+i);
                    minus = true;
                }
            }
        }

        //Write a program that reads your age from the console and prints your age after 10 years.
        static void ex11()
        {
            int age;
            Console.WriteLine("Please enter your age!");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your age in 10 years is: " + (age + 10));
        }

        //


    }
}
