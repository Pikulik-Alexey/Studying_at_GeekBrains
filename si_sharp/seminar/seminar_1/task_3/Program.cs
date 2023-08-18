/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.Write("Введите от 1 до 7 число => ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.Write($"Число {number} является днем недели понедельник");
}
else if (number == 2)
{
    Console.Write($"Число {number} является днем недели вторник");
}
else if (number == 3)
{
    Console.Write($"Число {number} является днем недели среда");
}
else if (number == 4)
{
    Console.Write($"Число {number} является днем недели четверг");
}
else if (number == 5)
{
    Console.Write($"Число {number} является днем недели пятница");
}
else if (number == 6)
{
    Console.Write($"Число {number} является днем недели суббота");
}
else if (number == 7)
{
    Console.Write($"Число {number} является днем недели воскресенье");
}
else
{
    Console.Write($"Ну я же просил, указывать число в пределах от 1 до 7");
}


// Console.Write("Введите число => ");
// int number = Convert.ToInt32(Console.ReadLine());
// Dictionary<int, string> map = new Dictionary<int, string>()
// {
//     {1, "Понедельник"},
//     {2, "Вторник"},
//     {3, "Среда"},
//     {4, "Четверг"},
//     {5, "Пятница"},
//     {6, "Суббота"},
//     {7, "Воскресенье"},
// };
// if (number > 0 && number < 8)
// {
//     Console.Write(map[number]);
// }
// else
// {
//     Console.Write("Ошибка");
// }
