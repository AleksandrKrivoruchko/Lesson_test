// В двумерном массиве показать позиции числа, заданного 
// пользователем или указать, что такого элемента нет
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

bool IsElement(int[,] array, List<int> indexies, int originalNumber)
{
    bool isFind = false;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == originalNumber)
            {
                indexies.Add(i);
                indexies.Add(j);
                isFind = true;
            }
    return isFind;
}

int[,] arrayTwoDimension = CreateTwoDimensionArray(10, 8, 0, 100);
PrintTwoDimensionArray(arrayTwoDimension);
List<int> findIndexies = new List<int>();
int number = 10;
bool isFind = IsElement(arrayTwoDimension, findIndexies, number);
if (isFind)
{
    for (int i = 0; i < findIndexies.Count; i += 2)
    {
        Write($"[{findIndexies[i]}, {findIndexies[i + 1]}]\t");
    }
    WriteLine();
}
else
    WriteLine($"Числа {number} в данном массиве нет");