// Найти сумму элементов от M до N, N и M заданы
using static System.Console;
int SumRange(int startRange, int endRange)
{
    if (startRange != endRange)
        return startRange + SumRange(startRange + 1, endRange);
    else
        return startRange;
}

int[] ConverInputStringToInt(string inputString)
{
    string[] temp = inputString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (temp.Length != 2) ErrorMessage(inputString);
    int[] valueRange = new int[2];
    for (int i = 0; i < 2; i++)
    {
        bool isIntNumber = int.TryParse(temp[i], out valueRange[i]);
        if (!isIntNumber) ErrorMessage(inputString);
    }
    return valueRange;
}

void ErrorMessage(string msg)
{
    WriteLine($"Неверный ввод {msg}");
    Environment.Exit(1);
}

WriteLine("Введите число M и число N через пробел");
string answerRange = ReadLine() ?? string.Empty;
int[] rangeLimits = ConverInputStringToInt(answerRange);
int sumDiapason = 0;
if (rangeLimits[0] < rangeLimits[1])
{
    sumDiapason = SumRange(rangeLimits[0], rangeLimits[1]);
}
else
{
    sumDiapason = SumRange(rangeLimits[1], rangeLimits[0]);
}
WriteLine($"Сумма элементов от {rangeLimits[0]} до {rangeLimits[1]} равна {sumDiapason}");
