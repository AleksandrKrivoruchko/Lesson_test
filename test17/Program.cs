// По двум заданным числам проверять является ли одно квадратом другого

int my_read_int(string msg) //возвращает целое число с консоли
{
    Console.Write(msg);
    string answer = Console.ReadLine() ?? String.Empty;
    if (int.TryParse(answer, out int value))
        return value;
    else
        return -1;
}

Console.Clear();
//Отладочный цикл
while (Console.ReadLine() != "q")
{
    int value1 = my_read_int("Введите первое число: ");
    if (value1 == -1)
    {
        Console.WriteLine("Нет такого целого числа");
        continue;
    }
    int value2 = my_read_int("Введите второе число: ");
    if (value2 == -1)
    {
        Console.WriteLine("Нет такого целого числа");
        continue;
    }
    if (value1 * value1 == value2)
    {
        Console.WriteLine("Число {0} является квадратом числа {1}", value2, value1);
    }
    else if (value2 * value2 == value1)
    {
        Console.WriteLine("Число {0} является квадратом числа {1}", value1, value2);
    }
    else
    {
        Console.Write("Первое число не является квадратом второго, ");
        Console.WriteLine("а второе не является квадратом первого");
    }

    Console.WriteLine("Для выхода из программы введите q");
}
