using System;
using System.Collections.Generic;
using System.Text;

namespace HW3part2_simpleCalculator_
{
    class GetNumber
    {
        public double gettingNumber()
        {
            double number;
            bool no = false;
            do
            {
                Console.WriteLine("Введите  число");
                no = double.TryParse(Console.ReadLine(), out number);
                if (!no)

                {
                    Console.WriteLine("Неверные Данные");
                }
            } while (!no);
            return number;

        }
    }
}
