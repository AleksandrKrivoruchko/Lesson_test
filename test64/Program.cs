// Показать треугольник Паскаля
using static System.Console;

// Формирование массива с числами треугольника Паскаля.
// n - количество строк в треугольнике.
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

// Получение массива строк из массива чисел.
string[] ConvertIntArrayToString(int[,] inputArray)
{
    string[] resultArray = new string[inputArray.GetLength(0)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] == 0) continue;
            resultArray[i] += inputArray[i, j] + "     ";
        }
    }
    return resultArray;
}

// Вывод на экран треугольника Паскаля.
void PrintTriangleFromStringArray(string[] triangleString)
{
    int lastIndexArray = triangleString.Length - 1;
    int middleString = triangleString[lastIndexArray].Length / 2;
    for (int i = 0; i < triangleString.Length; i++)
    {
        int numberOfSpaces = middleString - triangleString[i].Length / 2;
        while (numberOfSpaces > 0)
        {
            Write(" ");
            numberOfSpaces--;
        }
        WriteLine(triangleString[i]);
    }
}

int[,] trigon = TrigonPascal(10);
string[] trigonString = ConvertIntArrayToString(trigon);
PrintTriangleFromStringArray(trigonString);