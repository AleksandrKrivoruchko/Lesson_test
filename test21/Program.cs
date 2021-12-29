// Программа проверяет пятизначное число на палиндром.
int my_read_int(string msg, out int len) //возвращает целое число с консоли
{
    Console.Write(msg);
    string answer = Console.ReadLine() ?? String.Empty;
    len = answer.Length;
    if (int.TryParse(answer, out int value))
        return value;
    else
        return -1;
}

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

bool IsPolidrom(int value, int len)
{
    int temp = len / 2 + 1;
    if (len < 2)
        return false;
    for (int i = 1; i < temp; i++)
    {
        if (divide_number(value, i) == divide_number(value, len + 1 - i))
        {
            Console.WriteLine(divide_number(value, i));
            Console.WriteLine(divide_number(value, len + 1 - i));
            continue;
        }
        return false;
    }
    return true;
}

int quantity_digit(int value)
{
    int temp = value;
    int quantity = 0;
    while (temp > 0)
    {
        temp = temp / 10;
        quantity++;
    }
    Console.WriteLine($"{quantity} цифр в {value}");
    return quantity;
}

Console.Clear();
//Отладочный цикл
while (Console.ReadLine() != "q")
{
    int len = 0;
    int valueX = my_read_int("Введите число для проверки: ", out len);
    if (valueX == -1)
    {
        Console.WriteLine("Ошибка ввода");
        continue;
    }

    Console.WriteLine(len);
    int number_len = quantity_digit(valueX);
    if (IsPolidrom(valueX, number_len))
        Console.WriteLine($"Это число {valueX} палиндром");
    else
        Console.WriteLine($"Это число {valueX} не палиндром");
    Console.WriteLine("Для выхода из программы введите q");
}
