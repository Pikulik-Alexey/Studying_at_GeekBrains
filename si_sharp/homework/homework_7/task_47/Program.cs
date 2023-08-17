/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] CreateArray(int row, int col, int min, int max)
{
    Random rand = new Random();
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = Math.Round(rand.Next(min, max + 1) * 1.1, 1);
        }
    }
    return array;
}




void PrintArray(double[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
double[,] array = CreateArray(3, 4, -100, 100);
PrintArray(array);
// Console.WriteLine();
// array = ChangeRows(array);
// PrintArray(array);
