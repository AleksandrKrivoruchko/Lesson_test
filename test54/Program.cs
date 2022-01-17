// В матрице чисел найти сумму элементов главной диагонали
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

int MainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == j)
            {
                sum += array[i, j];
                // Write($"{array[i, j]} + ");
            }
    return sum;
}

int[,] arrayTwoDimension = CreateTwoDimensionArray(4, 4, -10, 10);
PrintTwoDimensionArray(arrayTwoDimension);
WriteLine();
int sum = MainDiagonal(arrayTwoDimension);
WriteLine($"Сумма элементов главной диагонали равна {sum}");
