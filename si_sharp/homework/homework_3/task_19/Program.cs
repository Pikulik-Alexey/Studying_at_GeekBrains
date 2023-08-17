/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите число пятизначное ");
int num = Convert.ToInt32(Console.ReadLine());
int a, b, c, d, e;

// void Print(string text)
// {
//     System.Console.WriteLine(text);
// }

void IsPalindrom(int num)
{
    if (num > 0 && num < 10)
    {
        Console.Write($"Число {num} является палиндромом.");
    }
    else if (num >= 10 && num < 100)
    {
        a = num / 10;
        b = num % 10;
        if (a == b)
        {
            Console.Write($"Число {num} является палиндромом.");
        }
        else
        {
            Console.Write($"Число {num} не является палиндромом.");
        }
    }
    else if (num >= 100 && num < 1000)
    {
        a = num / 100;
        b = num % 100 / 10;
        c = num % 10;
        if (a == c)
        {
            Console.Write($"Число {num} является палиндромом.");
        }
        else
        {
            Console.Write($"Число {num} не является палиндромом.");
        }
    }
    else if (num >= 1000 && num < 10000)
    {
        a = num / 1000;
        b = num % 1000 / 100;
        c = num % 100 / 10;
        d = num % 10;
        if (a == d && b == c)
        {
            Console.Write($"Число {num} является палиндромом.");
        }
        else
        {
            Console.Write($"Число {num} не является палиндромом.");
        }
    }
    else if (num >= 10000 && num < 100000)
    {
        a = num / 10000;
        b = num % 10000 / 1000;
        c = num % 1000 / 100;
        d = num % 100 / 10;
        e = num % 10;
        if (a == e && b == d)
        {
            Console.Write($"Число {num} является палиндромом.");
        }
        else
        {
            Console.Write($"Число {num} не является палиндромом.");
        }
    }
}

// Print($"{num}");
IsPalindrom(num);
