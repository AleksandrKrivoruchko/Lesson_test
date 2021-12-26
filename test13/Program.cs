//Выяснить, кратно ли число заданному, если нет, вывести остаток.
int my_read_int(string msg)
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
    int value1 = my_read_int("Введите заданное число: ");
    if (value1 == -1)
    {
        Console.WriteLine("Не корректный ввод данных");
        continue;
    }
    int value2 = my_read_int("Введите число для проверки кратности: ");
    if (value2 == -1)
    {
        Console.WriteLine("Не корректный ввод данных");
        continue;
    }
    int result = value1 % value2;
    if (result == 0)
        Console.WriteLine($"Число {value1} кратно числу {value2}");
    else
        Console.WriteLine($"Остаток от деления равен {result}");
    Console.WriteLine("Для выхода из программы введите q");
}
