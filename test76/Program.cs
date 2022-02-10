// Есть число N. Сколько групп M можно получить при разбиении всех чисел
// на группы, так чтобы в одной группе все числа были взаимно просты.
// Найти M при заданном N и получить одно из разбиений на группы N <= 10^20.

int NumberOfGroups(decimal range)
{
    int count = 0;
    decimal temp = range;
    Console.WriteLine(temp);
    while (temp > 1)
    {
        if (temp > 4294967296)
        {
            temp = temp / 4294967296;
            count += 32;
        }
        if (temp > 65536)
        {
            temp = temp / 65536;
            count += 16;
        }
        if (temp > 1024)
        {
            temp = temp / 1024;
            count += 10;
        }
        if (temp > 512)
        {
            temp = temp / 512;
            count += 9;
        }
        if (temp > 128)
        {
            temp = temp / 128;
            count += 7;
        }
        if (temp > 32)
        {
            temp = temp / 32;
            count += 5;
        }
        if (temp > 1)
        {
            temp = temp / 2;
            count++;
        }
        Console.WriteLine($"{temp}  {count}");
    }
    return count;
}

void PrintGroupsNumbers(decimal range)
{
    decimal countNumber = 1;
    int groups = 1;
    decimal start = 2;
    int lineLength = 0;
    Console.WriteLine($"{groups++})  {countNumber++}");
    while (countNumber != range + 1)
    {
        Console.Write($"{groups})  ");
        start *= 2;
        while (start > countNumber && countNumber != range + 1)
        {
            Console.Write($"{countNumber} ");
            countNumber++;
            lineLength++;
            if (lineLength > 9)
            {
                Console.WriteLine();
                lineLength = 0;
            }
        }
        groups++;
        Console.WriteLine();
    }
}

decimal N = 100000000000000000000M;
Console.WriteLine(NumberOfGroups(N));
Console.Write("Введите число N: ");
string decimalValue = Console.ReadLine() ?? string.Empty;
bool test = decimal.TryParse(decimalValue, out N);
if (!test)
{
    Console.WriteLine($"Неверный ввод {decimalValue}");
    Environment.Exit(1);
}

int groups = NumberOfGroups(N);
Console.WriteLine($"Для числа {N} разбиение даёт M = {groups}");
Console.ReadLine();
PrintGroupsNumbers(N);





