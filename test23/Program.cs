// Показать таблицу квадратов чисел от 1 до N 

int my_read_int(string msg) //возвращает целое число с консоли
{
    Console.Write(msg);
    string answer = Console.ReadLine() ?? String.Empty;
    if (int.TryParse(answer, out int value))
        return value;
    else
        return -1;
}

int mySqrt(int value)
{
    return value * value;
}

bool IsNumber(int value) //Проверка ввода
{
    if (value == -1)
    {
        Console.WriteLine("Неверный ввод");
        return false;
    }
    else
        return true;
}

Console.Clear();
string flag = String.Empty;
while (flag != "q") //Отладочный цикл
{
    Console.WriteLine("Для завершения введите q, для продолжения нажмите Enter");
    flag = Console.ReadLine() ?? String.Empty;
    if (flag == "q")
        break;
    int value = my_read_int("Введите число: ");
    if (!IsNumber(value))
        continue;
    for (int i = 1; i <= value; i++)
    {
        Console.Write($"{i}^2 = {mySqrt(i)}    ");
        if (i % 4 == 0)
            Console.WriteLine();
    }
    Console.WriteLine();
}