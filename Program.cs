using System.ComponentModel;
using System;

namespace MyCallculator
{
    class Programm
    {
         static void Main(string[] args)
        {

            double num1 = 0;
            double num2 = 0;
            double result = 0;


            Console.Write("calcultor programm");

            Console.Write("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an option");
            Console.WriteLine("+ : Add");
            Console.WriteLine("- : Substract");
            Console.WriteLine("/ : Division");
            Console.WriteLine("* : Multiply");


            
             switch (Console.ReadLine())
             {
                case "+":
                 result = num1 + num2;
                 Console.WriteLine( "your result:  " + result);
                    break;
                case "-":
                 result = num1 - num2;
                 Console.WriteLine( "your result:" + result);
                    break;
                case "/":
                 result = num1 / num2;
                 Console.WriteLine( "your result: " + result);
                    break; 
                case "*":
                 result = num1 * num2;
                 Console.WriteLine( "your result: " + result);
                    break;       
                default:
                 Console.WriteLine("Option Not Valid");
                    break;
             }
             





        }

    }
}









     



