using System; 

namespace Chapter_4_exercises
{
    class Program
    {
        static void Main()
        {
            Ex5();
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

        }

    }
}
