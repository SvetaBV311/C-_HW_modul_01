using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHWmod1
{
    public class Tasks
    {
        public static void TaskOne()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine();
            Console.WriteLine("Введите число в диапазоне от 1 до 100: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 1 || a > 100)
            {
                Console.WriteLine("Ошибка ввода");
            }
            else if (a % 5 == 0 && a % 3 == 0) { Console.WriteLine("Fizz Buzz"); }
            else if (a % 3 == 0) { Console.WriteLine("Fizz"); }
            else if (a % 5 == 0) { Console.WriteLine("Buzz"); }
            else { Console.WriteLine($"{a}"); }
            Console.WriteLine();
        }

        public static void TaskTwo()
        {
            Console.WriteLine("Задача 2");
            Console.WriteLine();
            Console.WriteLine("Введите число и процент от числа: ");
            float a = float.Parse(Console.ReadLine());
            float pr = float.Parse(Console.ReadLine());
            Console.WriteLine($"{pr}% от числа {a} = {a * pr / 100}");
            Console.WriteLine();
        }

        public static void TaskThree()
        {
            Console.WriteLine("Задача 3");
            Console.WriteLine();
            Console.WriteLine("Введите 4 цифры: ");
            double a = 0;
            for (double i = 4; i > 0; i--)
            {
                a += double.Parse(Console.ReadLine()) * Math.Pow(10, i - 1);
            }
            Console.WriteLine($"Ваше число {a}");
            Console.WriteLine();
        }

        public static void TaskFour()
        {
            Console.WriteLine("Задача 4");
            Console.WriteLine();
            Console.WriteLine("Введите шестизначное число: ");
            string a = Console.ReadLine();
            if (a.Length == 6)
            {
                Console.WriteLine("Введите номера разрядов для обмена цифр: ");
                int one = int.Parse(Console.ReadLine()) - 1;
                int two = int.Parse(Console.ReadLine()) - 1;
                char[] aArr = a.ToCharArray();
                aArr[one] = a[two];
                aArr[two] = a[one];
                Console.WriteLine(aArr);
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
        }

        public static void TaskFive()
        {
            Console.WriteLine("Задача 5");
            Console.WriteLine();
            Console.WriteLine("Введите дату в формате ДД.ММ.ГГГГ: ");
            string a = Console.ReadLine();
            char[] aArr = a.ToCharArray();
            int day = (a[0] - '0') * 10 + a[1] - '0';
            int month = (a[3] - '0') * 10 + a[4] - '0';
            int year = (a[6] - '0') * 1000 + (a[7] - '0') * 100 + (a[8] - '0') * 10 + (a[9] - '0');
            DateTime someDate = new DateTime(year, month, day);
            if (month == 1 || month == 2 || month == 12)
            {
                Console.Write("Winter ");
            }
            else if (month > 2 && month <= 5)
            {
                Console.Write("Spring ");
            }
            else if (month > 5 && month <= 8)
            {
                Console.Write("Summer ");
            }
            else
            {
                Console.Write("Autumn ");
            }
            Console.WriteLine(someDate.DayOfWeek);
        }

        public static void TaskSix()
        {
            Console.WriteLine("Задача 6");
            Console.WriteLine();
            Console.WriteLine("Введите значение температуры: ");
            double a = double.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Выберите требуемое действие: ");
                Console.WriteLine("1 - Перевести температуру из Фаренгейта в Цельсий;");
                Console.WriteLine("2 - Перевести температуру из Цельсия в Фаренгейт;");
                Console.WriteLine("3 - Ввести новое значение;");
                Console.WriteLine("4 - Выход.");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine($"Значение в Фаренгейтах: {a}");
                    Console.Write($"Значение в Цельсиях: ");
                    Console.WriteLine(Math.Round(0.555556 * (a - 32), 2));
                }
                else if (choice == 2)
                {
                    Console.WriteLine($"Значение в Цельсиях: {a}");
                    Console.Write($"Значение в Фаренгейтах: ");
                    Console.WriteLine(Math.Round(1.8 * a + 32, 2));
                }
                else if (choice == 3)
                {
                    Console.Write("Введите новое значение температуры:");
                    a = double.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
        }

        public static void TaskSeven()
        {
            Console.WriteLine("Задача 7");
            Console.WriteLine();
            Console.WriteLine("Укажите диапазон: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b < a)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            Console.WriteLine("Четные числа в вашем диапазоне: ");
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}


