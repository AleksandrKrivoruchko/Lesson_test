// Дано число. Проверить кратно ли оно 7 и 23
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
    int value1 = my_read_int("Введите целое число: ");
    if (value1 == -1)
    {
        Console.WriteLine("Не корректный ввод данных");
        continue;
    }
    if (value1 % 7 == 0 && value1 % 23 == 0)
        Console.WriteLine($"Число {value1} кратно 7 и 23");
    else
        Console.WriteLine($"Число {value1} не крато 7 и 23");
    Console.WriteLine("Для выхода из программы введите q");
}
