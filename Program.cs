// Шаг 1.
// PrintLine();
// Console.WriteLine("Отчёт");
// PrintLine();

//Задание 1. 
// PrintHeader("Заголовок 1");
// PrintHeader("Заголовок 2");

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


//Задание 2.1.
// Console.WriteLine($"Большее между 3 и 7: {Max(3, 7)}, Большее между 8 и 4: {Max(8, 4)}, Большее между 2 и 0: {Max(2, 0)}");

static int Max(int a, int b)
{
    return (a > b) ? a : b;
} 

//Задание 2.2.
// Console.WriteLine($"Число 4 чётное: {IsEven(4)}, Число 7 чётное : {IsEven(7)}, Число 0 чётное : {IsEven(0)}");

// static bool IsEven(int n)
// {
//     return (n % 2 == 0) ? true : false;
// }

//Задание 3.
// int[] arr = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine($"Среднее: {Average(arr)}, Элементов больше 100: {CountGreater(arr, 100)}");

// static double Average(int[] arr)
// {
//     double sum = 0;
//     foreach (int x in arr)
//     {
//         sum += x;
//     }
//     return sum / arr.Length;
// }

//Задание 4.
// Console.WriteLine($"0 градусов в фаренгейтах: {ToFahrenheit(0)}, 100 градусов в фаренгейтах: {ToFahrenheit(100)}, 37 градусов в фаренгейтах: {ToFahrenheit(37)}");

// static double ToFahrenheit(double celsius)
// {
//     double f = celsius * 9 / 5 + 32;
//     return f;
// }

//Задание 5.
// Console.WriteLine($"Факториал 5: {Factorial(5)}");
// Console.Write("Простые числа от 2 до 50: ");
// for (int i = 2; i <= 50; i++)
// {
//     if (IsPrime(i)) 
//     {
//         Console.Write(i + " ");
//     }
// }

static long Factorial(int n)
{
    int f = 1;
    for (int i = 1; i <= n; i++)
    {
        f *= i;
    }
    return f;
}

// static bool IsPrime(int n)
// {
//     for (int i = 2; i < n; i++)
//     {
//         if (n % i == 0)
//         {
//             return false;
//         }
//     }
//     return true;
// }

//Задание 6.
// int num1 = ReadPositive("введите 1е число:");
// int num2 = ReadPositive("введите 2е число:");
// Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

// static int ReadPositive(string message)
// {
//     int num = 0;
//     do
//     {
//         Console.WriteLine(message);
//         num = int.Parse(Console.ReadLine());
//     }
//     while (num <= 0);
//     return num;
// }

//Итоговая задача. «Меню-калькулятор»
Console.WriteLine("1 — сумма двух чисел");
Console.WriteLine("2 — большее из двух чисел");
Console.WriteLine("3 — факториал");
Console.WriteLine("0 — выход");
int choice = 7;
while (choice != 0)
{
    Console.Write("Выберите действие(0-3): ");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.Write("Введите числа: ");
            Console.WriteLine($"Сумма чисел: {Sum(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()))}");
            break;
        case 2:
            Console.Write("Введите числа: ");
            Console.WriteLine($"Большее: {Max(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()))}");
            break;
        case 3:
            Console.Write("Введите число: ");
            Console.WriteLine($"Факториал: {Factorial(int.Parse(Console.ReadLine()))}");
            break;
        case 0:
        Console.WriteLine("Досвидания!");
            break;
        default:
            Console.WriteLine("Нет такого пункта");
            break;
    }
}

static int Sum(int a, int b)
{
    return a + b;
}