// Написать программу вычисления произведения чисел от 1 до N

int myInput(string msg)
{
    Console.Write(msg);
    string answer = Console.ReadLine() ?? String.Empty;
    bool flag = int.TryParse(answer, out int number);
    if (flag && number > 0)
        return number;
    Console.WriteLine("Неверный ввод");
    return -1;
}

bool isExit()
{
    Console.WriteLine("Введите q для завершения программы, для продолжения нажмите Enter");
    string flag = Console.ReadLine() ?? String.Empty;
    if (flag == "q")
        return false;
    return true;
}

double productOfNumber(int range)
{
    double result = 1;
    for (int i = 1; i <= range; i++)
        result *= (double)i;
    return result;
}

while (isExit())
{
    int range = myInput("Введите число: ");
    if (range == -1)
        continue;
    Console.WriteLine($"Произведение чисел от 1 до {range} равно {productOfNumber(range)}");
}