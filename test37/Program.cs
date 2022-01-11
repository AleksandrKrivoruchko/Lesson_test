// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
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
    Console.WriteLine();
}

bool IsExit()
{
    Console.WriteLine("Введите q для завершения, для продолжения нажмите Enter");
    string index = Console.ReadLine() ?? string.Empty;
    if (index == "q")
        return false;
    return true;
}

int IsTheRange(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
            result++;
    }
    return result;
}

int[] array = new int[123];
while (IsExit())
{
    FillRandArray(array, 0, 200);
    PrintArray(array);
    Console.WriteLine();
    int result = IsTheRange(array);
    Console.WriteLine($"Количество чисел из диапазона [10, 99] - {result}");
}
