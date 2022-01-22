// Спирально заполнить двумерный массив
using static System.Console;

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

int[,] FillingSpiralArray(int[,] array)
{
    int rowStart = 0;
    int rowEnd = array.GetLength(0) - 1;
    int columnStart = 0;
    int columnEnd = array.GetLength(1) - 1;
    int countElement = array.GetLength(0) * array.GetLength(1);
    int count = 1;
    while (countElement >= count)
    {
        count = MoveRight(array, count, rowStart, columnStart, columnEnd);
        rowStart++;
        count = MoveDown(array, count, columnEnd, rowStart, rowEnd);
        columnEnd--;
        // WriteLine($"rowStart = {rowStart} rowEnd = {rowEnd}");
        // WriteLine($"columnStart = {columnStart} columnEnd = {columnEnd}");
        count = MoveLeft(array, count, rowEnd, columnStart, columnEnd);
        rowEnd--;
        count = MoveTop(array, count, columnStart, rowStart, rowEnd);
        columnStart++;
    }
    //WriteLine(count);
    return array;
}

int MoveTop(int[,] array, int count, int column, int start, int end)
{
    for (int i = end; i >= start; i--)
    {
        array[i, column] = count++;
    }
    return count;
}

int MoveLeft(int[,] array, int count, int row, int start, int end)
{
    for (int i = end; i >= start; i--)
    {
        array[row, i] = count++;
        // WriteLine(i);
    }
    return count;
}

int MoveDown(int[,] array, int count, int column, int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        array[i, column] = count++;
    }
    return count;
}

int MoveRight(int[,] array, int count, int row, int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        array[row, i] = count++;
    }
    return count;
}

int[,] testArray = new int[5, 5];
int[,] resultArray = FillingSpiralArray(testArray);
PrintTwoDimensionArray(resultArray);