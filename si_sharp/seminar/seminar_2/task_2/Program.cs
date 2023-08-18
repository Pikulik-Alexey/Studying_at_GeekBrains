/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98
*/

int GetNumber(int number)  //используются глаголы для методов, заменить, дай
{

    System.Console.Write(number + " => ");
    int numberOne = number / 100;
    int numberThree = number % 10;
    int result = (numberOne * 10 + numberThree);
    return result;
}

int numberRand = new Random().Next(100, 1000);
int result = GetNumber(numberRand);
System.Console.WriteLine(result);

// void Number()
// {
//     Random rand = new Random();
//     int number = rand.Next(100, 1000);
//     int numberOne = number / 100;
//     int numberThree = number % 10;
//     int result = (numberOne * 10 + numberThree);
//     System.Console.WriteLine(number);
//     System.Console.WriteLine(result);
// }

// Number();


// Random rand = new Random();

// int number = rand.Next(100, 1000);
// int numberOne = number / 100;
// int numberThree = number % 10;
// int result = (numberOne * 10 + numberThree);

// System.Console.WriteLine(number);
// System.Console.WriteLine(result);
