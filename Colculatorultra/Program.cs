using System;

namespace Calcylatorultra
{
    internal class Program
    {
        static void Main()
        {
            Math calc = new Math();
            GUIConsoleApp arrayCalc = new GUIConsoleApp();
            bool cont = true;

            while (cont)
            {
                Console.Write("\n=== МЕНЮ ===\n");
                Console.Write("0 - проценты\n");
                Console.Write("1 - умножение\n");
                Console.Write("2 - деление\n");
                Console.Write("3 - вычитание\n");
                Console.Write("4 - сложение\n");
                Console.Write("5 - сумма массива\n");
                Console.Write("6 - поиск в массиве\n");
                Console.Write("7 - максимум массива\n");
                Console.Write("8 - минимум массива\n");
                Console.Write("9 - факториал\n");
                Console.Write("10 - остаток и целое от деления\n");
                Console.Write("11 - обратное процентам\n");
                Console.Write("12 - сортировка массива (доп)\n");
                Console.Write("Ваш выбор: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    Console.Write("Введите число: ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите процент: ");
                    double prc = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Результат: " + calc.Percent(num, prc) + "\n");
                }

                if (choice == 1)
                {
                    Console.Write("Введите первое число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Результат: " + calc.Multiply(a, b) + "\n");
                }

                if (choice == 2)
                {
                    Console.Write("Введите первое число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    if (b != 0) Console.Write("Результат: " + calc.Divide(a, b) + "\n");
                    else Console.Write("На ноль делить нельзя!\n");
                }

                if (choice == 3)
                {
                    Console.Write("Введите первое число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Результат: " + calc.Subtract(a, b) + "\n");
                }

                if (choice == 4)
                {
                    Console.Write("Введите первое число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Результат: " + calc.Add(a, b) + "\n");
                }

                if (choice == 5 || choice == 6 || choice == 7 || choice == 8 || choice == 12)
                {
                    Console.Write("Введите размер массива: ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write("arr[" + i + "] = ");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    if (choice == 5) Console.Write("Сумма: " + arrayCalc.Sum(arr) + "\n");
                    if (choice == 6)
                    {
                        Console.Write("Какой элемент ищем? ");
                        int target = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Индекс: " + arrayCalc.FindIndex(arr, target) + "\n");
                    }
                    if (choice == 7) Console.Write("Максимум: " + arrayCalc.Max(arr) + "\n");
                    if (choice == 8) Console.Write("Минимум: " + arrayCalc.Min(arr) + "\n");
                    if (choice == 12)
                    {
                        int[] sorted = arrayCalc.Sort(arr);
                        Console.Write("Отсортированный массив: ");
                        foreach (var x in sorted) Console.Write(x + " ");
                        Console.Write("\n");
                    }
                }

                if (choice == 9)
                {
                    Console.Write("Введите число: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Факториал: " + calc.Factorial(n) + "\n");
                }

                if (choice == 10)
                {
                    Console.Write("Введите делимое: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите делитель: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (b != 0)
                        Console.Write("Целое: " + calc.Div(a, b) + ", Остаток: " + calc.Mod(a, b) + "\n");
                    else
                        Console.Write("На ноль делить нельзя!\n");
                }

                if (choice == 11)
                {
                    Console.Write("Введите первое число: ");
                    double first = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double second = Convert.ToDouble(Console.ReadLine());
                    if (second != 0)
                        Console.Write("Первое число составляет " + calc.DPercent(first, second) + "% от второго\n");
                    else
                        Console.Write("На ноль делить нельзя!\n");
                }
                Console.Write("\nХотите продолжать? (y/n): ");
                string answer = Console.ReadLine();
                if (answer == "y" || answer == "Y") 
                    cont = true   ;
                else
                    break;
            }

            Console.Write("Программа завершена.\n");
            Console.ReadLine();
        }
    }
}