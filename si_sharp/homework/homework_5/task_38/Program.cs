/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        // array[i] = rand.Next(min, max + 1) + rand.NextDouble();
        array[i] = Convert.ToDouble(rand.Next(min, max + 1)) / 100;
    }
    return array;
}

string Print(double[] array)
{
    return string.Join(", ", array);
}

double FindMaxMin(double[] array)
{
    double max = 0;
    double min = 0;
    double diff = 0;
    foreach (double el in array)
    {
        max += el > 0 ? el : 0;
        min += el < 0 ? el : 0;
        diff = max - min;
    }
    // return (max: max, min: min);
    return diff;
}

double[] array = CreateArray(5, -10000, 10000);
System.Console.WriteLine($"Массив [{Print(array)}]");

var tuple = FindMaxMin(array);
System.Console.WriteLine($"Разница равна {tuple}");

