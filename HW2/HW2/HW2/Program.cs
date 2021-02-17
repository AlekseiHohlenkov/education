using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbyteMaxValue = 127; //-128 (8bit)
            byte byteMaxValue = 255; // 0 (8bit)
            short shortMaxValue = 32767; //-32767 (16bit)
            ushort ushortMaxValue = 65535; // 0 (16bit)
            int intMaxValue = 2147483647; //-2147483648 (32bit)
            long longMaxValue = 9223372036854775807; //-9223372036854775808 (64bit)
            ulong ulongMaxValue = 18446744073709551615; // 0 (64bit)

            float floatMaxValue = 3.40282347E+38F; // -3.40282347E+38F
            double doubleMaxValue = 1.7976931348623157E+308; // -1.7976931348623157E+308

            
            bool yes = true;
            bool no = false;


            Console.WriteLine("yes || no " + "= " +  (yes||no));
            Console.WriteLine("yes && no " + "= " + (yes&&no));
            Console.WriteLine("!no " + "= " + (!no));
            Console.WriteLine("sbyteMaxValue > byteMaxValue " + "= " + (sbyteMaxValue> byteMaxValue));
            Console.WriteLine("ushortMaxValue >= shortMaxValue " + "= " +(ushortMaxValue>= shortMaxValue));
            Console.WriteLine("intMaxValue < longMaxValue " + "= " + (intMaxValue< longMaxValue));
            Console.WriteLine("ulongMaxValue <= floatMaxValue " + "= " + (ulongMaxValue<= floatMaxValue));
            Console.WriteLine("yes != no " + "= " + (yes!= no));
            Console.WriteLine("doubleMaxValue == intMaxValue " + "= " + (doubleMaxValue == intMaxValue));
            Console.WriteLine("yes ^ no " + "= " + (yes^no));

        }
    }
}
