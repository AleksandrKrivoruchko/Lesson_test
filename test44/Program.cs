using static System.Console;
// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
string MyInput()
{
    WriteLine("Введите числа через пробелы k1 b1 k2 b2");
    return ReadLine() ?? string.Empty;
}

bool ConvertStr(string str, out double side)
{
    bool answer = double.TryParse(str, out side);
    WriteLine($"ConvertStr {side}, {answer}");
    WriteLine($"ConvertStr {str}");
    return answer;
}

void PrintArray(string[] array)
{
    foreach (string str in array)
        WriteLine($"PrintArray {str}");
}

void SplitStr(string str, string[] sidesString)
{
    WriteLine($"SplitStr {str}");
    int j = 0;
    bool flag = true;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {
            if (flag)
            {
                flag = false;
                j++;
            }
            continue;
        }
        flag = true;
        sidesString[j] += str[i];
    }
    PrintArray(sidesString);

}

bool IsInputCorrect(string[] sidesString, double[] sides)
{
    for (int i = 0; i < sides.Length; i++)
    {
        if (!ConvertStr(sidesString[i], out sides[i]))
            return false;
    }
    return true;
}

void ClearArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = string.Empty;
}

bool IsCrossing(double[] coefficiens, double[] result)
{
    if (coefficiens[0] == coefficiens[2])
        return false;
    double tempb = coefficiens[3] - coefficiens[1];
    double tempk = coefficiens[0] - coefficiens[2];
    result[0] = tempb / tempk;
    result[1] = coefficiens[0] * result[0] + coefficiens[1];
    return true;
}

Clear();
double[] cor = new double[2];
double[] coeff = new double[4];
string[] splitCoeff = new string[4];
string str = string.Empty;
bool flag = false;
while (true)
{
    str = MyInput();
    if (str.Length == 0)
        break;
    SplitStr(str, splitCoeff);
    flag = IsInputCorrect(splitCoeff, coeff);
    ClearArray(splitCoeff);
    if (!flag)
    {
        WriteLine("Неверный ввод");
        continue;
    }
    if (IsCrossing(coeff, cor))
        WriteLine($"Координаты точки пересечения ({cor[0]:N3}, {cor[1]:N3})");
    else
        WriteLine("Точки пересечения нет");
}
