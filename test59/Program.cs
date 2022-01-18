// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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

int LineWithMinAmount(int[,] array)
{
    int sum = AmountRow(array, 0);
    Write($"{sum}\t");
    int index = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int temp = AmountRow(array, i);
        Write($"{temp}\t");
        if (sum > temp)
        {
            sum = temp;
            index = i;
        }
    }
    WriteLine();
    return index;
}

int AmountRow(int[,] array, int index)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
        sum += array[index, i];
    return sum;
}

int[,] array = CreateTwoDimensionArray(8, 10, 0, 10);
PrintTwoDimensionArray(array);
int indexMin = LineWithMinAmount(array);
WriteLine($"Индекс строки с минимальной суммой элементов {indexMin}");
WriteLine($"Сумма элементов этой строки {AmountRow(array, indexMin)}");