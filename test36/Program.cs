// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
        if (i % 7 == 0 && i != 0)
            Console.WriteLine();
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

void QtEven(int[] array, int[] outarr)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            outarr[0]++;
        else
            outarr[1]++;
    }
}

int[] array = new int[20];
while (IsExit())
{
    int[] outarr = { 0, 0 };
    FillRandArray(array, 100, 999);
    PrintArray(array);
    Console.WriteLine();
    QtEven(array, outarr);
    Console.WriteLine($"Четных чисел {outarr[0]} нечетных чисел {outarr[1]}");
}
