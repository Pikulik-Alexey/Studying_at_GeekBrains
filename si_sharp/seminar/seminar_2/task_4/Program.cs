/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
14 => нет
46 => нет
161 => да
*/

// Console.Write("Введите число => ");
// int numberOne = Convert.ToInt32(Console.ReadLine());

// if (numberOne % 7 == 0 && numberOne % 23 == 0)
// {
//     System.Console.WriteLine($"Число {numberOne} кратно");
// }
// else
// {
//     System.Console.WriteLine($"Число {numberOne} не кратно");
// }


bool IsMultiplicity(int numberOne)
{
    if (numberOne % 7 == 0 && numberOne % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите число => ");
int numberOne = Convert.ToInt32(Console.ReadLine());
bool result = IsMultiplicity(numberOne);
System.Console.WriteLine(result);
