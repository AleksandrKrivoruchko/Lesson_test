// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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

void SortingRows(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
        for (int i = 0; i < array.GetLength(1); i++)
            for (int j = 0; j < array.GetLength(1) - 1 - i; j++)
                if (array[k, j] < array[k, j + 1])
                {
                    int temp = array[k, j];
                    array[k, j] = array[k, j + 1];
                    array[k, j + 1] = temp;
                }
}

int[,] array = CreateTwoDimensionArray(10, 10, 0, 100);
PrintTwoDimensionArray(array);
SortingRows(array);
PrintTwoDimensionArray(array);