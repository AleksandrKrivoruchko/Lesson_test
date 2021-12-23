Console.Write("Введите первое число ");
try
{
    double numberA = double.Parse(Console.ReadLine());
    Console.Write("Введите второе число ");
    double numberB = double.Parse(Console.ReadLine());
    if (numberA * numberA == numberB)
    {
        Console.WriteLine("Число {0} является квадратом числа {1}", numberB, numberA);
    }
    else if (numberB * numberB == numberA)
    {
        Console.WriteLine("Число {0} является квадратом числа {1}", numberA, numberB);
    }
    else
    {
        Console.Write("Первое число не является квадратом второго, ");
        Console.WriteLine("а второе не является квадратом первого");
    }
}
catch (FormatException)
{
    Console.WriteLine("Неправильный ввод");
}