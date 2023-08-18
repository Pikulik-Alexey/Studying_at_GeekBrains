/* Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)
Например 
4 -> 16
3 -> 9
*/

Console.Write("Введите чило ");
int number = Convert.ToInt32(Console.ReadLine());
int power = 2;
int squareNumber = (int)(Math.Pow(number, power));/*Convert.ToInt32(Math.Pow(number, 2));*//*number * number;*/
Console.Write($"Квадрат числа {number} равен {squareNumber}");
