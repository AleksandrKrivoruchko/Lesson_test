// Показать натуральные числа от M до N, N и M заданы
using static System.Console;
int DirectOutputNumbers(int startValue, int endRange)
{
    Write($"{startValue}\t");
    if (startValue % 10 == 0)
        WriteLine();
    if (startValue != endRange)
        return DirectOutputNumbers(startValue + 1, endRange);
    return startValue;
}

int ReverseOutputNumbers(int startValue, int endRange)
{
    Console.Write($"{startValue}\t");
    if (startValue % 10 == 0)
        Console.WriteLine();
    if (startValue != endRange)
        return ReverseOutputNumbers(startValue - 1, endRange);
    return startValue;
}

int[] ConvertInput(string inputString)
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
int[] rangeLimits = ConvertInput(answerRange);
if (rangeLimits[0] < rangeLimits[1])
{
    DirectOutputNumbers(rangeLimits[0], rangeLimits[1]);
}
else
{
    ReverseOutputNumbers(rangeLimits[0], rangeLimits[1]);
}