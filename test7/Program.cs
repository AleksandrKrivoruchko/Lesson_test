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
        if (nlower > -100 && nlower < 100)
            Console.Write(" ");
        if (nlower > -10 && nlower < 10)
            Console.Write(" ");
        if (nlower > -1)
            Console.Write(" ");
        Console.Write(nlower + "   ");
        nlower++;
        count++;
    }
}
catch (FormatException)
{
    Console.WriteLine("Неправильный ввод ");
}
