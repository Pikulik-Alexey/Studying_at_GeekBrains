
// void Print(int value)
// {
//     System.Console.WriteLine(value);
//     Print(value + 1);
// }
// Print(1);


// void Print(int value)    // Прямая рекурсия
// {
//     System.Console.WriteLine(value);
//     if (value < 5) Print(value + 1);
// }
// Print(1);


// void Print(int value)    // Обратная рекурсия
// {
//     if (value < 5) Print(value + 1);
//     System.Console.WriteLine(value);
// }
// Print(1);


// int SimDig(int number)
// {
//     if (number == 0) return 0;
//     return number % 10 + SimDig(number / 10);  // SumDig(4) (4 + SumDig(0))
// }
// System.Console.WriteLine(SimDig(45));

/* 
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
N = 5 -> "1, 2, 3, 4, 5" 
N = 6 -> "1, 2, 3, 4, 5, 6" 
*/
/*
string ReturnRealDigits(int startNum, int number)
{
    if (startNum == number) return startNum.ToString();
    return startNum + " " + ReturnRealDigits(startNum + 1, number); // " " для преобразования всего рядом в string 
}
Console.Clear();
Console.WriteLine(ReturnRealDigits(1, 5));
*/

/* 
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
M = 1; N = 5 -> "1, 2, 3, 4, 5" 
M = 4; N = 8 -> "4, 5, 6, 7, 8" 
*/
/* 
string ReturnRealDigits(int number, int startNum){ 
    if(startNum == number) return startNum.ToString(); 
    return startNum + " " + ReturnRealDigits(number, startNum+1); 
} 
Console.Clear(); 
Console.WriteLine(ReturnRealDigits(5,3));
*/

/* 
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии. 
A = 3; B = 5 -> 243 (3⁵) 
A = 2; B = 3 -> 8 
*/
/* 
int GetPowNumber (int number, int pow){ 
    if(pow == 0) return 1;  
        return number * GetPowNumber(number, pow-1); 
} 
Console.Clear(); 
Console.WriteLine(GetPowNumber(3,1));
*/

/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

Console.WriteLine("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

void Print(int m, int n)
{
    Console.WriteLine(m);
    if (m < n) Print(m + 1, n);
}
Print(m, n);


/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
/*
Console.WriteLine("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int Print(int m, int n){
    if(n == 0) return 1;
    return m * Print(m, n-1);
}
Console.WriteLine(Print(m, n));
*/

