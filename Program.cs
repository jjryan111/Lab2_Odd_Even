using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static string ynInput(string uid)
        {
            string input = "";
            bool invalid = true;
            while (invalid)
            {
                Console.WriteLine("");
                Console.WriteLine(uid + ", do you want to enter another number? (y/n): ");
                input = Console.ReadLine();
                if ((input == "y") || (input == "n"))
                {
                    invalid = false;
                }
                else
                {
                    Console.WriteLine(uid + ", please answer y or n.");
                }
            }
            return input;
        }

        static void Main(string[] args)
        {
            int input = 0;
            bool isOdd = false;
            string yesNo = "y";
            string userName = "";
            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            while (yesNo == "y")
            {
                Console.WriteLine(userName + ", enter an integer between 1 and 100");
                input = int.Parse(Console.ReadLine());
                if (input < 0 || input > 100)
                {
                    Console.WriteLine("That number is not between 0 and 100 " + userName + "!");
                }
                else
                {
                    if (input % 2 == 1)
                    {
                        isOdd = true;
                        Console.WriteLine(userName + ", " + input + " is Odd.");
                    }
                    if (!isOdd && input >= 2 && input < 25)
                    {
                        Console.WriteLine(userName + " that number is even and less than 25.");
                    }
                    else if (!isOdd && input >= 26 && input <= 60)
                    {
                        Console.WriteLine(userName + ", that number is even.");
                    }
                    else if (!isOdd && input >= 60)
                    {
                        Console.WriteLine(userName + ", " + input + " is even.");
                    }
                    else if (isOdd && input > 60)
                    {
                        Console.WriteLine(userName + ", " + input + " is odd.");

                    }
                }
                yesNo = ynInput(userName);
            }
        }
    }
}
