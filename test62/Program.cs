// В двумерном массиве целых чисел. Удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.
using static System.Console;
int[,] CreateTwoDimensionArray(int row, int column, int min, int max)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = rnd.Next(min, max + 1);
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

int[] MinElementIndex(int[,] array)
{
    int[] minIndex = new int[2];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (min > array[i, j])
            {
                min = array[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }
    return minIndex;
}

int[,] ChangeArray(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int[] minIndex = MinElementIndex(array);
    int k = 0, h = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minIndex[0])
            continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == minIndex[1])
                continue;
            resultArray[k, h] = array[i, j];
            h++;
        }
        h = 0;
        k++;
    }
    return resultArray;
}

int[,] sourceArray = CreateTwoDimensionArray(8, 10, -10, 100);
PrintTwoDimensionArray(sourceArray);
int[,] changeArray = ChangeArray(sourceArray);
PrintTwoDimensionArray(changeArray);