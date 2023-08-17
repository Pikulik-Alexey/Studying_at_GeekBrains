/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void Print(string text)
{
    System.Console.WriteLine(text);
}

double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return result;
}
int GetIntNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Print("Введите координату x1");
int x1 = GetIntNum();
Print("Введите координату y1");
int y1 = GetIntNum();
Print("Введите координату z1");
int z1 = GetIntNum();
Print("Введите координату x2");
int x2 = GetIntNum();
Print("Введите координату y2");
int y2 = GetIntNum();
Print("Введите координату z2");
int z2 = GetIntNum();

double result = FindDistance(x1, y1, z1, x2, y2, z2);
Print($"Расстояние между точками {(x1, y1, z1)} и {(x2, y2, z2)} равно {result}");
