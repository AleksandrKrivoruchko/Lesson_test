// Показать двумерный массив размером m×n заполненный вещественными числами
using static System.Console;

double[,] CreateTwoDimensionArray(int row, int column, int range)
{
    double[,] result = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = rnd.NextDouble() * range;
    return result;
}

void PrintTwoDimensionArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Write($"{array[i, j],9:N3}");
        WriteLine();
    }
}

double[,] arrayTwoDimension = CreateTwoDimensionArray(10, 8, 100);
PrintTwoDimensionArray(arrayTwoDimension);