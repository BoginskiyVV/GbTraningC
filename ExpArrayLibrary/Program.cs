// Поиск индекса массива с использованием методов и генератора псевдослучайных чисел

void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while(index < length)
    {
        numbers[index] = new Random().Next(1, 10);

        index++;
    }
}

void PrintArray(int[] num)
{
    int count = num.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(num[position]);
        position++;
    }
}

int IndexOf(int[] numbers, int find)
{
    int count = numbers.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(numbers[index] == find)
        {
            position = index;
            break;

        }
        index++;
    }
    return position;
}

int[] array = new int [10]; // создать массив в котором 10 элементов

FillArray(array);
array [4] = 4;
array [6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
