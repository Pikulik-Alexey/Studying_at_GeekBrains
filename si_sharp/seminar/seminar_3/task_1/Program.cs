/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причем X=/0 и Y =/0 и выдает номер четверти плоскости, в которой находится эта точка.
*/

string data = "data";
string error = "error";
string result = "result";

void Print(string text, string arg)
{
    switch (arg)
    {
        case "data":
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case "result":
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case "error":
            Console.ForegroundColor = ConsoleColor.Red;
            break;
    }
    System.Console.WriteLine(text);
    Console.ResetColor();
}

void FindQuarter(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Print("Одна или обе координаты равны 0", error);
    }
    else
    {
        switch ((x, y))
        {
            case ( > 0, > 0):
                Print("Первая четверть", result);
                break;
            case ( < 0, > 0):
                Print("Вторая четверть", result);
                break;
            case ( < 0, < 0):
                Print("Третья четверть", result);
                break;
            case ( > 0, < 0):
                Print("Четвертая четверть", result);
                break;
        }
    }
}

//Функция которая запрашивает ввод данных и возвращает значение
int GetIntNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


Print("Введите координату X", data);
int coordinateX = GetIntNum();
Print("Введите координату Y", data);
int coordinateY = GetIntNum();

// Print($"Координата X = {coordinateX}, координата Y = {coordinateY}", data);

FindQuarter(coordinateX, coordinateY);
