//Найти третью цифру числа или сообщить, что её нет
int divide_number(int value, int position) //возвращает цифру в заданной позиции
{
    int temp = value;
    for (int i = 1; i < position; i++)
    {
        temp = temp / 10;
    }
    temp = temp % 10;
    return temp;
}

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
    if (value1 < 100)
        Console.WriteLine($"В числе {value1} третей цифры нет");
    else
        Console.WriteLine($"{divide_number(value1, 3)} третья цифра числа {value1}");
    Console.WriteLine("Для выхода из программы введите q");
}
