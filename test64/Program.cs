// Показать треугольник Паскаля
using static System.Console;
int[,] TrigonPascal(int n)
{
    int len = n + 1;
    int[,] trigonPascal = new int[n, len];
    trigonPascal[0, len - 2] = 1;
    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j < len - 1; j++)
        {
            trigonPascal[i, j] = trigonPascal[i - 1, j] + trigonPascal[i - 1, j + 1];
        }
    }
    return trigonPascal;
}

void PrintTwoDimensionArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        //SetCursorPosition(5, 5);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
    WriteLine();
}
//SetCursorPosition(20, 10);
int[,] trigon = TrigonPascal(10);
PrintTwoDimensionArray(trigon);