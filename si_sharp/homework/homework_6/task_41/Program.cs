/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] CreateArray(int elCount)
{
    int[] array = new int[elCount];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

string Print(int[] array)
{
    return string.Join(", ", array);
}
int sum = 0;
int FindPos(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}


System.Console.Write("Введите количество элементов массива: \t");
int elCount = int.Parse(Console.ReadLine());
int[] array = CreateArray(elCount);
System.Console.WriteLine($"Массив [{Print(array)}]");

int pos = FindPos(array);
System.Console.WriteLine($"В массиве [{Print(array)}] чисел больше 0 равно {pos}");
