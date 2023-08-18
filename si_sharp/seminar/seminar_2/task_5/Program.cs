/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5,25 => да
-4,16 => да
25,5 => да
8,9 => нет
*/

bool IsMultiplicity(int numberOne, int numberTwo)
{
    int power = 2;
    if (numberOne == Convert.ToInt32(Math.Pow(numberTwo, power)) || numberTwo == Convert.ToInt32(Math.Pow(numberOne, power)))
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите первое число => ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число => ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

bool result = IsMultiplicity(numberOne, numberTwo);
System.Console.WriteLine(result);