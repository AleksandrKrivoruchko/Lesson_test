// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
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
    int value1 = my_read_int("Введите число дня недели: ");
    if (value1 == -1 || value1 > 7 || value1 < 1)
    {
        Console.WriteLine("Нет такого дня недели");
        continue;
    }
    if (value1 > 5)
        Console.WriteLine("Это выходной день");
    else
        Console.WriteLine("Это рабочий день");
    Console.WriteLine("Для выхода из программы введите q");
}
