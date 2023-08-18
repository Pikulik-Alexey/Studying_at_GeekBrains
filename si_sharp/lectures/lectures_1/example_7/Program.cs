int numberOne = 1;
int numberTwo = 10;
int numberThree = 8;
int numberFour = 16;
int numberFive = 30;
int max = 0;
// int max = numberOne;

// if (numberOne > max) max = numberOne;
// if (numberTwo > max) max = numberTwo;
// if (numberThree > max) max = numberThree;
// if (numberFour > max) max = numberFour;
// if (numberFive > max) max = numberFive;

if (max < numberOne)
{
    max = numberOne;
}
if (max < numberTwo)
{
    max = numberTwo;
}
if (max < numberThree)
{
    max = numberThree;
}
if (max < numberFour)
{
    max = numberFour;
}
if (max < numberFive)
{
    max = numberFive;
}
Console.Write("max = ");
Console.WriteLine(max);
