using static System.Console;
// Показать числа Фибоначчи
string MyInput(string msg)
{
    Write(msg);
    return ReadLine() ?? string.Empty;
}

int Fibinachi(int value)
{
    if (value > 1)
        return Fibinachi(value - 2) + Fibinachi(value - 1);
    else
        return 1;
}

while (true)
{
    string answer = MyInput("Введите число: ");
    if (answer.Length == 0) break;
    bool flag = int.TryParse(answer, out int result);
    if (!flag)
    {
        WriteLine("Неверный ввод");
        continue;
    }
    int j = 1;
    for (int i = 0; i <= result; i++)
    {
        Write($"{Fibinachi(i),10}");
        if (j % 5 == 0)
            WriteLine();
        j++;
    }
    WriteLine();
}