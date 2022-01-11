// Написать программу замену элементов массива на противоположные
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
        if (i % 7 == 0)
            Console.WriteLine();
    }
}

void ChangeElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
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

int[] array = new int[20];
while (IsExit())
{
    FillRandArray(array, -9, 9);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine();
    ChangeElements(array);
    PrintArray(array);
    Console.WriteLine();
}
