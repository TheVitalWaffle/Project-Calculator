using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean Restart = true;
            while (Restart == true)
            {
                string Start = "Please Enter Your Operation (* For Multiplicaion, / For Division, + For Addition, - For Subtraction)";
                string InRestart;
                int FirstNumber, SecondNumber, Sum;
                Console.WriteLine(Start);
                string Operation = Console.ReadLine();
                if (Operation == "*")
                {
                    Console.WriteLine("Multiplication Is Your Operation, Now Please Enter Your First Number");
                    FirstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Great {0} Is Your First Number, Now Please Enter Your Second Number :)", FirstNumber);
                    SecondNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Great Little CPU Man Is Going To Run The Equation {0} {1} {2}, Ok?", FirstNumber, Operation, SecondNumber);
                    Sum = FirstNumber * SecondNumber;
                    Console.ReadLine();
                    Console.WriteLine("{0} {1} {2} = {3}", FirstNumber, Operation, SecondNumber, Sum);
                    Console.WriteLine("Would You Like To Restart? Y/N (Case Sensitive");
                    InRestart = Console.ReadLine();
                    if (InRestart == "N")
                        Restart = false;

                }

                if (Operation == "/")
                {
                    Console.WriteLine("Division Is Your Operation, Now Please Enter Your First Number");
                    FirstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Great {0} Is Your First Number, Now Please Enter Your Second Number :)", FirstNumber);
                    SecondNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Great Little CPU Man Is Going To Run The Equation {0} {1} {2}, Ok?", FirstNumber, Operation, SecondNumber);
                    Sum = FirstNumber / SecondNumber;
                    Console.ReadLine();
                    Console.WriteLine("{0} {1} {2} = {3}", FirstNumber, Operation, SecondNumber, Sum);
                    Console.WriteLine("Would You Like To Restart? Y/N (Case Sensitive");
                    InRestart = Console.ReadLine();
                    if (InRestart == "N")
                        Restart = false;
                }

                if (Operation == "+")
                {
                    Console.WriteLine("Addition Is Your Operation, Now Please Enter Your First Number");
                    FirstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Great {0} Is Your First Number, Now Please Enter Your Second Number :)", FirstNumber);
                    SecondNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Great Little CPU Man Is Going To Run The Equation {0} {1} {2}, Ok?", FirstNumber, Operation, SecondNumber);
                    Sum = FirstNumber + SecondNumber;
                    Console.ReadLine();
                    Console.WriteLine("{0} {1} {2} = {3}", FirstNumber, Operation, SecondNumber, Sum);
                    Console.WriteLine("Would You Like To Restart? Y/N (Case Sensitive");
                    InRestart = Console.ReadLine();
                    if (InRestart == "N")
                        Restart = false;
                }

                if (Operation == "-")
                {
                    Console.WriteLine("Subtraction Is Your Operation, Now Please Enter Your First Number");
                    FirstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Great {0} Is Your First Number, Now Please Enter Your Second Number :)", FirstNumber);
                    SecondNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Great Little CPU Man Is Going To Run The Equation {0} {1} {2}, Ok?", FirstNumber, Operation, SecondNumber);
                    Sum = FirstNumber - SecondNumber;
                    Console.ReadLine();
                    Console.WriteLine("{0} {1} {2} = {3}", FirstNumber, Operation, SecondNumber, Sum);
                    Console.WriteLine("Would You Like To Restart? Y/N (Case Sensitive");
                    InRestart = Console.ReadLine();
                    if (InRestart == "N")
                        Restart = false;
                }
            }
        }
    }
}
