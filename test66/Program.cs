// Показать натуральные числа от 1 до N, N задано
int NumericalSeries(int value, int range)
{
    Console.Write($"{value}\t");
    if (value % 10 == 0)
        Console.WriteLine();
    while (value != range)
        return NumericalSeries(value + 1, range);
    return value;
}

NumericalSeries(1, 1000);
Console.WriteLine();