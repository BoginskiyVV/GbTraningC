// Поиск индекса массива по значению

int[] array = { 11, 27, 36, 94, 50, 76, 48, 83, 27, 94 };

int n = array.Length;
int find = 94;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // остановит поиск на 1ом найденом индексе, 2ой надо ее отключить
    }
    index++;
}