/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// Console.WriteLine("Введите первое число: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// void Print(int m, int n)
// {
//     if (m > n) Print(m, n + 1);
//     System.Console.Write($"{n} ");
// }
// Print(m, n);

void Print(int n)    // Обратная рекурсия
{
    if (n < 8) Print(n + 1);
    System.Console.Write($"{n} ");
}
Print(1);
