using System;

class Program
{
    static void Main()
    {
        // //задание 1
        // PrintHeader("zagolovok 1");
        // PrintHeader("zagolovok 2");

        // //задание 2.1
        // Console.WriteLine(Max(19, 16));
        // Console.WriteLine(Max(10, 4));
        // Console.WriteLine(IsEven(5));
        // Console.WriteLine(IsEven(8));

        // //задание 3
        // int[] marks = { 120, 45, 300, 80, 15, 210 };
        // Console.WriteLine(Average(marks));
        // Console.WriteLine(CountGreater(marks, 100));

        // //задание 4
        // Console.WriteLine($"{ToFahrenheit(0)} °F");
        // Console.WriteLine($"{ToFahrenheit(100)} °F");
        // Console.WriteLine($"{ToFahrenheit(37)} °F");

        // //задание 5
        // for (int i = 2; i <= 50; i++)
        //     if (IsPrime(i)) Console.Write($"{i} ");

        // //задание 6
        // int num1 = ReadPositive("введите 1 положительное число: ");
        // int num2 = ReadPositive("введите 2 положительное число: ");
        // Console.WriteLine($"сумма: {Sum(num1, num2)}");

        // доп.задание
        
        Console.WriteLine(" доп. задание ");
        Console.WriteLine($"Gcd(48, 18) = {Gcd(48, 18)}");
        Console.WriteLine($"Lcm(4, 6) = {Lcm(4, 6)}");
        Console.WriteLine();

        // калькулятор 
        MenuCalculator();
    }

   
    // методы
   

    static void PrintLine()
    {
        Console.WriteLine("^_^");
    }

    static void PrintHeader(string title)
    {
        PrintLine();
        Console.WriteLine(title);
        PrintLine();
    }

    static int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    static bool IsEven(int n)
    {
        return n % 2 == 0;
    }

    static double Average(int[] arr)
    {
        int sum = 0;
        foreach (int x in arr) sum += x;
        return (double)sum / arr.Length;
    }

    static int CountGreater(int[] arr, int limit)
    {
        int count = 0;
        foreach (int x in arr)
            if (x > limit) count++;
        return count;
    }

    static double ToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    static long Factorial(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    static int ReadPositive(string message)
    {
        do
        {
            Console.Write(message);

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number > 0)
                    return number;
                Console.WriteLine("ошибка");
            }
            else
            {
                Console.WriteLine("ошибка");
            }
        } while (true);
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }


    //меню калькулятор 
   
    static void MenuCalculator()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n меню");
            Console.WriteLine("1. сумма двух чисел");
            Console.WriteLine("2. большее из двух чисел");
            Console.WriteLine("3. факториал числа");
            Console.WriteLine("0. выход");
            Console.Write("выберите пункт: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        int s1 = ReadPositive("введите первое число: ");
                        int s2 = ReadPositive("введите второе число: ");
                        Console.WriteLine($"сумма: {Sum(s1, s2)}");
                        break;
                    case 2:
                        int m1 = ReadPositive("введите первое число: ");
                        int m2 = ReadPositive("введите второе число: ");
                        Console.WriteLine($"максимум: {Max(m1, m2)}");
                        break;
                    case 3:
                        int f = ReadPositive("введите число: ");
                        Console.WriteLine($"{f}! = {Factorial(f)}");
                        break;
                    case 0:
                        exit = true;
                        Console.WriteLine("выход");
                        break;
                    default:
                        Console.WriteLine("нет такого пункта");
                        break;
                }
            }
            else
            {
                Console.WriteLine("нет такого пункта");
            }
        }
    }

    // доп.задание
  
    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int Lcm(int a, int b)
    {
        return a / Gcd(a, b) * b;
    }
}