// Задать двумерный массив следующим правилом: Aₘₙ = m+n
using static System.Console;

int[,] CreateTwoDimensionArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = i + j;
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

int[,] arrayTwoDimension = CreateTwoDimensionArray(10, 8);
PrintTwoDimensionArray(arrayTwoDimension);