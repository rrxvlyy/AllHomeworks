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
            //Console.WriteLine("Задание 1");
            //Console.Write("Введите число: ");
            //string a = Console.ReadLine();
            //if (int.TryParse(a, out int b))
            //{
            //    Console.WriteLine($"Модуль числа {b} равен {Abs(b)}");
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка! Недопустимые символы");
            //}


            //Console.WriteLine("Задание 2");
            //Console.WriteLine("Введите 3 числа");
            //Console.Write("Первое число: ");
            //string a = Console.ReadLine();
            //Console.Write("Второе число: ");
            //string b = Console.ReadLine();
            //Console.Write("Третье число: ");
            //string c = Console.ReadLine();
            //if ((int.TryParse(a, out int aa)) && (int.TryParse(b, out int bb)) && (int.TryParse(c, out int cc)))
            //{
            //    Console.WriteLine($"Максимальное из 3 чисел: {max3(aa, bb, cc)}");
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка! Недопустимые символы");
            //}


            //Console.WriteLine("Задание 3");
            //Console.Write("Введите символ: ");
            //string symbol = Console.ReadLine();
            //Console.Write("Введите число повторений: ");
            //string count = Console.ReadLine();
            //bool c = int.TryParse(symbol, out int b);
            //bool c2 = int.TryParse(count, out int cnt);
            //if ((c == false) & (c2 == true))
            //{
            //    PrintLine(symbol, cnt);
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка! Недопустимые символы");
            //}


            //Console.WriteLine("Задание 4");
            //Console.Write("Введите строку: ");
            //string s = Console.ReadLine();
            //Console.Write("Сколько раз повторить: ");
            //string time = Console.ReadLine();
            //bool c = int.TryParse(s, out int b);
            //bool c2 = int.TryParse(time, out int t);
            //if ((c == false) & (c2 == true))
            //{
            //    Console.WriteLine(Repeat(s, t));
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка! Недопустимые символы");
            //}


            //Console.WriteLine("Задание 5");
            //Console.Write("Введите строку: ");
            //string s = Console.ReadLine();
            //Console.Write("Введите символ: ");
            //string symbol = Console.ReadLine();
            //string symbol_s = Convert.ToString(symbol);
            //int index = 0;
            //if ((symbol.Length == 0) || (symbol.Length > 1))
            //{
            //    Console.WriteLine("Ошибка! Недопустимые символы!");
            //}
            //else
            //{
            //    char symbol_char = Convert.ToChar(symbol);
            //    Console.WriteLine(TryIndexOf(s, symbol_char, out index));
            //}


            //Console.WriteLine("Задание 6");
            //Console.Write("Введите число: ");
            //string value = Console.ReadLine();
            //int b;
            //bool c = int.TryParse(value, out b);
            //if (c == true)
            //{
            //    int v = int.Parse(value);
            //    Console.Write("Введите макс.число: ");
            //    string max = Console.ReadLine();
            //    int r;
            //    bool f = int.TryParse(max, out b);
            //    if (f == true)
            //    {
            //        int mx = int.Parse(max);
            //        Console.Write("Введите мин.число: ");
            //        string min = Console.ReadLine();
            //        int p;
            //        bool o = int.TryParse(min, out b);
            //        if (o == true)
            //        {
            //            int mn = int.Parse(min);
            //            Console.WriteLine($"Исходная переменная: {v}");
            //            Console.Write("Измененная переменная: ");
            //            Clamp(ref v, mn, mx);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ошибка! Недопустимые символы");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ошибка! Недопустимые символы");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка! Недопустимые символы");
            //}


            //Console.WriteLine("Задание 7");
            //Console.Write("Введите строку: ");
            //string s = Console.ReadLine();
            //if ((s.Length == 0) || (s == " "))
            //{
            //    Console.WriteLine("Ошибка! Недопустимые символы!");
            //}
            //else
            //{
            //    Console.WriteLine($"Перевернутая строка: {ReverseRec(s)}");
            //}



            //Console.WriteLine("Задание 8");
            //Console.Write("Введите число: ");
            //string n = Console.ReadLine();
            //bool c = int.TryParse(n, out int b);
            //if (c == true)
            //{
            //    Console.WriteLine($"Сумма цифр числа равна {SumDigitsRec(b)}");
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка! Недопустимые символы!");
            //}


            //Console.WriteLine("Задание 9");
            //Console.Write("Введите длину 1 отрезка: ");
            //string a = Console.ReadLine();
            //bool a_check = int.TryParse(a, out int aa);
            //if (a_check == true)
            //{
            //    Console.Write("Введите длину 2 отрезка: ");
            //    string b = Console.ReadLine();
            //    bool b_check = int.TryParse(b, out int bb);
            //    if (b_check == true)
            //    {
            //        Console.Write("Введите длину 3 отрезка: ");
            //        string c = Console.ReadLine();
            //        bool c_check = int.TryParse(c, out int cc);
            //        if (c_check == true)
            //        {
            //            Console.WriteLine($"Можно ли образовать из этих отрезков треугольник: {IsTriangle(in aa, in bb, in cc)}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ошибка! Недопустимые символы!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ошибка! Недопустимые символы!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка! Недопустимые символы!");
            //}



            //Console.WriteLine("Задание 10");
            //Console.Write("Введите число: ");
            //string a = Console.ReadLine();
            //bool a_check = int.TryParse(a, out int aa);
            //if (a_check == true)
            //{
            //    Console.Write("Введите степень: ");
            //    string n = Console.ReadLine();
            //    bool n_check = int.TryParse(n, out int nn);
            //    if (n_check == true)
            //    {
            //        Console.WriteLine($"Быстрым возведением в степень получилось: {PowFast(aa, nn)}, число шагов: {powfast_count}");
            //        Console.WriteLine($"Обычным возведением в степень получилось: {PowRec(aa, nn)}, число шагов: {powrec_count}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ошибка! Недопустимые символы!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка! Недопустимые символы!");
            //}



            //Console.WriteLine("Задание 11");
            //Console.Write("Введите строку: ");
            //string s = Console.ReadLine();
            //if (s.Length == 0)
            //{
            //    Console.WriteLine("Ошибка! Недопустимые символы!");
            //}
            //else
            //{
            //    Console.WriteLine($"Строка сжата до: {CompressRuns(s)}");
            //}

        }
        // для 1 задания
        public static int Abs(int x)
        {
            if (x > 0)
            {
                return x;
            }
            else
            {
                return -x;
            }
        }
        // для 2 задания
        public static int max3(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }
        // для 3 задания
        public static void PrintLine(string symbol, int count = 10)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.Write(symbol);
            }
        }
        // для 4 задания
        public static string Repeat(string text, int times = 3)
        {
            string ss = "";
            for (int i = 1; i <= times; i++)
            {
                ss += text;
            }
            return ss;
        }
        //для 5 задания
        public static bool TryIndexOf(string s, char ch, out int index)
        {
            index = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }
        // для 6 задания
        public static void Clamp(ref int value, int min, int max)
        {
            if (value < min)
            {
                value = min;
            }
            else if (value > max)
            {
                value = max;
            }
            Console.WriteLine(value);
        }
        // для 7 задания
        public static string ReverseRec(string s)
        {
            if (s.Length == 0)
            {
                return s;
            }
            return (s[s.Length - 1]) + ReverseRec(s.Remove(s.Length - 1));
        }


        // для 8 задания
        public static int SumDigitsRec(int n)
        {
            n = Math.Abs(n);
            string nn = n.ToString();
            if (nn.Length < 2)
            {
                return int.Parse(nn);
            }
            return int.Parse(nn[0].ToString()) + SumDigitsRec(int.Parse(nn.Remove(0, 1)));
        }

        // для 9 задания
        public static bool IsTriangle(in int a, in int b, in int c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // для 10 задания
        private static int powfast_count = 0;
        private static int powrec_count = 0;
        public static int PowFast(int a, int n)
        {
            if (n % 2 != 0)
            {
                powfast_count++;
                return a * PowFast(a, (n - 1));
            }
            else if (n == 0)
            {
                powfast_count++;
                return 1;
            }
            else
            {
                powfast_count++;
                int p = PowFast(a, (n / 2));
                return p * p;
            }

        }
        public static int PowRec(int a, int n)
        {
            if (n == 0)
            {
                powrec_count++;
                return 1;
            }
            else if (n == 1)
            {
                powrec_count++;
                return a;
            }
            else
            {
                powrec_count++;
                return a * PowRec(a, n - 1);
            }
        }


        // для 11 задания
        public static string CompressRuns(string s)
        {
            string ss = $"{s[0]}";
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    ;
                }
                else
                {
                    ss += s[i + 1];
                }
            }
            return ss;
        }
    }
}
        
    

