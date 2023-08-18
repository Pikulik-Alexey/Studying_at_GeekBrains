/*
Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9;9]. Найдите сумму отрицательных и положительных элементов массива.
Например [3.9.-8.1.0.-7.2.-1.8.-3.-1.6] сумма полож. 29, отриц. -20
*/

Console.Clear();

int[] CreateArray(int size, int min, int max) // метод который создает и заполняет массив
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

string Print(int[] array)   // метод который возвращает строку и выводит на печать
{
    return string.Join(", ", array);
}

(int sumNegName, int sumPosName) FindNegPos(int[] array)  //метод кортеж с именованными параметрами
{
    int sumNeg = 0;
    int sumPos = 0;
    foreach (int el in array)
    {
        sumPos += el > 0 ? el : 0;
        sumNeg += el < 0 ? el : 0;
    }
    return (sumNegName: sumNeg, sumPosName: sumPos);
}

int[] array = CreateArray(12, -9, 9);
System.Console.WriteLine($"Массив [{Print(array)}]");

var tuple = FindNegPos(array);
System.Console.WriteLine(tuple.Item1);
System.Console.WriteLine($"Сумма отрицательных {tuple.sumNegName} и сумма положетельных {tuple.sumPosName}");
