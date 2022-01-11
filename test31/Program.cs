// Задать массив из 8 элементов и вывести их на экран

int[] array = new int[8];

void RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
    Console.WriteLine();
}

RandomArray(array);
PrintArray(array);