Console.Write("Введите целое трёхзначное число ");
try
{
    int value = int.Parse(Console.ReadLine());
    if (value < 100 || value > 999)
    {
        Console.WriteLine("Вы ввели не трехзначное число ");
    }
    else
    {
        int temp_value = value % 10;
        Console.WriteLine("{0} - последняя цифра трёхзначного числа", temp_value);
    }
}
catch (FormatException)
{
    Console.WriteLine("Неправильный ввод");
}
