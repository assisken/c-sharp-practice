﻿using System;

namespace CSharpPractice1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.");
            Console.WriteLine("5. Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.");
            Console.WriteLine("6. Создать класс с методами, которые могут пригодиться в вашей учебе ");
            Console.WriteLine("Любое другое значение -- Выход");

            var select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 4:
                    FourthProgram.Run();
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
        }
    }
}