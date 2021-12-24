Console.WriteLine("Вычисление f(x)=x^3, вам нужно ввести диапазон и интервал вычислений.");
Console.WriteLine("Первое число должно быть меньше второго, а интервал положительным числом");
Console.Write("Введите первое число диапазона вычислений ");
try
{
    double range1 = double.Parse(Console.ReadLine());
    Console.Write("Введите второе число диапазона вычислений ");
    double range2 = double.Parse(Console.ReadLine());
    Console.Write("Введите интервал вычислений ");
    double step = double.Parse(Console.ReadLine());
    if (range2 < range1 || step <= 0)
    {
        Console.WriteLine("Неправильный ввод");
    }
    else
    {
        int count = 0;
        while (range1 <= range2)
        {
            if (count % 5 == 0)
                Console.WriteLine();
            Console.Write(range1 * range1 * range1 + "    ");
            range1 = range1 + step;
            count++;
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Неправильный ввод");
}