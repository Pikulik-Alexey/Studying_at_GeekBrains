/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateArray(int row, int col, int min, int max)
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

void GiveSmallestString(int[,] array)
{
    int sumEl = 0;
    int minLine = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sumEl += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < sumEl)
        {
            sumEl = sumRow;
            minLine = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов => {minLine + 1}, сумма этих элементов равна {sumEl}");
}

void PrintArray(int[,] array)
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

int[,] array = CreateArray(4, 4, 0, 10);
PrintArray(array);
System.Console.WriteLine();
GiveSmallestString(array);

