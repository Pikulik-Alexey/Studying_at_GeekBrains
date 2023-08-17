/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите от 1 до 7 число => ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("Понедельник не является выходным");
        break;
    case 2:
        Console.WriteLine("Вторник не является выходным");
        break;
    case 3:
        Console.WriteLine("Среда не является выходным");
        break;
    case 4:
        Console.WriteLine("Четверг не является выходным");
        break;
    case 5:
        Console.WriteLine("Пятница не является выходным");
        break;
    case 6:
        Console.WriteLine("Суббота является выходным");
        break;
    case 7:
        Console.WriteLine("Воскресенье является выходным");
        break;
    default:
        Console.WriteLine("Вы ввели неправильное число из диапазона 1 -7");
        break;
}

