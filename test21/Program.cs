﻿// Программа проверяет пятизначное число на палиндромом.
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
    int temp = len / 2;
    if (len < 2)
        return false;
    else if (len == 2)
        temp = len;
    for (int i = 1; i < temp; i++)
    {
        if (divide_number(value, i) == divide_number(value, len + 1 - i))
        {
            Console.WriteLine(divide_number(value, i));
            continue;
        }
        return false;
    }
    return true;
}

Console.Clear();
//Отладочный цикл
while (Console.ReadLine() != "q")
{
    int len = 0;
    int valueX = my_read_int("Введите номер четверти: ", out len);
    if (valueX == -1)
    {
        Console.WriteLine("Ошибка ввода");
        continue;
    }

    Console.WriteLine(len);
    if (IsPolidrom(valueX, len))
        Console.WriteLine($"Это число {valueX} палиндромом");
    else
        Console.WriteLine($"Это число {valueX} не палиндромом");
    Console.WriteLine("Для выхода из программы введите q");
}
