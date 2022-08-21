// Напишите программу, которая на вход принимает число и выдаёт, является ли 
// число чётным, (делится без остатка)

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ostatokOtDeleniya = 0;

ostatokOtDeleniya = number % 2;

if(ostatokOtDeleniya == 0)
{
    Console.Write("Число ");
    Console.Write(number);
    Console.Write(" является чётным числом");
}
else
{
    Console.Write("Число ");
    Console.Write(number);
    Console.Write(" является не чётным");
}