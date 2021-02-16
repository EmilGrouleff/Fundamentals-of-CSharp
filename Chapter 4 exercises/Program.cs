using System; 

namespace Chapter_4_exercises
{
    class Program
    {
        static void Main()
        {
            Ex11();
        }

        //Write a program that reads from the console three numbers of type int and prints their sum.
        static void Ex1()
        {
            Console.WriteLine("write real number 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("write real number 1");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("write real number 1");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b + c);
        }

        //Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
        static void Ex2()
        {
            Console.WriteLine("Write the radius \"r\" of a circke you want the parimeter and area from");
            int r = int.Parse(Console.ReadLine());

            double area = Math.PI * (r * r);
            double perimeter = Math.PI * (r * 2);

            Console.WriteLine("the area of your cicle is: " + area);
            Console.WriteLine("the perimeter of your cicle is: " + perimeter);
        }

        /*
        A given company has name, address, phone number, fax number, web site and manager. 
        The manager has name, surname and phone number. 
        Write a program that reads information about the company and its manager and then prints it on the console.
        */
        static void Ex3()
        {
            string companyName = "QN";
            string address = "mars";
            int phoneNumber = 00998877;
            int faxNumber = 00000000;
            string webSite = "qn.com";

            string managerName = "Ducks";
            string managerSirName = "Fucks";
            int managerPhoneNumber = 00997788;

            Console.Write("You have reached {0} there is currently noone at the company number {1}. \nYou can reach the manager {2} {3} at {4}. " +
                "\nYou can also go to our website {5}, visit us IRL at {6}, or fax us.. (whoever does that nowadays idk) at {7}",
                companyName, phoneNumber, managerName, managerSirName, managerPhoneNumber, webSite, address, faxNumber);
        }

        /*
        Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. 
        The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. 
        The last two numbers have to be rounded to the second decimal place.
        */
        static void Ex4()
        {
            int hexInt = 0x884;
            float positive = 1.97f;
            float negative = -0.25f;
            Console.WriteLine("{0,-10}{1,-10}{2,-10}", "Hex", "Positive", "Negative");
            Console.WriteLine("{0,-10}{1,-10}{2,-10}", hexInt, positive, negative);
        }

        /*
        Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, 
        such that the remainder of their division by 5 is 0. 
        Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
        */
        static void Ex5()
        {
            Console.WriteLine("input a real number a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("input a real number b");
            int b = int.Parse(Console.ReadLine());
            int c;

            if (a<b)
            {
                c = b - a;

                for (int i = a; i <= (c+a); i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                c = a - b;

                for (int i = b; i < (c+b); i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        //Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.
        static void Ex6()
        {
            Console.WriteLine("input a number a");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("input a number b");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("The biggest number is: " + Math.Max(a, b));
            Console.WriteLine("The smallest number is: " + Math.Min(a, b));
        }

        //Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.
        static void Ex7()
        {
            int temp;
            int startNumber = 0;

            for (int i = 0; i < 5;)
            {
                Console.WriteLine("Input a real number");
                if (int.TryParse(Console.ReadLine(), out temp)) //Bool to see if it can read the line and parse it as an int
                {
                    int currNumber = startNumber + temp;
                    Console.WriteLine("The sum of the numbers you have written is: " + currNumber);
                    startNumber = currNumber;
                    i++;
                }
                else
                {
                    Console.WriteLine("That wasn't a real number, try again");
                }
            }
        }

        //Write a program that reads five numbers from the console and prints the greatest of them.
        static void Ex8()
        {
            int temp;
            int highestNumber;
            int currNumber = 0; //can never go into minus because of this, should do something different for the first number.

            for (int i = 0; i < 4;)
            {
                Console.WriteLine("Input a real number");
                if (int.TryParse(Console.ReadLine(), out temp)) //Bool to see if it can read the line and parse it as an int
                {
                    highestNumber = Math.Max(temp, currNumber);
                    Console.WriteLine("The current greatest number is: " + highestNumber);
                    currNumber = highestNumber;
                    i++;
                }
                else
                {
                    Console.WriteLine("That wasn't a real number, try again");
                }
            }
        }

        //Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
        static void Ex9()
        {
            int n;
            int temp;
            int startNumber = 0;

            Console.WriteLine("Write a real number for the amount of numbers you want the sum off");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                for (int i = 0; i < n;) //for loop taken from exercise 7, but with i < n.
                {
                    Console.WriteLine("Input a real number");
                    if (int.TryParse(Console.ReadLine(), out temp)) //Bool to see if it can read the line and parse it as an int
                    {
                        int currNumber = startNumber + temp;
                        Console.WriteLine("The sum of the numbers you have written is: " + currNumber);
                        startNumber = currNumber;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("That wasn't a real number, try again");
                    }
                }
            }
            else
            {
                Console.WriteLine("That wasn't a real number, try again");
            }
        }

        //Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.
        static void Ex10()
        {
            int n;

            Console.WriteLine("Write a real number you want all the number up to written on lines.");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("That wasn't a real number, try again");
            }
        }

        //Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
        static void Ex11()
        {

            ulong lastNumber = 0;
            ulong currNumber = 1;

            Console.WriteLine("The 0 number is: {0}", lastNumber);
            Console.WriteLine("The 1 number is: {0}", currNumber);

            for (int i = 2; i <= 100; i++)
            {
                ulong newNumber = lastNumber + currNumber;
                Console.WriteLine("The {0} number is: {1}",i , newNumber);
                lastNumber = currNumber;
                currNumber = newNumber;
            }

            //!!!!!NOTE!!!!!
            //numbers up to 93 is correct, 94-100 are incorrect, cuz ulong not big enough..
        }

    }
}
