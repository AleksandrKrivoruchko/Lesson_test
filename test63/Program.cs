// Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента
using static System.Console;
int[,,] CreateThreeDimensionArray()
{
    int[,,] result = new int[3, 6, 5];
    int element = 10;
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = element;
                element++;
            }
    return result;
}

void PrintThreeDimensionArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]}[{i}, {j}, {k}]\t");
            }
            WriteLine();
        }
        // WriteLine();
        // WriteLine();
    }
}

int[,,] test = CreateThreeDimensionArray();
PrintThreeDimensionArray(test);