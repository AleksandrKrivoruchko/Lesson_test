// Составить частотный словарь элементов двумерного массива
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

int IsRepeatElement(int[,] array, int element)
{
    int amountOfElement = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == element)
            {
                amountOfElement++;
            }
    return amountOfElement;
}

int[,] RepetitionElementsInArray(int[,] array)
{
    int len = array.GetLength(0) * array.GetLength(1);
    int[,] result = new int[len, 2];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (IsElement(result, array[i, j]))
            {
                result[k, 0] = array[i, j];
                int tmp = IsRepeatElement(array, result[k, 0]);
                result[k, 1] = tmp;
                k++;
            }
        }
    int[,] resultArray = SortingColumns(result);
    return resultArray;
}

int HowManyElements(int[,] array)
{
    int quantity = 0;
    while (array[quantity, 1] != 0 && array.GetLength(0) > quantity)
        quantity++;
    return quantity;
}

int[,] TruncatingArray(int[,] array, int quantity)
{
    int[,] resultArray = new int[quantity, 2];
    for (int i = 0; i < quantity; i++)
    {
        resultArray[i, 0] = array[i, 0];
        resultArray[i, 1] = array[i, 1];
    }
    return resultArray;
}
int[,] SortingColumns(int[,] array)
{
    int len = HowManyElements(array);
    int[,] resultArray = TruncatingArray(array, len);
    for (int i = 0; i < len; i++)
        for (int j = 0; j < len - 1 - i; j++)
            if (resultArray[j, 0] > resultArray[j + 1, 0])
            {
                int tmp = resultArray[j, 0];
                resultArray[j, 0] = resultArray[j + 1, 0];
                resultArray[j + 1, 0] = tmp;
                tmp = resultArray[j, 1];
                resultArray[j, 1] = resultArray[j + 1, 1];
                resultArray[j + 1, 1] = tmp;
            }
    //PrintTwoDimensionArray(resultArray);
    return resultArray;
}

bool IsElement(int[,] array, int element)
{
    int i = 0;
    while (array[i, 1] != 0 && i < array.GetLength(0))
    {
        if (array[i, 0] == element)
            return false;
        i++;
    }
    //WriteLine(i);
    return true;
}


int[,] testArray = CreateTwoDimensionArray(4, 14, 0, 8);
PrintTwoDimensionArray(testArray);
int[,] resultArray = RepetitionElementsInArray(testArray);
for (int i = 0; i < resultArray.GetLength(0); i++)
    if (resultArray[i, 1] == 0)
        break;
    else
    {
        string word = string.Empty;
        bool caseWord = resultArray[i, 1] % 10 > 1 && resultArray[i, 1] % 10 < 5;
        bool caseWord1 = resultArray[i, 1] < 10 || resultArray[i, 1] > 20;
        if (caseWord && caseWord1)
            word = "раза";
        else
            word = "раз";
        WriteLine($"Число {resultArray[i, 0]} встречается {resultArray[i, 1]} {word}");
    }