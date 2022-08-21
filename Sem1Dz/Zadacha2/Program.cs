// ЗАДАЧА 2
// Виталий, если я правильно понимаю условия задачи, то числа необходимо вводить в терминал

// Если условия указаны как в описании задачи то, тогда будет так
// int numberA = 5; // 2, -9
// int numberB = 7; // -9, -3
// if(numberA > numberB)
// {
//     Console.Write("max = ");
//     Console.Write(numberA);
// }
// else
// {
//     Console.Write("max = ");
//     Console.Write(numberB);
// }

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("max = ");
    Console.Write(numberA);
    Console.Write(" min = ");
    Console.Write(numberB);
}
else
{
    Console.Write("max = ");
    Console.Write(numberB);
    Console.Write(" min = ");
    Console.Write(numberA);
}

