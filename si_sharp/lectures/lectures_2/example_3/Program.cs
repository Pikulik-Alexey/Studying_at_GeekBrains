int[] array = { 1, 5, 3, 7, 8, 9, 10, 11, 20 };
int n = array.Length;
int find = 10;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}
