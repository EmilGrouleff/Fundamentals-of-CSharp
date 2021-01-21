using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex13();
        }

        /*
        Declare several variables by selecting for each one of them the most
        appropriate of the types sbyte, byte, short, ushort, int, uint, long
        and ulong in order to assign them the following values: 52,130; -115;
        4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
        1990; 123456789123456789.
        */
        static void Ex1()
        {
            /*
            sbyte a = -115;
            sbyte a2 = 97;
            sbyte a3 = 112;
            sbyte a4 = -44;

            byte b = 224;
            
            short c = -10000;
            short c2 = 20000;
            short c3 = 1990;
            
            ushort d = 52130;
            
            int e = 4825932;
            int e2 = -1000000;
            int e3 = 970700000;

            long g = 123456789123456789;
            */
        }

        /*
        Which of the following values can be assigned to variables of type float,
        double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
        3456.091124875956542151256683467?
        */
        static void Ex2()
        {
            //float: -5.01; 12.345; 5
            //Double: 3456.091124875956542151256683467 
            //Decimal: 34.567839023; 8923.1234857
        }

        /*
        Write a program, which compares correctly two real numbers with
        accuracy at least 0.000001.
        */
        static void Ex3()
        {
            float numberOne;
            float numberTwo;

            Console.WriteLine("Write a number");
            numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Write a second number");
            numberTwo = float.Parse(Console.ReadLine());

            if (numberOne==numberTwo)
            {
                Console.WriteLine("The numbers are the same");
            }
            else
            {
                Console.WriteLine("The numbers ain't the same");
            }
        }

        /*
        Initialize a variable of type int with a value of 256 in
        hexadecimal format (256 is 100 in a numeral system with base 16).
        */
        static void Ex4()
        {
            int numberInInt = 256;
            int numberInHex = 0x100;

            Console.WriteLine(numberInInt);
            Console.WriteLine(numberInHex);
        }

        /*
        Declare a variable of type char and assign it as a value the character,
        which has Unicode code, 72 (use the Windows calculator in order to find
        hexadecimal representation of 72). 
        */
        static void Ex5()
        {
            char MyChar = '\u0048';
            Console.WriteLine(MyChar);
        }

        //Declare a variable isMale of type bool and assign a value to it depending on your gender.
        static void Ex6()
        {
            bool isMale;

            Console.WriteLine("Are you a male? Yes(y), No(n)");
            string userIs = Console.ReadLine();

            if (userIs == "y")
            {
                isMale = true;
            }
            else
            {
                isMale = false;
            }
            Console.WriteLine("isMale: " + isMale);

        }

        /*
        Declare two variables of type string with values "Hello" and "World". Declare a variable of type object.
        Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable.
        Print the variable of type object.
        */
        static void Ex7()
        {
            string hello = "Hello";
            string world = "World";
            object myObject;

            myObject = hello +" "+ world;

            Console.WriteLine(myObject);
        }

        /*
        Declare two variables of type string and give them values "Hello" and "World".
        Assign the value obtained by the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object.
        Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).
        */
        static void Ex8()
        {
            string hello = "Hello";
            string world = "World";

            object myObject = hello + " " + world;

            string newString = (string)myObject;

            Console.WriteLine(newString);
        }

        /*
        Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes).
        In one of the variables use quoted string and in the other do not use it. 
        */
        static void Ex9()
        {
            //string stringOne = "The "use" of quotations causes difficulties.";
            string stringTwo = "The \"use\" of quotations causes difficulties.";
        }

        /*
        Write a program to print a figure in the shape of a heart by the sign "o".
        */
        static void Ex10()
        {
            Console.WriteLine("           o   o       o   o                \n" +
                              "        o        o   o       o              \n" +
                              "       o           o          o             \n" +
                              "     o                          o           \n" +
                              "     o                          o          \n" +
                              "      o                       o            \n" +
                              "        o                   o              \n" +
                              "          o               o                \n" +
                              "            o           o                  \n" +
                              "               o     o                     \n" +
                              "                  o                       \n" +
                              "                                         ");
        }

        /*
        Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
        */
        static void Ex11()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("      \u00A9      \n" +
                              "     \u00A9 \u00A9 \n" +
                              "    \u00A9   \u00A9 \n" +
                              "   \u00A9     \u00A9 \n" +
                              "  \u00A9       \u00A9 \n" +
                              " \u00A9         \u00A9 \n" +
                              "\u00A9           \u00A9 \n" +
                              "\u00A9 \u00A9 \u00A9 \u00A9 \u00A9 \u00A9 \u00A9 \u00A9 \n");
        }

        /*
        A company dealing with marketing wants to keep a data record of its employees. 
        Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). 
        Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.
        */
        static void Ex12()
        {
            string firstName;
            string lastName;
            int age;
            char gender;
            int employeeNumber;
        }

        /*
        Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.
        */
        static void Ex13()
        {
            int a = 5;
            int b = 10;
            int tempInt;

            Console.WriteLine("a is: " + a);
            Console.WriteLine("b is: " + b);

            tempInt = a;
            a = b;
            b = tempInt;

            Console.WriteLine("a is: " + a);
            Console.WriteLine("b is: " + b);
        }


    }
}
