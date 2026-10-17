// //задание 1
// PrintHeader("zagolovok 1");
// PrintHeader("zagolovok 2");

// static void PrintLine()
// {
//     Console.WriteLine("^_^");
// }
// static void PrintHeader(string title)
// {
//     PrintLine();
//     Console.WriteLine(title);
//     PrintLine();
// }
// //задание 2.1
// Console.WriteLine(Max(19, 16));
// Console.WriteLine(Max(10, 4));
// Console.WriteLine(IsEven(5));
// Console.WriteLine(IsEven(8));

// static int Max(int a, int b)
// {
//     return a > b ? a : b;
// }
// //задание 2.2
// static bool IsEven(int n)
// {
//     return n % 2 == 0;
// }
//задание 3
// int[] marks = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(marks));
// Console.WriteLine(CountGreater(marks, 100));

// static double Average(int[] arr)
// {
//     int sum = 0;
//     foreach (int x in arr) sum += x;
//     return (double)sum / arr.Length;
// }

// static int CountGreater(int[] arr, int limit)
// {
//     int count = 0;
//     foreach (int x in arr)
//         if (x > limit) count++;
//     return count;
// }

// //задание 4
// Console.WriteLine($"{ToFahrenheit(0)} °F");
// Console.WriteLine($"{ToFahrenheit(100)} °F");
// Console.WriteLine($"{ToFahrenheit(37)} °F");

// static double ToFahrenheit(double celsius)
// {
//     return celsius * 9 / 5 + 32;
// }

//задание 5

// static long Factorial(int n)
// {
//     long result = 1;
//     for (int i = 1; i <= n; i++)
//         result *= i;
//     return result;
// }

// static bool IsPrime(int n)
// {
//     if (n < 2) return false;
//     for (int i = 2; i <= Math.Sqrt(n); i++)
//         if (n % i == 0) return false;
//     return true;
// }

// for (int i = 2; i <= 50; i++)
//     if (IsPrime(i)) Console.Write($"{i} ");

//задание 6

// int num1 = ReadPositive("введите 1 положительное число: ");
// int num2 = ReadPositive("введите 2 положительное число: ");

// Console.WriteLine($"сумма: {Sum(num1, num2)}");

// static int ReadPositive(string message)
// {

//     do
//     {

//         Console.Write(message);

//         if (int.TryParse(Console.ReadLine(), out int number))
//         {

//             if (number > 0)
//                 return number;
//             Console.WriteLine("ошибка");
//         }
//         else
//         {
//             Console.WriteLine("ошибка");
//         }
//     } while (true);
// }

// static int Sum(int a, int b)
// {
//     return a + b;
// }
// калькулятор 
static void Main()
{
    while (true)
    }