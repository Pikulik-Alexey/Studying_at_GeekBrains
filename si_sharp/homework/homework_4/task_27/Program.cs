/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetIntNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int FindSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

void Print(string text)
{
    System.Console.Write(text);
}

Print("Введите число ");
int number = GetIntNum();
int result = FindSum(number);
FindSum(number);
Console.WriteLine($"Сумма цифр {number} равна = {result}");
