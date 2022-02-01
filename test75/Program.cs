// Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении.
// Числа идут друг за другом без разделителей.
// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
using static System.Console;

int Power(int number, int degree)
{
    int result = 1;
    if (degree == 0) return result;
    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    return result;
}

int ConvertBinaryToDecimal(int[] arrayData, int indexStart, int indexEnd)
{
    int result = 0;
    int degree = 0;
    for (int i = indexEnd - 1; i >= indexStart; i--)
    {
        result += arrayData[i] * Power(2, degree);
        degree++;
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}\t");
    }
    WriteLine();
}

int[] ConvertBinaryArrayToDecimal(int[] arrayData, int[] arrayInfo)
{
    bool flag = IsCanConvert(arrayData, arrayInfo);
    if (!flag)
    {
        Environment.Exit(1);
    }
    int[] resultArray = new int[arrayInfo.Length];
    int indexStart = 0;
    int indexEnd = 0;
    for (int i = 0; i < resultArray.Length; i++)
    {
        indexEnd = indexStart + arrayInfo[i];
        resultArray[i] = ConvertBinaryToDecimal(arrayData, indexStart, indexEnd);
        indexStart = indexEnd;
    }
    return resultArray;
}

int SumElementsArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

bool IsCanConvert(int[] arrayData, int[] arrayInfo)
{
    int answer = arrayData.Length - SumElementsArray(arrayInfo);
    if (answer == 0) return true;
    if (answer > 0)
    {
        WriteLine("В массиве info не достаточно информации.");
        return false;
    }
    else
    {
        WriteLine("В массиве data не достаточно информации.");
        return false;
    }
}

int[] data = { 1, 1, 1, 0, 1, 0, 1, 0, 1 };
int[] info = { 2, 3, 3, 1 };
PrintArray(data);
PrintArray(info);
int[] resultArray = ConvertBinaryArrayToDecimal(data, info);
PrintArray(resultArray);
