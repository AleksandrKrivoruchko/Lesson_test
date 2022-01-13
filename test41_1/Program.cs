using static System.Console;
// Выяснить являются ли три числа сторонами треугольника 

bool IsTriangle(double[] sides)
{
    for (int i = 0; i < sides.Length; i++)
    {
        if ((int)sides[i] == 0)
            return false;
    }
    if (sides[0] < sides[1] + sides[2])
        if (sides[1] < sides[0] + sides[2])
            if (sides[2] < sides[0] + sides[1])
                return true;
    return false;
}

string MyInput()
{
    WriteLine("Введите три числа через пробелы:");
    return ReadLine() ?? string.Empty;
}

bool ConvertStr(string str, out double side)
{
    bool answer = double.TryParse(str, out side);
    return answer;
}

void SplitStr(string str, string[] sidesString)
{
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

string[] sidesString = new string[3];
string answer = MyInput();
double[] sides = new double[3];

SplitStr(answer, sidesString);
for (int i = 0; i < sidesString.Length; i++)
{
    WriteLine(sidesString[i]);
}

if (!IsInputCorrect(sidesString, sides))
    WriteLine("Неправильный ввод");
else if (IsTriangle(sides))
    WriteLine("Эти числа являются сторонами треугольника");
else
    WriteLine("Эти числа не являются сторонами треугольника");



