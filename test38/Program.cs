// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillRandArray(int[] array, int start, int end)
{
    Random randValue = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randValue.Next(start, end + 1);
    }
}

void PrintArray(int[] array)
{
    int k = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
        if (k % 7 == 0)
            Console.WriteLine();
        k++;
    }
}

bool IsExit()
{
    Console.WriteLine("Введите q для завершения, для продолжения нажмите Enter");
    string index = Console.ReadLine() ?? string.Empty;
    if (index == "q")
        return false;
    return true;
}

int SumUnevenIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

int[] array = new int[20];
while (IsExit())
{
    FillRandArray(array, 0, 10);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов с нечетными индексами {SumUnevenIndex(array)}");
}
