/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// int Number(int number)
// {
//     int result = new Random().Next(min, max + 1);
//     return result;
// }

int power = 3;
Console.Write("Введите чило ");
int number = Convert.ToInt32(Console.ReadLine());

void Print(string text)
{
    System.Console.WriteLine(text);
}

void GetCube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        System.Console.Write($"{Math.Pow(i, power)} ");
    }
}

Print($"{number}");
GetCube(number);
