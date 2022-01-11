// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
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

int SumElements(int[] array, bool flag)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (flag)
        {
            if (array[i] > 0)
                result += array[i];
        }
        else
        {
            if (array[i] < 0)
                result += array[i];
        }
    }
    return result;
}

int[] array = new int[12];
while (IsExit())
{
    FillRandArray(array, -9, 9);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных элементов {SumElements(array, true)}");
    Console.WriteLine($"Сумма отрицательных элементов {SumElements(array, false)}");
}
