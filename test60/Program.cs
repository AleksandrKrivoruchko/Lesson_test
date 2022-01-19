// Составить частотный словарь элементов двумерного массива
using static System.Console;

int[,] CreateTwoDimensionArray(int row, int column, int min, int max)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = rnd.Next(min, max);
    return result;
}

void PrintTwoDimensionArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Write($"{array[i, j]}\t");
        WriteLine();
    }
    WriteLine();
}

bool IsFindElement(int[,] array, int[] elementArray)
{
    for (int i = ++elementArray[1]; i < array.GetLength(0); i++)
        for (int j = ++elementArray[2]; j < array.GetLength(1); j++)
            if (array[i, j] == elementArray[0])
            {
                elementArray[1] = i;
                elementArray[2] = j;
                return true;
            }
    return false;
}
