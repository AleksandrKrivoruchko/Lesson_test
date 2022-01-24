// Показать натуральные числа от N до 1, N задано
using static System.Console;
int NumericalSeries(int range)
{
    Write($"{range}\t");
    if (range % 11 == 0)
        WriteLine();
    if (range == 1)
        return 1;
    return NumericalSeries(range - 1);
}

NumericalSeries(1000);
WriteLine();