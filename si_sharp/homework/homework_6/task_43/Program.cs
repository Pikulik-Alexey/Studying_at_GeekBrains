/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void Print(string text)
{
    System.Console.WriteLine(text);
}

double FindX(int b1, int k1, int b2, int k2)
{
    double resultX = (b2 - b1) / (k1 - k2);
    return resultX;
}
double FindY(int b1, int k1, int b2, int k2, double resultX)
{
    double resultY = k1 * resultX + b1;
    return resultY;
}
int GetIntNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Print("Введите значение b1");
int b1 = GetIntNum();
Print("Введите значение k1");
int k1 = GetIntNum();
Print("Введите значение b2");
int b2 = GetIntNum();
Print("Введите значение k2");
int k2 = GetIntNum();

double resultX = FindX(b1, k1, b2, k2);
double resultY = FindY(b1, k1, b2, k2, resultX);

Print($"Прямые пересекутся в точке {resultX}, {resultY}");
