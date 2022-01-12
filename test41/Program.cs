using static System.Console;
// Выяснить являются ли три числа сторонами треугольника 

bool IsTriangle(double sideA, double sideB, double sideC)
{
    if (sideA < sideB + sideC)
        if (sideB < sideA + sideC)
            if (sideC < sideA + sideB)
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

void SplitStr(string str, string[] sides)
{
    int i = 0;
    foreach (char s in str)
    {
        sides[i] += s;
        if (s == ' ')
            i++;
    }
}

string[] sides = new string[3];
string answer = MyInput();
double sideA, sideB, sideC;

SplitStr(answer, sides);
for (int i = 0; i < sides.Length; i++)
{
    WriteLine(sides[i]);
}

if (!ConvertStr(sides[0], out sideA))
    WriteLine("Неправильный ввод");
if (!ConvertStr(sides[1], out sideB))
    WriteLine("Неправильный ввод");
if (!ConvertStr(sides[2], out sideC))
    WriteLine("Неправильный ввод");

if (IsTriangle(sideA, sideB, sideC))
    WriteLine("Эти числа являются сторонами треугольника");
else
    WriteLine("Эти числа не являются сторонами треугольника");