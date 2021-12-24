void format_out(int nlower)
{
    if (nlower > -10000 && nlower < 10000)
        Console.Write(" ");
    if (nlower > -1000 && nlower < 1000)
        Console.Write(" ");
    if (nlower > -100 && nlower < 100)
        Console.Write(" ");
    if (nlower > -10 && nlower < 10)
        Console.Write(" ");
    if (nlower > -1)
        Console.Write(" ");
}

Console.Write("Введите число -N ");
try
{
    int nlower = int.Parse(Console.ReadLine());
    Console.Write("Введите число N ");
    int nupper = int.Parse(Console.ReadLine());
    int count = 0;
    while (nlower <= nupper)
    {
        if (count % 12 == 0)
            Console.WriteLine();
        format_out(nlower);
        Console.Write(nlower + "   ");
        nlower++;
        count++;
    }
    Console.WriteLine();
}
catch (FormatException)
{
    Console.WriteLine("Неправильный ввод ");
}
