/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

string Print(int[] array)
{
    return string.Join(", ", array);
}

int sum = 0;

int FindOdd(int[] array)
{
    for (int i = 0; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}


int[] array = CreateArray(5, -30, 99);
System.Console.WriteLine($"Массив [{Print(array)}]");
int odd = FindOdd(array);
System.Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {odd}");
