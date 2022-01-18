// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить,
//  что это невозможно (в случае, если матрица не квадратная).
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

int[,] ReplacingColumnsWithRows(int[,] array)
{
    int[,] tempArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempArray[j, i] = array[i, j];
        }
    }
    return tempArray;
}

int[,] array = CreateTwoDimensionArray(8, 8, 0, 100);
PrintTwoDimensionArray(array);
if (array.GetLength(0) == array.GetLength(1))
{
    int[,] replacingArray = ReplacingColumnsWithRows(array);
    PrintTwoDimensionArray(replacingArray);
}
else
{
    Write($"В массиве [{array.GetLength(0)}, {array.GetLength(1)}] ");
    WriteLine("невозможно поменять строки на столбцы");
}