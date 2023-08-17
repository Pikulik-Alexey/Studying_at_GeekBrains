/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
// 

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

int[,] CreateArray2(int row, int col, int min, int max)
{
    Random rand = new Random();
    int[,] array2 = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array2[i, j] = rand.Next(min, max + 1);
        }
    }
    return array2;
}



void ProductMatrices(int[,] array, int[,] array2, int[,] sumMatrix)
{
    for (int i = 0; i < sumMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sumMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum += array[i, k] * array2[k, j];
            }
            sumMatrix[i, j] = sum;
        }
    }
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

int[,] array = CreateArray(3, 4, 0, 10);
int[,] array2 = CreateArray2(3, 4, 0, 10);
int[,] sumMatrix = new int[3, 4];
PrintArray(array);
System.Console.WriteLine();
PrintArray(array2);
System.Console.WriteLine();
ProductMatrices(array, array2, sumMatrix);
PrintArray(sumMatrix);
