// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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

void ProductOfPairs(int[] array)
{
    int i = 0;
    int k = 1;
    int marker = array.Length / 2;
    int product = 1;
    int len = array.Length - 1;
    while (i < marker)
    {
        product = array[i] * array[len - i];
        Console.Write($"{product}\t");
        if (k % 7 == 0)
            Console.WriteLine();
        k++;
        i++;
    }
    Console.WriteLine();
    if (len % 2 == 0)
        Console.WriteLine($"Элемент без пары {array[i]} с индексом {i}");
}

bool IsExit()
{
    Console.WriteLine("Введите q для завершения, для продолжения нажмите Enter");
    string index = Console.ReadLine() ?? string.Empty;
    if (index == "q")
        return false;
    return true;
}

int[] array = new int[71];
while (IsExit())
{
    FillRandArray(array, 0, 10);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine();
    ProductOfPairs(array);
}
