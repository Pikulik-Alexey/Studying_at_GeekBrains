/*
Напишите программу, которая принимает координаты двух точек и находит расстояние между ними в 2D пространстве
X(3,6) Y(2,1) =>5,09
X(7,-5) Y(1,-1) =>7,21
*/

void Print(string text)
{
    System.Console.WriteLine(text);
}

double FindDistance(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
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
Print("Введите координату x2");
int x2 = GetIntNum();
Print("Введите координату y2");
int y2 = GetIntNum();

double result = FindDistance(x1, y1, x2, y2);
Print($"Расстояние между точками {(x1, y1)} и {(x2, y2)} равно {result}");
