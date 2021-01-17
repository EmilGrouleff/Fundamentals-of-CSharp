using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex5();
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
    }
}
