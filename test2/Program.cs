Console.Write("Введите первое число ");
try
{
    double numberA = double.Parse(Console.ReadLine());
    Console.Write("Введите второе число ");
    double numberB = double.Parse(Console.ReadLine());
    if (numberA > numberB)
    {
        Console.WriteLine("Чило {0} больше числа {1}", numberA, numberB);
    }
    else if (numberB > numberA)
    {
        Console.WriteLine("Чило {0} больше числа {1}", numberB, numberA);
    }
    else
    {
        Console.WriteLine("Чило {0} равно числу {1}", numberB, numberA);
    }
}
catch (FormatException)
{
    Console.WriteLine("Неправильный ввод");
}
