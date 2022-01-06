// Подсчитать сумму цифр в числе

bool myInput(string msg, out long value)
{
    Console.Write(msg);
    string answer = Console.ReadLine() ?? String.Empty;
    bool flag = long.TryParse(answer, out value);
    return flag;
}

bool isExit()
{
    Console.WriteLine("Введите q для завершения программы, для продолжения нажмите Enter");
    string answer = Console.ReadLine() ?? String.Empty;
    if (answer == "q")
        return false;
    return true;
}

long modNumber(long value)
{
    if (value < 0)
        return -value;
    return value;
}

int sumDigits(long value)
{
    int sum = 0;
    long temp = value;
    while (temp > 0)
    {
        sum += (int)(temp % 10);
        temp /= 10;
    }
    return sum;
}

while (isExit())
{
    long number = 0;
    bool flag = myInput("Введите число: ", out number);
    if (!flag)
    {
        Console.WriteLine("Неверный ввод");
        continue;
    }
    int temp = sumDigits(modNumber(number));
    Console.WriteLine($"Введено число {number}");
    Console.WriteLine($"Сумма цифр числа равна {temp}");
}