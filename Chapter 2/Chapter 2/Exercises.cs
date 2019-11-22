using System;

namespace Chapter_2
{
    class Exercises
    {
        /*


        */
        static void Main()
        {

        }
    }
    class Exercises_13
    {
        /*


        */
        static void Main()
        {

        }
    }

    class Exercises_12
    {
        /*


        */
        static void Main()
        {

        }
    }

    class Exercises_11
    {
        /*


        */
        static void Main()
        {

        }
    }

    class Exercises_10
    {
        /*


        */
        static void Main()
        {

        }
    }

    class Exercises_9
    {
        /*


        */
        static void Main()
        {

        }
    }

    class Exercise_8
    {
        /*


        */
        static void Main()
        {

        }
    }

    class Exercise_7
    {
        /*
        Declare two variables of type string with values "Hello" and "World".
        Declare a variable of type object. Assign the value obtained of
        concatenation of the two string variables (add space if necessary) to this
        variable. Print the variable of type object.

        */
        static void Main()
        {
            string helloString = "Hello";
            string worldString = "World";

            object container;

            container = helloString + " " + worldString;

            Console.WriteLine(container);
        }
    }

    class Exercise_6
    {
        /*
        Declare a variable isMale of type bool and assign a value to it depending
        on your gender.
        */
        static void Main()
        {
            bool isMale;

            Console.WriteLine("Are you a male? y/n");
            if (Console.ReadLine() == "y")
            {
                isMale = true;
                Console.WriteLine("you are a male :D");
                Console.WriteLine(isMale);
            }
            else if (Console.ReadLine() == "n")
            {
                isMale = false;
                Console.WriteLine("you are a female :D");
                Console.WriteLine(isMale);
            }
            else
            {
                Console.WriteLine("for the love of christ.. you didn't answer 'y' or 'n'");
            }


        }
    }

    class Exercise_5
    {
        /*
        Declare a variable of type char and assign it as a value the character,
        which has Unicode code, 72 (use the Windows calculator in order to find
        hexadecimal representation of 72).
        */
        static void Main()
        {
            Console.WriteLine("exercise 5");
        }
    }

    class Exercise_4
    {

        /*
        Initialize a variable of type int with a value of 256 in
        hexadecimal format (256 is 100 in a numeral system with base 16).
        */

        static void Main()
        {
            //https://da.wikipedia.org/wiki/Hexadecimale_talsystem
            int number = 0x100;

            Console.WriteLine(number);
        }
    }
    
    class Exercise_1
    {
        /*
        Declare several variables by selecting for each one of them the most
        appropriate of the types:
        sbyte, byte, short, ushort, int, uint, long and ulong 
        in order to assign them the following values: 
        52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
        1990; 123456789123456789.
        */

        static void Main()
        {
            Console.WriteLine("Hello World!");

            ushort n1 = 52130;
            /*
            sbyte n2 = -115;
            int n3 = 4825932;
            byte n4 = 97;
            short n5 = -10000;
            short n6 = 20000;
            byte n7 = 224;
            int n8 = 970700000;
            byte n9 = 112;
            sbyte n10 = -44;
            int n11 = -1000000;
            short n12 = 1990;
            long n13 = 123456789123456789;
            */

            Console.WriteLine(n1);
            //Console.WriteLine("tal: ", n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13);


        }
    }

    class Exercise_2
    {
        /*
        Which of the following values can be assigned to variables of type:
        float, double, and decimal:
        5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?
        */

        static void Main()
        {

            // all of the types can be 5; -5.01; 12.345.
            // only double and decimal can write 8923.1234857; 34.567839023.
            // only decimal can write 3456.091124875956542151256683467 in full.


            float number = 3456.091124875956542151256683467f;
            double number2 = 3456.091124875956542151256683467;
            decimal number3 = 3456.091124875956542151256683467m;

            double n4 = 34.567839023;
            decimal n5 = 34.567839023m;

            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            Console.WriteLine(n4);
            Console.WriteLine(n5);

        }
    }

    class Exercise_3
    {
        /*
        Write a program, which compares correctly two real numbers with
        accuracy at least 0.000001.
        */

        static void Main()
        {
            //number = n
            double n1 = 1875.9844823;
            double n2 = 1875.9844823;
            double n3 = 1875.9945823;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);


            /*
            if (n1 - n2 < 0.000001 && n2 - n1 < 0.000001)
            {
                Console.WriteLine("n1 and n2 are the same");
            }
            else
            {
                Console.WriteLine("n1 and n2 are not the same");
            }

            if (n1 - n3 < 0.000001)
            {
                Console.WriteLine("n1 and n3 are the same");
            }
            else
            {
                Console.WriteLine("n1 and n3 are not the same");

            }

            if (n3 - n2 < 0.000001)
            {
                Console.WriteLine("n2 and n3 are the same");
            }
            else
            {
                Console.WriteLine("n2 and n3 are not the same");

            }
            */

            //burde have brugt!!
            bool equal = Math.Abs(n1 - n3) < 0.000001;

            Console.WriteLine(equal);
        }
    }

}
