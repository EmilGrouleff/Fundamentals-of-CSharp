using System;

namespace Chapter_5_exercises
{
    class Program
    {
        static void Main()
        {
            Ex7();
        }

        //Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.
        static void Ex1()
        {
            Console.WriteLine("Write the first integer a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the second integer b");
            int b = int.Parse(Console.ReadLine());

            if (a>b)
            {
                int c = b;
                b = a;
                a = c;
                Console.WriteLine("The integers have been swiched");
            }
            Console.WriteLine("The first integer is: " + a);
            Console.WriteLine("The second integer is: " + b);
        }

        //Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.
        static void Ex2()
        {
            //Product is multiplication.

            Console.WriteLine("Write the first real number a");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Write the second real number b");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Write the thrid real number b");
            float c = float.Parse(Console.ReadLine());

            int negativeNumberCounter = 0;

            if (a==0||b==0||c==0)
            {
                Console.WriteLine("The number is 0");
            }
            else
            {
                if (a<0)
                {
                    negativeNumberCounter++;
                }
                if (b < 0)
                {
                    negativeNumberCounter++;
                }
                if (c < 0)
                {
                    negativeNumberCounter++;
                }

                if (negativeNumberCounter % 2 == 0)
                {
                    Console.WriteLine("The product of your numbers has the sign: +");
                }
                else
                {
                    Console.WriteLine("The product of your numbers has the sign: -");
                }
            }
            //I'm 100% sure this can be done in a better way...
        }

        //Write a program that finds the biggest of three integers, using nested if statements.
        static void Ex3()
        {
            Console.WriteLine("Write the first integer a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the second integer b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the thrid integer c");
            int c = int.Parse(Console.ReadLine());

            if (a>b)
            {
                if (a>c)
                {
                    Console.WriteLine("a is the biggest");
                }
                if (a<c)
                {
                    Console.WriteLine("c is the biggest");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b is the biggest");
                }
                if (b < c)
                {
                    Console.WriteLine("c is the biggest");
                }
            }

        }

        //Sort 3 real numbers in descending order. Use nested if statements.
        static void Ex4()
        {
            Console.WriteLine("Write the first real number a");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Write the second real number b");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Write the thrid real number c");
            float c = float.Parse(Console.ReadLine());

            if (a>b)
            {
                if (a>c)
                {
                    if (b>c)
                    {
                        Console.WriteLine("The numbers in descending order:");
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                    }
                    else if (b<c)
                    {
                        Console.WriteLine("The numbers in descending order:");
                        Console.WriteLine(a);
                        Console.WriteLine(c);
                        Console.WriteLine(b);
                    }
                }
                else if (a<c)
                {
                    Console.WriteLine("The numbers in descending order:");
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
            }
            else if (a < b)
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        Console.WriteLine("The numbers in descending order:");
                        Console.WriteLine(b);
                        Console.WriteLine(a);
                        Console.WriteLine(c);
                    }
                    else if (a < c)
                    {
                        Console.WriteLine("The numbers in descending order:");
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                        Console.WriteLine(a);
                    }
                }
                else if (b < c)
                {
                    Console.WriteLine("The numbers in descending order:");
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
            }
        }

        //Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.
        static void Ex5()
        {
            Console.WriteLine("Write a digit within the range 0-9");
            int digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 0:
                    Console.WriteLine("Zero"); break;
                case 1:
                    Console.WriteLine("One"); break;
                case 2:
                    Console.WriteLine("Two"); break;
                case 3:
                    Console.WriteLine("Three"); break;
                case 4:
                    Console.WriteLine("Four"); break;
                case 5:
                    Console.WriteLine("Five"); break;
                case 6:
                    Console.WriteLine("Six"); break;
                case 7:
                    Console.WriteLine("Seven"); break;
                case 8:
                    Console.WriteLine("Eight"); break;
                case 9:
                    Console.WriteLine("Nine"); break;
                default:
                    Console.WriteLine("That's not a digit within range 0-9"); break;
            }



        }

        //Write a program that gets the coefficients a, b and c of a quadratic equation: 
        //ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.
        static void Ex6()
        {
            Console.WriteLine("Write the first coefficient a");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Write the second coefficient b");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Write the thrid coefficient c");
            float c = float.Parse(Console.ReadLine());
            double d;
            double x1;
            double x2;

            d = b * b - 4 * a * c;

            if (d<0)
            {
                Console.WriteLine("There are no root(s)");
            }
            else if (d==0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("There is one root: {0}",x1);
            }
            else if (d>0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("There are two roots: {0} and {1}", x1, x2);
            }


        }

        //Write a program that finds the greatest of given 5 numbers.
        static void Ex7()
        {

        }

    }
}
