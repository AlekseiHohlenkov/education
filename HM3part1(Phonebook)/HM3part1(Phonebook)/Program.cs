using System;


namespace HM3part1_Phonebook_
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = new String[5];
            Int64[] phoneNumber = new Int64[5];
            byte[] age = new byte[5];

            Console.WriteLine("В вашей записной книжке 0 контактов, что бы добавить новый введите имя");
            names[0] = Console.ReadLine();
            Console.WriteLine("Теперь введите номер");
            phoneNumber[0] = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Возраст");
            age[0] = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Вы успешно добавили новый контакт " + (names[0]));


            Console.WriteLine("Что бы добавить еще один введите имя");
            names[1] = Console.ReadLine();
            Console.WriteLine("Теперь введите номер");
            phoneNumber[1] = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Возраст");
            age[1] = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Вы успешно добавили новый контакт " + (names[1]));

            Console.WriteLine("Что бы добавить еще один введите имя");
            names[2] = Console.ReadLine();
            Console.WriteLine("Теперь введите номер");
            phoneNumber[2] = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Возраст");
            age[2] = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Вы успешно добавили новый контакт " + (names[2]));

            Console.WriteLine("Что бы добавить еще один введите имя");
            names[3] = Console.ReadLine();
            Console.WriteLine("Теперь введите номер");
            phoneNumber[3] = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Возраст");
            age[3] = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Вы успешно добавили новый контакт " + (names[3]));

            Console.WriteLine("Что бы добавить еще один введите имя");
            names[4] = Console.ReadLine();
            Console.WriteLine("Теперь введите номер");
            phoneNumber[4] = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Возраст");
            age[4] = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Вы успешно добавили новый контакт " + (names[4]));


            Console.ReadLine();








        }
    }
}
