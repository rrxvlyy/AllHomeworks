
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 task
            //Console.Write("Введите строку с числом: ");
            //string s = Console.ReadLine();
            //int s1 = int.Parse(s);
            //Console.WriteLine($"Ответ: {s1 + 100}");


            // 2 task
            //double n1 = ((double)(7 / 2));
            //int n2 = ((int)(7.0 / 2));
            //Console.WriteLine($"{n1}");
            //Console.WriteLine($"{n2}");


            // 3 task
            //Console.Write("Введите строку: ");
            //string s = Console.ReadLine();
            //int a;
            //bool s1 = int.TryParse(s, out a);
            //if (s1 == true)
            //{
            //    Console.WriteLine($"Квадрат числа равен: {a * a}");
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка ввода");
            //}


            // 4 task
            //Console.Write("Введите дробное число: ");
            //double s_d = double.Parse(Console.ReadLine());
            //Console.WriteLine($"До: {s_d}");
            //Console.WriteLine($"После: {(int) s_d}");


            //5 task
            //int[] massive = new int[5] { 11, 54, 78, 98, 45 };
            //for (int i = 0; i < massive.Length; i++)
            //    Console.Write(massive[i] + " ");


            // 6 task
            //int[] massive = new int[5] { 11, 54, 78, 98, 45 };
            //int count = 0;
            //for (int i = 0; i < massive.Length; i++)
            //    if (massive[i] % 2 == 0)
            //        count += 1;
            //Console.WriteLine($"В массиве {count} четных чисел");


            // 7 task
            //int[] massive = new int[5] { 11, 54, 78, 98, 45 };
            //int summa = 0;
            //for (int i = 0; i < massive.Length; i++)
            //    summa += massive[i];
            //double sr_arifm = ((double)summa / massive.Length);
            //Console.WriteLine($"Сумма элементов массива: {summa}");
            //Console.WriteLine($"Среднее арифм-ое элементов массива {sr_arifm}");


            // 8 task
            //int[] massive = new int[5] { 11, 54, 78, 98, 45 };
            //int number0 = massive[0];
            //massive[0] = massive[massive.Length - 1];
            //massive[massive.Length - 1] = number0;
            //for (int i = 0; i < massive.Length; i++)
            //    Console.WriteLine(massive[i]);


            // 9 task
            //int[] massive = new int[6] { 11, 54, 1, 1878, 45, 40 };
            //int minn_index = 0;
            //int maxx_index = 0;
            //int minn = 10000000;
            //int maxx = 0;
            //for (int i = 0; i < massive.Length; i++)
            //    if (massive[i] > maxx)
            //    {
            //        maxx = massive[i];
            //        maxx_index = i;
            //    }
            //for (int i = 0; i < massive.Length; i++)
            //    if (massive[i] < minn)
            //    {
            //        minn = massive[i];
            //        minn_index = i;
            //    }
            //Console.WriteLine($"Мин.элемент {minn}, индекс {minn_index}");
            //Console.WriteLine($"Макс.элемент {maxx}, индекс {maxx_index}");


            // 10 task
            //int[] massive = new int[10];
            //int[] massive2 = new int[2 * massive.Length];
            //int count = 5;
            //for (int i = count; i < massive.Length; i++)
            //{
            //    massive[i] = i;
            //}
            //for (int i = 0; i < massive.Length; i++)
            //{
            //    Console.WriteLine(massive[i]);
            //}
            //if (count == massive.Length)
            //{
            //    for (int i = 0; i < massive.Length; i++)
            //    {
            //        massive2[i] = massive[i];
            //    }
            //    for (int i = 0; i < massive2.Length; i++)
            //    {
            //        Console.WriteLine(massive2[i]);
            //    }
            //}


            // 11 task
            //int[] massive = new int[5] { 11, 54, 78, 98, 45 };
            //int[] massive2 = new int[massive.Length - 1];
            //int currentind = 0;
            //Console.Write("Введите индекс, к-ый нужно удалить: ");
            //int index = int.Parse(Console.ReadLine());
            //for (int i = 0; i < massive.Length; i++)
            //    if (index != i)
            //    {
            //        massive2[currentind] = massive[i];
            //        currentind += 1;
            //    }
            //for (int i = 0; i < massive2.Length; i++)
            //    Console.WriteLine(massive2[i]);


            // 12 task
            //int[] massive = new int[5] { 11, 54, 78, 98, 45 };
            //int[] massive2 = new int[massive.Length - 1];
            //int currentind = 0;
            //Console.Write("Введите индекс, к-ый нужно удалить: ");
            //int index = int.Parse(Console.ReadLine());
            //for (int i = 0; i < massive.Length - 1; i++)
            //    if (index != i)
            //    {
            //        massive2[currentind] = massive[i];
            //        currentind += 1;
            //    }
            //    else
            //    {
            //        massive2[i] = massive[massive.Length - 1];
            //        currentind += 1;
            //    }
            //for (int i = 0; i < massive2.Length; i++)
            //    Console.WriteLine(massive2[i]);


            //13 task
            //int[] massive = new int[5] { 11, 54, 78, 98, 45 };
            //int[] massive2 = new int[massive.Length - 1];
            //int currentind = 0;
            //Console.Write("Введите элемент: ");
            //int element = int.Parse(Console.ReadLine());
            //for (int i = 0; i < massive.Length; i++)
            //    if (element != massive[i])
            //    {
            //        massive2[currentind] = massive[i];
            //        currentind += 1;
            //    }
            //for (int i = 0; i < massive2.Length; i++)
            //    Console.WriteLine(massive2[i]);


            // 14 task
            //int[] massive = new int[5] { 11, 54, 78, 98, 45 };
            //Console.WriteLine(massive.Reverse());
            //for (int i = massive.Length - 1; i >= 0; i--)
            //    Console.WriteLine(massive[i]);


            // 15 task
            //int[] massive = new int[5] { 1, 2, 3, 4, 5 };
            //int a = 0;
            //if ((massive[0] == massive[massive.Length - 1]) & (massive[1] == massive[massive.Length - 2]))
            //{
            //    a += 1;
            //}
            //if (a == 1)
            //    Console.WriteLine("Это палиндром");
            //else
            //    Console.WriteLine("Это не палиндром");


            // 16 task
            //Console.WriteLine("Введите размер массива: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] massive = new int[n];
            //int[] massive2 = new int[n];
            //int currentind = 1;
            //Console.WriteLine("Введите элементы массива: ");
            //for (int i = 0; i < n; i++)
            //{
            //    massive[i] = int.Parse(Console.ReadLine());
            //}
            //massive2[0] = massive[0];
            //for (int i = 0; i < n - 1; i++)
            //{
            //    if (massive[i] != massive[i + 1])
            //    {
            //        massive2[currentind] = massive[i + 1];
            //        currentind += 1;
            //    }
            //}
            //Console.WriteLine("Ответ:");
            //for (int i = 0; i < currentind; i++)
            //    Console.WriteLine(massive2[i]);
        }
    }
}
