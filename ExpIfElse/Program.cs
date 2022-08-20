Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "анна")
{
    Console.WriteLine("Привет и хорошего дня!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}