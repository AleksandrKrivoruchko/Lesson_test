// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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

int[,] ChangeElementWithEvenIndexies(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
                array[i, j] *= array[i, j];
    return array;
}

int[,] arrayTwoDimension = CreateTwoDimensionArray(4, 8, 0, 10);
PrintTwoDimensionArray(arrayTwoDimension);
WriteLine();
int[,] changeArray = ChangeElementWithEvenIndexies(arrayTwoDimension);
PrintTwoDimensionArray(changeArray);