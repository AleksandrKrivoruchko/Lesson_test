double max_in_three(double valueA, double valueB, double valueC)
{
    double max = valueA;
    if (valueB > max)
        max = valueB;
    if (valueC > max)
        max = valueC;
    return max;
}

Console.Write("Введите первое число ");
try
{
    double valueA = double.Parse(Console.ReadLine());
    Console.Write("Введите второе число ");
    double valueB = double.Parse(Console.ReadLine());
    Console.Write("Введите третье число ");
    double valueC = double.Parse(Console.ReadLine());
    double max = max_in_three(valueA, valueB, valueC);
    Console.WriteLine("Вы ввели числа {0}  {1}  {2}", valueA, valueB, valueC);
    Console.WriteLine("Число {0} максимальное из них", max);
}
catch (FormatException)
{
    Console.WriteLine("Неправильный ввод");
}
