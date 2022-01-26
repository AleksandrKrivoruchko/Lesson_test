// Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем
using static System.Console;
string CreatSeries(double start, double next, int amountNumbers)
{
    string res = start.ToString();
    if (amountNumbers == 0) return string.Empty;
    res = res + " " + $"{CreatSeries(next, start + next, amountNumbers - 1)}";
    return res;

}

double[] ConverInputString(string inputString)
{
    string[] temp = inputString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (temp.Length != 2) ErrorMessage(inputString);
    double[] valueRange = new double[2];
    for (int i = 0; i < 2; i++)
    {
        bool isNumber = double.TryParse(temp[i], out valueRange[i]);
        if (!isNumber) ErrorMessage(inputString);
    }
    return valueRange;
}

void ErrorMessage(string msg)
{
    WriteLine($"Неверный ввод {msg}");
    Environment.Exit(1);
}

WriteLine("Введите первые два элемента последовательности через пробел:");
string temp = ReadLine() ?? string.Empty;
double[] firstSecond = ConverInputString(temp);
WriteLine("Введите количество элементов последовательности:");
temp = ReadLine() ?? string.Empty;
int count = 0;
bool answer = int.TryParse(temp, out count);
if (!answer) ErrorMessage(temp);
temp = CreatSeries(firstSecond[0], firstSecond[1], count);
WriteLine(temp);
