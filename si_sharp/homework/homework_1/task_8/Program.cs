﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите чило => ");
int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= number; i++)
// {
//     Console.Write(i);
// }

int count = 2;

while (count <= number)
{

    Console.Write(count);
    count += 2;
}
