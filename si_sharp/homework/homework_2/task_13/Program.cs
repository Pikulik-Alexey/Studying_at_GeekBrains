/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
    else
    {
        return true;
    }
}

int GetNumber(int number)
{
    if (number > 999)
    {
        number /= 10;
    }
    if (number > 9999)
    {
        number /= 100;
    }
    if (number > 99999)
    {
        number /= 1000;
    }
    return number % 10;
}

Console.Write("Введите чило => ");
int number = Convert.ToInt32(Console.ReadLine());
ValidateNumber(number);
int result = GetNumber(number);
System.Console.WriteLine(result);

