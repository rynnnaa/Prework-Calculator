using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum;
            double answer;

            Console.Write("Please enter your first number ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Great! What is your second number? ");
            double secondNum;
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Which operation would you like to use? ( + , - , x , / ) ");
            string operation;
            operation = Console.ReadLine();

            if (operation == "+")
            {
                answer = firstNum + secondNum;
                Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                answer = firstNum - secondNum;
                Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "x")
            {
                answer = firstNum * secondNum;
                Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                answer = firstNum / secondNum;
                Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry that is wrong");
                Console.ReadLine();
            }
        }
    }
}