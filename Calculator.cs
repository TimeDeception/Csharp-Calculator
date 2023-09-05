using System;

namespace CalculatorApp
{
    class Calculator
    {
        //A function that can perform mathematical operations of two numbers given input by the user
        public static double doMath(double num1, double num2, string Operation)
        {
            double result = double.NaN;
            switch(Operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed");
                        
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operationn");
                    break;
            }
            return result;
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            bool Quit = false;
            
            //This while loop keeps the program running until user quits the program
            while (!Quit)
            {
                double result =0;

                Console.WriteLine("Welcome to the Calculator Program!");

                //gets the first number to operate on and turns the user string into a number
                Console.Write("Enter first number, then press Enter: ");
                double Input1 = double.Parse(Console.ReadLine());

                //same as above but second number
                Console.Write("Type another number, then press Enter: ");
                double Input2 = double.Parse(Console.ReadLine());

                //User chooses an operation to perform on chosen numbers
                Console.Write("Select an Operation '*,/,+,-' then press Enter: ");
                String op = Console.ReadLine();

                //Takes the first and second numbers and runs them through the doMath function
                result = Calculator.doMath(Input1, Input2, op);
                
                //Shows the result of the calculation
                Console.WriteLine("the answer is: " + result);
                
                Console.WriteLine("To quit the program press 'q' then press Enter, To continue press any key then Enter: ");
                if (Console.ReadLine()=="q" )
                {
                    Quit = true;
                }

            }
            

        }
    }

    
}