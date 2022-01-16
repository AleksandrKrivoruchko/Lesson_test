using static System.Console;
// Написать программу копирования массива
int[] CreateArray(int lengthArray, int min, int max)
{
    int[] result = new int[lengthArray];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
        result[i] = rnd.Next(min, max);
    return result;
}

int[] ReplicationArray(int[] sourceArray)
{
    int[] resultArray = new int[sourceArray.Length];
    for (int i = 0; i < sourceArray.Length; i++)
        resultArray[i] = sourceArray[i];
    return resultArray;
}

void PrintArray(int[] array)
{
    int k = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}\t");
        if (k % 8 == 0)
            WriteLine();
        k++;
    }
    WriteLine();
}

Clear();
int[] sourceArray = CreateArray(20, 1, 10);
PrintArray(sourceArray);
WriteLine();
int[] copyArray = ReplicationArray(sourceArray);
PrintArray(copyArray);