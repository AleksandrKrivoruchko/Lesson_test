// Показать треугольник Паскаля
using static System.Console;
int[,] TrigonPascal(int n)
{
    int len = 2 * n + 3;
    int[,] trigonPascal = new int[n, len];
    int middle = len / 2;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < len; j++)
        {
            if (j == middle && i == 0)
                trigonPascal[i, j] = 1;
            if (i == 1)
            {
                if (j == middle - 1)
                    trigonPascal[i, j] = 1;
                if (j == middle + 1)
                    trigonPascal[i, j] = 1;
            }
            else
            {
                if (i > 1)
                    if (j + 2 < len)
                        trigonPascal[i, j + 1] = trigonPascal[i - 1, j + 2] + trigonPascal[i - 1, j];
            }
            // Write($"{trigonPascal[i, j]}");
        }
        // WriteLine();
    }
    return trigonPascal;
}

void PrintTwoDimensionArray(int[,] array)
{
    string tempStr = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
                tempStr += " ";
            else
                tempStr += array[i, j];
        }
        tempStr += "\n";
    }
    WriteLine(tempStr);
    WriteLine();
}

int[,] trigon = TrigonPascal(10);
PrintTwoDimensionArray(trigon);