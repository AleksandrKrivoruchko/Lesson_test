// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, 
//причем X ≠ 0 и Y ≠ 0
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
    int valueX = my_read_int("Введите X: ");
    if (valueX == -1)
    {
        Console.WriteLine("Нет такого целого числа");
        continue;
    }
    int valueY = my_read_int("Введите Y: ");
    if (valueY == -1)
    {
        Console.WriteLine("Нет такого целого числа");
        continue;
    }

    if (valueX == 0 || valueY == 0)
        Console.WriteLine($"Точка ({valueX}, {valueY}) находится на одной из осей");
    if (valueX > 0 && valueY > 0)
        Console.WriteLine($"Точка ({valueX}, {valueY}) находится в первой четверти");
    if (valueX < 0 && valueY > 0)
        Console.WriteLine($"Точка ({valueX}, {valueY}) находится во второй четверти");
    if (valueX < 0 && valueY < 0)
        Console.WriteLine($"Точка ({valueX}, {valueY}) находится в третей четверти");
    if (valueX > 0 && valueY < 0)
        Console.WriteLine($"Точка ({valueX}, {valueY}) находится в четвертой четверти");

    Console.WriteLine("Для выхода из программы введите q");
}
