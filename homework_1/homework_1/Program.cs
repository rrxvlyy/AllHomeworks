using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0 задание
            //Console.WriteLine("Hello, World!");


            // 1 задание
            //Console.Write("Введите первое число: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Сумма чисел: {number1 + number2}");
            //Console.WriteLine($"Разность чисел: {number1 - number2}");
            //Console.WriteLine($"Произведение чисел: {number1 * number2}");
            //if (number2 == 0)
            //    Console.WriteLine("На 0 делить нельзя!");
            //else
            //    Console.WriteLine($"Частное чисел: {(float)number1 / number2}");


            // 2 задание
            //Console.Write("Введите возраст: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age < 12)
            //    Console.WriteLine("Ты ребенок");
            //else if (age >= 12 & age <= 17)
            //    Console.WriteLine("Ты подросток");
            //else
            //    Console.WriteLine("Ты взрослый");


            // 3 задание
            //Console.Write("Введите число: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //    Console.WriteLine("Число четное");
            //else
            //    Console.WriteLine("Число нечетное");


            // 4 задание
            //Console.Write("Введите число: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 3 == 0 & number % 5 == 0)
            //    Console.WriteLine("Число делится и на 3, и на 5");
            //else if (number % 3 == 0 & number % 5 != 0)
            //    Console.WriteLine("Число делится на 3, но не делится на 5");
            //else if (number % 3 != 0 & number % 5 == 0)
            //    Console.WriteLine("Число не делится на 3, но делится на 5");
            //else if (number % 3 != 0 & number % 5 != 0)
            //    Console.WriteLine("Число не делится ни на 3, ни на 5");


            // 5 задание
            //Console.Write("Введите число: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int summa = 0;
            //for (int i = 1; i <= number; i++)
            //{
            //    summa = summa + i;
            //}
            //Console.WriteLine($"Сумма чисел равна: {summa}");


            // 6 задание
            //Console.Write("Введите число: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{n} * {i} = {n * i}");
            //}


            // 7 задание
            //Console.Write("Введите число: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    factorial = factorial * i;
            //}
            //Console.WriteLine($"Факториал числа {n} равен: {factorial}");


            // 8 задание
            //bool PasswordCorrect = false;
            //while (PasswordCorrect == false)
            //{
            //    Console.Write("Введите пароль: ");
            //    string password = Console.ReadLine();
            //    if (password == "12345")
            //    {
            //        PasswordCorrect = true;
            //        Console.WriteLine("Пароль верный");
            //    }
            //}


            // 9 задание
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Числа, к-ые делятся на 2 или на 3: ");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }


        }




        }
    }
