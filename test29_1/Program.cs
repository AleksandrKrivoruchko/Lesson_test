// Написать программу вычисления произведения чисел от 1 до N

int MyInput(string msg)
{
    Console.Write(msg);
    string answer = Console.ReadLine() ?? string.Empty;
    bool flag = int.TryParse(answer, out int range);
    if (flag)
        return range;
    return -1;
}

double Multy(int range)
{
    double result = 1;
    for (int i = 1; i <= range; i++)
    {
        result *= (double)i;
    }
    return result;
}

double Multy2(int range)
{
    double result = 1;
    while (range > 1)
    {
        result *= range;
        range--;
    }
    return result;
}

double Multy3(double range)
{
    if (range <= 1)
        return 1;
    return Multy3(range - 1) * range;
}

int value = MyInput("Введите число: ");
if (value == -1)
    Console.WriteLine("Неверный ввод");
else
{
    Console.WriteLine($"Введено число {value} произведение {Multy(value)}");
    Console.WriteLine($"Введено число {value} произведение {Multy2(value)}");
    Console.WriteLine($"Введено число {value} произведение {Multy3(value)}");
}


