/*
НАйти максимальное число из 9 цифр
*/

int Max(int arg1, int arg2, int arg3)   // Создали функцию, которая отвечает за поиск из 3-х
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int numberOne = 10;
int numberTwo = 100;
int numberThree = 99;
int numberFour = 50;
int numberFive = 101;
int numberSix = 15;
int numberSeven = 61;
int numberEight = 1001;
int numberNine = 1050;

// int max1 = Max(numberOne, numberTwo, numberThree);
// int max2 = Max(numberFour, numberFive, numberSix);
// int max3 = Max(numberSeven, numberEight, numberNine);
// int max = Max(max1, max2, max3);
int max = Max(Max(numberOne, numberTwo, numberThree),  // внутри аргумента, передали функцию
            Max(numberFour, numberFive, numberSix),
            Max(numberSeven, numberEight, numberNine));

System.Console.WriteLine(max);

/* Старый вариант записи
int max = numberOne;
if (numberTwo > max) max = numberTwo;
if (numberThree > max) max = numberThree;
if (numberFour > max) max = numberFour;
if (numberFive > max) max = numberFive;
if (numberSix > max) max = numberSix;
if (numberSeven > max) max = numberSeven;
if (numberEight > max) max = numberEight;
if (numberNine > max) max = numberNine;
*/
