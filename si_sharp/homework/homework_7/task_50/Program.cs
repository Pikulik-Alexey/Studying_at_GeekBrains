/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FindEl(int[,] matr)
{
    if (pos1 < 0 | pos1 > matr.GetLength(0) - 1 | pos2 < 0 | pos2 > matr.GetLength(1))
    {
        Console.WriteLine("Элемент не существует  ");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", matr[pos1, pos2]);
    }
}

void FillArray(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
}

int[,] matrix = new int[5, 5];
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);
FindEl(matrix);
