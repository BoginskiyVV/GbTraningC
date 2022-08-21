// Напишите программу, которая на вход принимает число (N),
//а на выходе показывает чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int [N];
int num = 1;

Console.Write("Чётные числа от 1 до ");
Console.Write(N);
Console.Write(": ");
Console.WriteLine(" ");

while (num < N) // в задаче непонятно включая число N? Если да, то знак ставим <=
{
    if (num % 2 == 0)
    {
        Console.WriteLine(num);
    }
    num++;
}