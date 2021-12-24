Console.Write("Введите число ");
try
{
    int value = int.Parse(Console.ReadLine());
    if (value % 2 == 0)
        Console.WriteLine("Число чётное");
    else
        Console.WriteLine("Число не чётное");
}
catch (FormatException)
{
    Console.WriteLine("Введено не целое число ");
}
