// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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

double SumAverageColumn(int[,] array, int indexRow)
{
    double sum = 0;
    int j = indexRow;
    for (int i = 0; i < array.GetLength(0); i++)
        sum += array[i, j];
    return sum / array.GetLength(0);
}

double[] AverageSumColumnsOfTable(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
        result[i] = SumAverageColumn(array, i);
    return result;
}

void PrintAverageSumColumnsOfTable(double[] result)
{
    for (int i = 0; i < result.Length; i++)
        WriteLine($"Столбец {i} среднее арифметическое {result[i]}");
}

int[,] arrayTwoDimension = CreateTwoDimensionArray(8, 5, 0, 10);
PrintTwoDimensionArray(arrayTwoDimension);
WriteLine();
double[] averageSumColumns = AverageSumColumnsOfTable(arrayTwoDimension);
PrintAverageSumColumnsOfTable(averageSumColumns);
