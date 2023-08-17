/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите чило => ");
int number = Convert.ToInt32(Console.ReadLine());
// Console.Write(number % 2);
// double remainder = number % 2;

if (number % 2 == 1)
{
    Console.Write($"Число {number} является НЕчетным");
}
else
{
    Console.Write($"Число {number} является четным");
}


