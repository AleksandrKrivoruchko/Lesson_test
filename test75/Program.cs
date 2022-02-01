// Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
// Числа идут друг за другом без разделителей.
// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
using static System.Console;

int Power(int number, int degree)
{
    int result = 1;
    if (degree == 0) return 1;
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


int[] data = { 1, 1, 1, 0, 1, 0, 1, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] resultArray = ConvertBinaryArrayToDecimal(data, info);
PrintArray(data);
PrintArray(info);
PrintArray(resultArray);