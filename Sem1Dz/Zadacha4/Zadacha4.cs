// Задача 4. Напишие программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;

if (B > max)
{
    max = B;
}
if (C > max)
{
    max = C;
}
Console.Write("max = ");
Console.Write(max);