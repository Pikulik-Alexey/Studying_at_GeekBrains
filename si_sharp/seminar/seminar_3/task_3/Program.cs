﻿/*
Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
5 => 1,4,9,16,25
2=>1,4
*/

int RandomNumber(int min, int max)
{
    int result = new Random().Next(min, max + 1);
    return result;
}

void Print(string text)
{
    System.Console.WriteLine(text);
}

void GetSquare(int rand)
{
    for (int i = 1; i <= rand; i++)
    {
        System.Console.Write($"{Math.Pow(i, 2)} ");
    }
}

int rand = RandomNumber(1, 10);
Print($"{rand}");
GetSquare(rand);
