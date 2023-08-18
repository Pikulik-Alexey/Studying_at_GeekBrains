Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "alex")
{
    Console.Write("Привет, это же красавчик Лекс");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

