// Задать номер четверти, показать диапазоны для возможных координат
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
    int valueX = my_read_int("Введите номер четверти: ");
    if (valueX == -1 || valueX > 4 || valueX <= 0)
    {
        Console.WriteLine("Нет такой четверти");
        continue;
    }

    if (valueX == 1)
        Console.WriteLine("Диапазон X и Y от нуля до бесконечности");
    if (valueX == 2)
        Console.WriteLine("Диапазон X от нуля до минус бесконечности, диапазон Y от нуля до бесконечности");
    if (valueX == 3)
        Console.WriteLine("Диапазон X и Y от нуля до минус бесконечности");
    if (valueX == 4)
        Console.WriteLine("Диапазон X от нуля до бесконечности, диапазон Y от нуля до минус бесконечности");

    Console.WriteLine("Для выхода из программы введите q");
}
