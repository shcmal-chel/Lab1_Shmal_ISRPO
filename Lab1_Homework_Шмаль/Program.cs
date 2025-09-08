using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.

            Console.Write("Введите первое число: ");
            int integer_1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int integer_2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Сумма этих чисел: {0}",integer_1+integer_2);
            Console.WriteLine("Разность этих чисел: {0}", integer_1 - integer_2);
            Console.WriteLine("Произведение этих чисел: {0}", integer_1 * integer_2);
            Console.WriteLine("Частное этих чисел: {0}", integer_1 / integer_2);
            Console.WriteLine();

            //Задание 2.

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите любимый язык программирования: ");
            string language = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Привет, {0}!", name);
            Console.WriteLine("Тебе {0} лет.", age);
            Console.WriteLine("Твой любимый язык программирования - {0}.", language);
            Console.WriteLine();

            //Задание 3.

            Console.Write("Введите первое значение: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе значение: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье значение: ");
            int c = int.Parse(Console.ReadLine());
            int x = 5;

            Console.WriteLine();
            Console.WriteLine("Значение функции f(5): {0}", (a * (Math.Pow(x, 2)) + b * x + c));
            Console.WriteLine();

            //Задание 4.

            Console.Write("Введите имя: ");
            string name_1 = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age_1 = int.Parse(Console.ReadLine());

            Console.Write("Введите город проживания: ");
            string city = Console.ReadLine();

            Console.Write("Введите любимое число: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Введите температуру в градусах Цельсия за окном: ");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("=== ПЕРСОНАЛЬНЫЙ ПРОФИЛЬ ===");
            Console.WriteLine();
            Console.WriteLine("Привет {0}!", name_1);
            Console.WriteLine("Тебе {0} лет.", age_1);
            Console.WriteLine("В следующем году тебе будет {0}.", age_1 + 1);
            Console.WriteLine();
            Console.WriteLine("Ты живешь в городе {0}.", city);
            Console.WriteLine("Твое любимое число: {0} (в квадрате: {1})", number, Math.Pow(number, 2));
            Console.WriteLine();
            Console.WriteLine("Температура за окном: ");
            Console.WriteLine("- В Цельсиях: {0}°C", temperature);
            Console.WriteLine("- В Фаренгейтах: {0}°F", (temperature * 9 / 5) + 32);
            Console.WriteLine();
            Console.WriteLine("=== КОНЕЦ ПРОФИЛЯ ===");
        }
    }
}