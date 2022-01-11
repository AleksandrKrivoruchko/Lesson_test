// Определить, присутствует ли в заданном массиве, некоторое число
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

bool MyInput(string msg, out int value)
{
    Console.Write(msg);
    string answer = Console.ReadLine() ?? string.Empty;
    return int.TryParse(answer, out value);
}

bool IsThere(int[] array, int element)
{
    foreach (int elem in array)
    {
        if (elem == element)
            return true;
    }
    return false;
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
    FillRandArray(array, -20, 20);
    PrintArray(array);
    Console.WriteLine();
    int element = 0;
    if (MyInput("Введите число: ", out element))
    {
        if (IsThere(array, element))
            Console.WriteLine($"Число {element} есть в массиве");
        else
            Console.WriteLine($"Этого числа {element} в массиве нет");
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
