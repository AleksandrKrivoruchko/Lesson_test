// Написать программу, которая обменивает элементы первой строки и последней строки
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

void ExchangeRows(int[,] array)
{
    int indexLastLine = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[indexLastLine, i];
        array[indexLastLine, i] = temp;
    }
}

int[,] array = CreateTwoDimensionArray(4, 5, 0, 100);
PrintTwoDimensionArray(array);
ExchangeRows(array);
PrintTwoDimensionArray(array);