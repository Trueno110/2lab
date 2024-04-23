using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zad_20();
        }
        public static void Zad_1()
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number > 0)
            {
                Console.WriteLine("Число положительное");
            }
            else if (number < 0)
            {
                Console.WriteLine("Число отрицательное");
            }
            else
            {
                Console.WriteLine("Число равно нулю");
            }
        }
        public static void Zad_2()
        {
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Год " + year + " високосный.");
            }
            else
            {
                Console.WriteLine("Год " + year + " не високосный.");
            }
        }
        public static void Zad_3()
        {

            Console.WriteLine("Введите символ:");
            char symbol = Console.ReadKey().KeyChar;


            if (char.IsLetter(symbol))
            {
                if ("aeiouAEIOU".Contains(symbol))
                {
                    Console.WriteLine("\nЭто гласная буква.");
                }
                else
                {
                    Console.WriteLine("\nЭто согласная буква.");
                }
            }
            else
            {
                Console.WriteLine("\nЭто не буква.");
            }
        }
        public static void Zad_4()
        {

            Console.WriteLine("Введите три числа:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 <= num2 && num1 <= num3)
            {
                Console.WriteLine("Наименьшее число: " + num1);
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                Console.WriteLine("Наименьшее число: " + num2);
            }
            else
            {
                Console.WriteLine("Наименьшее число: " + num3);
            }
        }
        public static void Zad_5()
        {

            Console.WriteLine("Введите год:");
            int year = int.Parse(Console.ReadLine());

            if (year % 100 == 0)
            {
                Console.WriteLine("Год является вековым.");
            }
            else
            {
                Console.WriteLine("Год не является вековым.");
            }

        }
        public static void Zad_6()
        {

            int min = 0;
            int max = 10000;


            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number >= min && number <= max)
                Console.WriteLine("Число принадлежит диапазону от {0} до {1}.", min, max);
            else
                Console.WriteLine("Число не принадлежит диапазону от {0} до {1}.", min, max);

            Console.ReadLine();
        }
        public static void Zad_7()
        {

            Console.WriteLine("Введите символ:");
            char symbol = Console.ReadKey().KeyChar;

            if (char.IsDigit(symbol))
            {
                Console.WriteLine("\nВведенный символ является цифрой.");
            }
            else if (char.IsLetter(symbol))
            {
                Console.WriteLine("\nВведенный символ является буквой.");
            }
            else
            {
                Console.WriteLine("\nВведенный символ является специальным символом.");
            }
        }
        public static void Zad_8()
        {

            Console.WriteLine("Введите номер месяца (от 1 до 12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Ошибка: введите корректный номер месяца");
            }
            else
            {
                string season = GetSeason(month);
                Console.WriteLine($"Месяц {month} является {season}.");
            }
        }
        static string GetSeason(int month)
        {
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    return "зимним";
                case 3:
                case 4:
                case 5:
                    return "весенним";
                case 6:
                case 7:
                case 8:
                    return "летним";
                case 9:
                case 10:
                case 11:
                    return "осенним";
                default:
                    return "неопределенным";
            }

        }
        public static void Zad_9()
        {

            Console.WriteLine("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year >= 2000 && year <= 2099)
            {
                Console.WriteLine("Год " + year + " принадлежит XXI веку");
            }
            else if (year >= 1900 && year <= 1999)
            {
                Console.WriteLine("Год " + year + " принадлежит XX веку");
            }
            else
            {
                Console.WriteLine("Год " + year + " не принадлежит ни XX, ни XXI веку");
            }
        }
        public static void Zad_10()
        {
            int number;
            Console.WriteLine("Введите число:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
        public static void Zad_11()
        {
            Console.WriteLine("Введите символ:");
            char input = Console.ReadKey().KeyChar;

            if (char.IsLower(input))
            {
                Console.WriteLine("\nВы ввели строчную букву.");
            }
            else if (char.IsUpper(input))
            {
                Console.WriteLine("\nВы ввели заглавную букву.");
            }
            else
            {
                Console.WriteLine("\nВы ввели не буквенный символ.");
            }
        }
        public static void Zad_12()
        {
            Console.WriteLine("Введите номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());

            int quarter = (month - 1) / 3 + 1;

            switch (quarter)
            {
                case 1:
                    Console.WriteLine("Первый квартал");
                    break;

                case 2:
                    Console.WriteLine("Второй квартал");
                    break;

                case 3:
                    Console.WriteLine("Третий квартал");
                    break;

                case 4:
                    Console.WriteLine("Четвертый квартал");
                    break;

                default:
                    Console.WriteLine("Неверный номер месяца");
                    break;
            }
        }
        public static void Zad_13()
        {
            Console.Write("Введите номер месяца (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int daysInMonth;

            switch (month)
            {
                case 1: 
                case 3: 
                case 5: 
                case 7: 
                case 8: 
                case 10: 
                case 12: 
                    daysInMonth = 31;
                    break;
                case 4: 
                case 6: 
                case 9: 
                case 11: 
                    daysInMonth = 30;
                    break;
                case 2: 
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        daysInMonth = 29; 
                    }
                    else
                    {
                        daysInMonth = 28; 
                    }
                    break;
                default:
                    Console.WriteLine("Некорректный номер месяца");
                    return;
            }

            Console.WriteLine($"Количество дней в выбранном месяце: {daysInMonth}");
        }
        public static void Zad_14()
        {
            Console.Write("Введите номер месяца: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            string monthName;
            switch (monthNumber)
            {
                case 1:
                    monthName = "Январь";
                    break;
                case 2:
                    monthName = "Февраль";
                    break;
                case 3:
                    monthName = "Март";
                    break;
                case 4:
                    monthName = "Апрель";
                    break;
                case 5:
                    monthName = "Май";
                    break;
                case 6:
                    monthName = "Июнь";
                    break;
                case 7:
                    monthName = "Июль";
                    break;
                case 8:
                    monthName = "Август";
                    break;
                case 9:
                    monthName = "Сентябрь";
                    break;
                case 10:
                    monthName = "Октябрь";
                    break;
                case 11:
                    monthName = "Ноябрь";
                    break;
                case 12:
                    monthName = "Декабрь";
                    break;
                default:
                    monthName = "Некорректный номер месяца";
                    break;
            }

            Console.WriteLine("Название месяца: " + monthName);
        }
        public static void Zad_15()
        {
            Console.Write("Введите номер месяца (1-12): ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Это зима.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Это весна.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Это лето.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Это осень.");
                    break;
                default:
                    Console.WriteLine("Некорректный номер месяца.");
                    break;
            }
        }
        public static void Zad_16()
        {
            Console.Write("Введите номер дня недели (от 1 до 7): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            string dayName;
            switch (dayNumber)
            {
                case 1:
                    dayName = "Понедельник";
                    break;
                case 2:
                    dayName = "Вторник";
                    break;
                case 3:
                    dayName = "Среда";
                    break;
                case 4:
                    dayName = "Четверг";
                    break;
                case 5:
                    dayName = "Пятница";
                    break;
                case 6:
                    dayName = "Суббота";
                    break;
                case 7:
                    dayName = "Воскресенье";
                    break;
                default:
                    dayName = "Ошибка: такого дня недели не существует";
                    break;
            }

            Console.WriteLine($"День недели с номером {dayNumber} - это {dayName}.");
        }
        public static void Zad_17()
        {
            Console.WriteLine("Введите день:");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите год:");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);
            DayOfWeek dayOfWeek = date.DayOfWeek;

            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Воскресенье");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Понедельник");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Вторник");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Среда");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Четверг");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Пятница");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Суббота");
                    break;
            }
        }
        public static void Zad_18()
        {
            Console.WriteLine("Введите номер месяца (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());

            int daysInMonth;

            switch (month)
            {
                case 1: 
                case 3: 
                case 5: 
                case 7: 
                case 8: 
                case 10: 
                case 12: 
                    daysInMonth = 31;
                    break;
                case 4: 
                case 6: 
                case 9: 
                case 11: 
                    daysInMonth = 30;
                    break;
                case 2: 
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        daysInMonth = 29; 
                    }
                    else
                    {
                        daysInMonth = 28; 
                    }
                    break;
                default:
                    daysInMonth = -1; 
                    break;
            }

            if (daysInMonth == -1)
            {
                Console.WriteLine("Некорректный номер месяца");
            }
            else
            {
                Console.WriteLine($"В {month} месяце {year} года будет {daysInMonth} дней");
            }
        }
        public static void Zad_19()
        {
            Console.WriteLine("Введите время суток (утро, день, вечер, ночь):");
            string timeOfDay = Console.ReadLine();

            switch (timeOfDay.ToLower())
            {
                case "утро":
                    Console.WriteLine("Вы выбрали утро.");
                    if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
                    {
                        Console.WriteLine("Сейчас утро.");
                    }
                    else
                    {
                        Console.WriteLine("Сейчас не утро.");
                    }
                    break;
                case "день":
                    Console.WriteLine("Вы выбрали день.");
                    if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                    {
                        Console.WriteLine("Сейчас день.");
                    }
                    else
                    {
                        Console.WriteLine("Сейчас не день.");
                    }
                    break;
                case "вечер":
                    Console.WriteLine("Вы выбрали вечер.");
                    if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 24)
                    {
                        Console.WriteLine("Сейчас вечер.");
                    }
                    else
                    {
                        Console.WriteLine("Сейчас не вечер.");
                    }
                    break;
                case "ночь":
                    Console.WriteLine("Вы выбрали ночь.");
                    if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 6)
                    {
                        Console.WriteLine("Сейчас ночь.");
                    }
                    else
                    {
                        Console.WriteLine("Сейчас не ночь.");
                    }
                    break;
                default:
                    Console.WriteLine("Некорректное время суток.");
                    break;
            }
        }
        public static void Zad_20()
        {
            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 100 == 0)
            {
                Console.WriteLine("Введенный год - вековой");
            }
            else
            {
                Console.WriteLine("Введенный год - не вековой");
            }

            int century = year / 100 + 1;
            switch (century)
            {
                case 21:
                    Console.WriteLine("Введенный год относится к 21 веку");
                    break;
                case 20:
                    Console.WriteLine("Введенный год относится к 20 веку");
                    break;
                default:
                    Console.WriteLine("Введенный год относится к другому веку");
                    break;
            }
        }
    }
}
