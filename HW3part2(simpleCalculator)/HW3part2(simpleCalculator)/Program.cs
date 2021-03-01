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
            double result;
            string operand;
            string answer;            
            GetNumber getNumber = new GetNumber();
            GetOperand getOperand = new GetOperand();

            do
            {


                firstNumber = getNumber.gettingNumber();
                operand = getOperand.GettingOperand();
                secondNumber = getNumber.gettingNumber();


                switch (operand)
                {
                    case "+":
                        result = MathResult.Sum(firstNumber, secondNumber);
                        Console.WriteLine("Результат :" + result);
                        break;
                    case "-":
                        result = MathResult.Minus(firstNumber, secondNumber);
                        Console.WriteLine("Результат :" + result);
                        break;
                    case "/":
                        result = MathResult.Division(firstNumber, secondNumber);
                        Console.WriteLine("Результат :" + result);
                        break;
                    case "*":
                        result = MathResult.Multiple(firstNumber, secondNumber);
                        Console.WriteLine("Результат :" + result);
                        break;
                    default:
                        Console.WriteLine("Что то не так");
                        break;
                }
                answer = getOperand.AskContinue();
                Console.Clear();
                Console.ReadKey();
            } while(answer == "y" || answer == "Yes" || answer == "Y" || answer == "yes");
            
        }
}
}