using System;
using System.Collections.Generic;
using System.Text;

namespace HW3part2_simpleCalculator_
{
    public class GetOperand
    {
        public string GettingOperand()
        {
            string operand;
            bool no = false;
            Console.WriteLine("введите нужный операнд(+ , -, *, /)");
            do
            {
                operand = Console.ReadLine();
                if ((operand == "*") || (operand == "/") || (operand == "-") || (operand == "+"))
                {
                    no = true;

                }
                else
                {
                    Console.WriteLine("Вы ввели неверный операнд действия, попробуйте еще раз! ");
                }
            } while (!no);
            return operand;
        }

        public string  AskContinue()
         
        {
            Console.WriteLine("Продолжить y/n");
            Console.WriteLine();
            string answer = Console.ReadLine();
            return answer;
        }
        

    }
}
