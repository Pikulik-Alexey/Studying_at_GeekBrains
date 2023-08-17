/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите число A => ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B => ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

bool ValidateNumberTwo(int numberTwo)
{
    if (numberTwo < 0)
    {
        System.Console.WriteLine("Число B не может быть меньше 0");
        return false;
    }
    return true;
}

int GetNumber(int numberOne, int numberTwo)
{
    int result = 1;
    for (int i = 1; i <= numberTwo; i++)
    {
        result *= numberOne;
    }
    return result;
}

ValidateNumberTwo(numberTwo);
int sumResult = GetNumber(numberOne, numberTwo);
System.Console.WriteLine($" Число {numberOne} в степени {numberTwo} равно {sumResult}");
