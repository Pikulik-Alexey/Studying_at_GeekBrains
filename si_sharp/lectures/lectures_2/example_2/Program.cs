/*
Работа с массивом
*/

int Max(int arg1, int arg2, int arg3)   // Создали функцию, которая отвечает за поиск из 3-х
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0  1  2  3  4  5  6  7  8
int[] array = { 1, 200, 3, 4, 5, 6, 7, 8, 9, };
// array[0] = 12;
// System.Console.WriteLine(array[0]);

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
System.Console.WriteLine(result);

// int max = Max(Max(numberOne, numberTwo, numberThree),  // внутри аргумента, передали функцию
//             Max(numberFour, numberFive, numberSix),
//             Max(numberSeven, numberEight, numberNine));

// System.Console.WriteLine(max);
