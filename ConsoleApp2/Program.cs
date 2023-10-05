using System;

class Calculator
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Выйти из программы");
            Console.WriteLine("2. Найти факториал из числа");
            Console.WriteLine("3. Вычесть первое из второго");
            Console.WriteLine("4. Сложить 2 числа");
            Console.WriteLine("5. Перемножить два числа");
            Console.WriteLine("6. Найти 1 процент от числа");
            Console.WriteLine("7. Найти квадратный корень из числа");
            Console.WriteLine("8. Возвести в степень N первое число");
            Console.WriteLine("9. Разделить первое на второе");
            int choice;
            double result = 0;

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                double num1, num2;

                switch (choice)
                {
                    case 1:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;

                    case 2:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        result = CalculateFactorial(num1);
                        break;

                    case 3:

                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 - num2;
                        break;
                    case 4:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 + num2;
                        break;
                    case 5:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 * num2;
                        break;
                    case 6:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        result = num1 * 0.01;
                        break;
                    case 7:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        if (num1 >= 0)
                            result = Math.Sqrt(num1);
                        else
                            Console.WriteLine("Извлечение корня из отрицательного числа недопустимо.");
                        break;
                    case 8:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        int exponent = int.Parse(Console.ReadLine());
                        result = Math.Pow(num1, exponent);
                        break;
                    case 9:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            Console.WriteLine("Деление на ноль недопустимо.");
                        break;

                }

                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 1 до 9.");
            }
        }
    }

    static double CalculateFactorial(double n)
    {
        if (n < 0)
        {
            throw new Exception("Факториал отрицательного числа недопустим.");
        }

        if (n == 0)
        {
            return 1;
        }
        else
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}