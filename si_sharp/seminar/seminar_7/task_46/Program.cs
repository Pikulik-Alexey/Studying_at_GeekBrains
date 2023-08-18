/*
Задача 46. Задайте двумерный массив размером m*n, заполненный случайными целыми числами.
m=3, n=4
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

int[,] CreateArray(int row, int col, int min, int max) // метод создает и заполняет рандомными числами массив двумерный
{
    Random rand = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array = CreateArray(5, 5, -99, 99);
PrintArray(array);
