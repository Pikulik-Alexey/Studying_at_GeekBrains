/*
Напишите программу, которая будет принримать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

Console.Write("Введите первое число => ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число => ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int result = numberOne % numberTwo;
if (result == 0)
{
    System.Console.WriteLine($"Число {numberOne} кратно числу {numberTwo}");
}
else
{
    System.Console.WriteLine($"Число {numberOne} не кратно числу {numberTwo}, остаток {result}");
}

