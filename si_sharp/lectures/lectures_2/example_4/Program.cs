void FillArray(int[] collection) //метод, который наполняет массив

{
    int length = collection.Length; //длина массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col) //метод, который печает массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  // если элемента нет, то будет -1, то етсь такого элемента нет
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; //созаем новый массив, в котором будет 10 элементов

FillArray(array);
array[4] = 4; //принудительно добавили 4
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);
