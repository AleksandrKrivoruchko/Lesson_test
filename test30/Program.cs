// Показать кубы чисел, заканчивающихся на четную цифру

bool MyInput(string msg, out int range)
{
    Console.Write(msg);
    string answer = Console.ReadLine() ?? String.Empty;
    return int.TryParse(answer, out range);
}

bool IsEvenNumber(int value)
{
    if (value % 2 == 0)
        return true;
    return false;
}

bool IsExit()
{
    Console.WriteLine("Введите q для завершения программы, для продолжения нажмите Enter");
    string flag = Console.ReadLine() ?? string.Empty;
    if (flag == "q")
        return false;
    return true;
}

double Cube(double value)
{
    return (value * value * value);
}

int Mod(int value)
{
    if (value < 0)
        return -value;
    return value;
}

void PrintCube(int range)
{
    int i = -Mod(range);
    Console.WriteLine(IsEvenNumber(range));
    if (!IsEvenNumber(range))
        i++;
    Console.WriteLine(i);
    while (i <= Mod(range))
    {
        Console.Write($"{Cube(i),15}");
        if (i % 5 == 0)
            Console.WriteLine();
        i += 2;
    }
    Console.WriteLine();
}

while (IsExit())
{
    bool flag = MyInput("Введите число: ", out int range);
    if (!flag)
    {
        Console.WriteLine("Неверный ввод");
        continue;
    }
    PrintCube(range);
}