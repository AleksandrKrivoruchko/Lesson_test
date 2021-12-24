void format_out(int count)
{
    if (count > -10000 && count < 10000)
        Console.Write(" ");
    if (count > -1000 && count < 1000)
        Console.Write(" ");
    if (count > -100 && count < 100)
        Console.Write(" ");
    if (count > -10 && count < 10)
        Console.Write(" ");
    if (count > -1)
        Console.Write(" ");
}

Console.Write("Введите целое число ");
try
{
    int value = int.Parse(Console.ReadLine());
    if (value <= 1)
        Console.WriteLine("Число должно быть больше 1");
    int count = 1;
    int count_format = 0;
    while (count <= value)
    {
        if (count % 2 == 0)
        {
            if (count_format % 10 == 0)
                Console.WriteLine();
            format_out(count);
            Console.Write(count + "    ");
            count_format++;
        }
        count++;
    }
    Console.WriteLine();
}
catch (FormatException)
{
    Console.WriteLine("Неправильный ввод");
}
