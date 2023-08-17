/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int SumRes(int m, int n)
{
    int res = 0;
    if (m == n) return 0;
    else
    {
        m++;
        res = m + SumRes(m, n);
        return res;
    }
}

void Print(int m, int n)
{
    Console.Write(SumRes(m - 1, n));
}

Print(m, n);
