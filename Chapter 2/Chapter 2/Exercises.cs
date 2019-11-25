using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Declare two variables of type int. Assign to them values 5 and 10
        respectively. Exchange (swap) their values and print them.
        */
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            int swap;

            Console.WriteLine("Swapping numbers");
            swap = a;
            a = b;
            b = swap;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

        }
    }

    class Exercises_12
    {
        /*
        A company dealing with marketing wants to keep a data record of its
        employees. Each record should have the following characteristic – first
        name, last name, age, gender (‘m’ or ‘f’) and unique employee number
        (27560000 to 27569999). Declare appropriate variables needed to
        maintain the information for an employee by using the appropriate data
        types and attribute names.
        */
        static void Main()
        {
            /*
            //Should be using arrays or lists..... do this later.
            string fullName;
            char gender;
            int employeeNumber;



            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            fullName = firstName + " " + lastName;

            /* Doesn't work..... figure out why...
            Console.WriteLine("Are you Male or Female? m/f");
            while (gender != "f" || gender != "m")
            {
                Console.WriteLine("That's not a gender");
                gender = Console.ReadLine();
            }
            

            //isn't done!
            Console.WriteLine("What is your employee number");
            employeeNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine(fullName + gender + employeeNumber);
            */
        }
    }

    class Exercises_11
    {
        /*
        Write a program that prints on the console isosceles triangle which
        sides consist of the copyright character "©".
        */
        static void Main()
        {
            Console.WriteLine("         \u00a9");
            Console.WriteLine("      \u00a9     \u00a9");
            Console.WriteLine("    \u00a9         \u00a9");
            Console.WriteLine("  \u00a9             \u00a9");
            Console.WriteLine("\u00a9 \u00a9 \u00a9 \u00a9 \u00a9 \u00a9 \u00a9 \u00a9 \u00a9 \u00a9");
        }
    }

    class Exercises_10
    {
        /*
        Write a program to print a figure in the shape of a heart by the sign "o".
        */
        static void Main()
        {
            Console.WriteLine("  o   o");
            Console.WriteLine(" o  o  o");
            Console.WriteLine("o       o");
            Console.WriteLine("o       o");
            Console.WriteLine("  o   o");

        }
    }

    class Exercises_9
    {
        /*
        Declare two variables of type string and assign them a value “The
        "use" of quotations causes difficulties.” (without the outer quotes).
        In one of the variables use quoted string and in the other do not use it.
        */
        static void Main()
        {
            string str1 = @"The use of quotations causes difficulties.";
            string str2 = "The \"use\" of quotations causes difficulties.";

            Console.WriteLine(str1);
            Console.WriteLine(str2);

        }
    }

    class Exercise_8
    {
        /*
        Declare two variables of type string and give them values "Hello" and
        "World". Assign the value obtained by the concatenation of the two
        variables of type string (do not miss the space in the middle) to a
        variable of type object. Declare a third variable of type string and
        initialize it with the value of the variable of type object (you should use
        type casting).

        */
        static void Main()
        {
            string helloString = "Hello";
            string worldString = "World";

            object container;

            container = helloString + " " + worldString;

            string str = (string)container;

            Console.WriteLine(container);

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
