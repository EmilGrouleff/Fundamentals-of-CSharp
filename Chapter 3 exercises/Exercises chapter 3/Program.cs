using System;

namespace Exercises_chapter_3
{
    class Program
    {
        static void Main()
        {
            Ex10();
        }

        //Write an expression that checks whether an integer is odd or even.
        static void Ex1()
        {
            int a = 69;
            int b = 420;

            if (a%2==0)
            {
                Console.WriteLine(a+" is even");
            }
            else
            {
                Console.WriteLine(a + " is odd");
            }
            if (b % 2 == 0)
            {
                Console.WriteLine(b + " is even");
            }
            else
            {
                Console.WriteLine(b + " is odd");
            }

        }

        //Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
        static void Ex2()
        {
            int a = 69;
            int b = 420;

            if (a % 5 == 0 && a%7==0)
            {
                Console.WriteLine(a + " is divisible by both 5 and 7, without a remainder");
            }
            else
            {
                Console.WriteLine(a + " is not divisible by both 5 and 7, without a remainder");
            }
            if (b % 5 == 0 && b % 7 == 0)
            {
                Console.WriteLine(b + " is divisible by both 5 and 7, without a remainder");
            }
            else
            {
                Console.WriteLine(b + " is not divisible by both 5 and 7, without a remainder");
            }
        }

        //Write an expression that looks for a given integer if its third digit (right to left) is 7.
        static void Ex3()
        {
            int a = 581701;
            int dividedByHoundred = a / 100;

            if (dividedByHoundred%10==7)
            {
                Console.WriteLine("fam the third digit is 7");
            }
            else
            {
                Console.WriteLine("fam the third digit isn't 7");
            }
        }

        //Write an expression that checks whether the third bit in a given integer is 1 or 0.
        static void Ex4()
        {
            int number = 25;
            bool bit3 = (number & 8) != 0;
            if (bit3)
            {
                Console.WriteLine("The third bit is 1");
            }
            else
            {
                Console.WriteLine("The third bit is 0");
            }
        }

        //Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
        static void Ex5()
        {
            float a = 5.6f;
            float b = 7.3f;
            float h = 10.8f;

            Console.WriteLine(((a + b) / 2) * h);
        }

        //Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
        static void Ex6()
        {
            Console.WriteLine("Write a side");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Write a height");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("the perimeter of the rectangle is: " + ((a*2)+(b*2)));
            Console.WriteLine("the area of the rectangle is: " + (a*b));
        }

        //The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
        static void Ex7()
        {
            Console.WriteLine("What does the man weight? in Kg");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("The mans weight on the moon is: " + (weight * 0.17));

        }

        //Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of the circle and 5 is the radius.
        static void Ex8()
        {
            Console.WriteLine("Write point x");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Write point y");
            float y = float.Parse(Console.ReadLine());

            if ((x*x)+(y*y)<=5*5)
            {
                Console.WriteLine("The point " + x + ", " + y + " is within the circle");
            }
            else
            {
                Console.WriteLine("it isn't within the circle");
            }
        }

        /*
        Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
        Clarification: for the rectangle the lower left and the upper right corners are given.
        */
        static void Ex9()
        {
            Console.WriteLine("Write point x");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Write point y");
            float y = float.Parse(Console.ReadLine());

            bool isInCircle = false;
            bool isInRectangle = false;

            isInCircle = (x * x) + (y * y) <= 5 * 5;
            isInRectangle = (x > -1 && x < 5) && (y > 1 && y < 5);


            if (isInCircle && !isInRectangle)
            {
                Console.WriteLine("The point " + x + ", " + y + " is within the circle, and outside the rectangle");
            }
            else
            {
                Console.WriteLine("it isn't within the circle, and outside the rectangle");
            }
        }

        /*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
        - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        - Prints on the console the number in reversed order: dcba (in our example 1102).
        - Puts the last digit in the first position: dabc (in our example 1201).
        - Exchanges the second and the third digits: acbd (in our example 2101).*/
        static void Ex10()
        {
            Console.WriteLine("Write a four digit number");
            int number = int.Parse(Console.ReadLine());

            int d = number % 10;
            int c = (number / 10) % 10;
            int b = (number / 100) % 10;
            int a = (number / 1000) % 10;

            Console.WriteLine("the sum of the numbers are: " + (a+b+c+d));
            Console.WriteLine("number in reversed order: {3}{2}{1}{0}", a,b,c,d);
            Console.WriteLine("last digit in the first position: {3}{0}{1}{2}", a,b,c,d);
            Console.WriteLine("Exchanges the second and the third digits: {0}{2}{1}{3}", a,b,c,d);
        }

        /* We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). 
        Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.*/
        static void Ex11()
        {
            Console.WriteLine("Write number n");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Write position p");
            float p = float.Parse(Console.ReadLine());




        }

    }
}
