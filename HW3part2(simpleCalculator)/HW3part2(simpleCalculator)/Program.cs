using System;

namespace HW3part2_simpleCalculator_
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            double firstNumber;
            double secondNumber;
            bool no = false;


            do
            {
                Console.WriteLine("Введите первое число");
                no = double.TryParse(Console.ReadLine(), out firstNumber);
                if (!no)

                { 
                Console.WriteLine("Неверные Данные");
                }                        
            } while (!no);
            do
            {
                Console.WriteLine("Введите второе число");
                no = double.TryParse(Console.ReadLine(), out secondNumber);
                if (!no)
                {
                    Console.WriteLine("Неверные Данные");
                }
            } while (!no);



            Console.WriteLine("введите действие которое хотите произвести с этими часлами (+, -, / или *");
            string operation = Console.ReadLine();

            double result;
            switch (operation)
            {
                case "+":
                    result = Sum(firstNumber, secondNumber);
                    Console.WriteLine($"результат сложения этих чисел равен {result}");
                    break;
                case "-":
                    result = Minus(firstNumber, secondNumber);
                    Console.WriteLine($"результат вычитания этих чисел равен {result}");
                    break;
                case "/":
                    result = Division(firstNumber, secondNumber);
                    Console.WriteLine($"результат деления этих чисел равен {result}");
                    break;
                case "*":
                    result = Multipl(firstNumber, secondNumber);
                    Console.WriteLine("результат умножения этих чисел равен " + result);
                    break;
                default:
                    Console.WriteLine("вы ввели неверное действие");
                    break;


               static double Sum(double number1, double number2)
                    {
                        return number1 + number2;
                    }
               static double Minus(double number1, double number2)
                    {
                        return number1 - number2;
                    }
               static double Multipl(double number1, double number2)
                    {
                        return number1 * number2;
                    }
               static double Division(double number1, double number2)
                    {
                        return number1 / number2;
                    }

        }
    }
}
}