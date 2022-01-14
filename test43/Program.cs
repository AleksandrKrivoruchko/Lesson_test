using static System.Console;
// Написать программу преобразования десятичного числа в двоичное
string MyInput(string msg)
{
    Write(msg);
    return ReadLine() ?? string.Empty;
}

string ToBinary(int argument)
{
    string binary = string.Empty;
    int temp = argument;
    int tmp = 0;
    while (temp > 0)
    {
        tmp = temp % 2;
        temp /= 2;
        binary += tmp.ToString();
    }
    return binary;
}

string ReversStr(string str)
{
    string tmp = string.Empty;
    for (int i = str.Length - 1; i >= 0; i--)
        tmp += str[i];
    return tmp;
}

bool IsExit(string str)
{
    if (str.Length == 0)
        return true;
    return false;
}

WriteLine(ReversStr(ToBinary(10)));

string number = string.Empty;
string binary = string.Empty;
bool flag;
int value;
while (true)
{
    WriteLine("Для выхода нажмите Enter");
    number = MyInput("Введите целое положительное число: ");
    if (IsExit(number))
        break;
    flag = int.TryParse(number, out value);
    if (!flag || value < 0)
    {
        WriteLine("Неверный ввод");
        continue;
    }
    binary = ToBinary(value);
    WriteLine($"{number} = {ReversStr(binary)}b");
}
