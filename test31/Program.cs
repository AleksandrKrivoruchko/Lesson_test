// Задать массив из 8 элементов и вывести их на экран 

void FillRandArray(int[] array, int start, int end)
{
    Random randValue = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randValue.Next(start, end);
    }
}

void PrintArray(int[] array)
{
    int k = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i],7}");
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

int[] array = new int[20];
while (IsExit())
{
    FillRandArray(array, -10, 10);
    PrintArray(array);
    Console.WriteLine();
}
