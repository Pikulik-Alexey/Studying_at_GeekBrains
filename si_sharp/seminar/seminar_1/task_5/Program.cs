/*
Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.Write("Введите чило => ");
double number = Convert.ToDouble(Console.ReadLine());
Console.Write(number % 10);
