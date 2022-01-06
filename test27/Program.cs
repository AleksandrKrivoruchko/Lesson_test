// Определить количество цифр в числе

long myInput(string msg)
{
    Console.Write(msg);
    string number = Console.ReadLine() ?? String.Empty;
    bool flag = long.TryParse(number, out long value);
    if (flag)
        return value;
    else
    {
        Console.WriteLine("Неверный ввод");
        return -1;
    }
}

int numberOfDigits(long value)
{
    long temp = value;
    int result = 0;
    if (temp < 10)
        return 1;
    while (temp > 0)
    {
        temp /= 10;
        result++;
    }
    return result;
}

bool testExit()
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

while (testExit())
{
    long value = myInput("Введите число: ");
    if (value == -1)
        continue;
    Console.WriteLine($"Число {value} содержит {numberOfDigits(modNumber(value))} цифр");
}