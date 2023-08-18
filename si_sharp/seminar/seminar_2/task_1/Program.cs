/*
Напишите программу, которая вводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа. [] обозначают что от 10 до 99 включительно.
Например:
78 -> 8
12 -> 2
85 -> 8
*/

Random rand = new Random();

int number = rand.Next(10, 100);

int numberOne = number / 10;
int numberTwo = number % 10;

// int max = numberOne;
// if (numberTwo > max) max = numberTwo;
int answer = numberOne > numberTwo ? numberOne : numberTwo;   //тернарный оператор

System.Console.WriteLine($"Рандомное число {number}");
System.Console.WriteLine($"Первое число {numberOne}");
System.Console.WriteLine($"Второе число {numberTwo}");
// System.Console.WriteLine($"Максимальное число {max}");
System.Console.WriteLine($"Максимальное число {answer}");
