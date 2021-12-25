//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.
int divide_number(int value, int position)
{
    int temp = value;
    for (int i = 1; i < position; i++)
    {
        temp = temp / 10;
    }
    temp = temp % 10;
    return temp;
}

string flag = String.Empty;
while (flag != "q")
{
    Console.WriteLine("Для выхода из программы введите q");
    flag = Console.ReadLine() ?? String.Empty;
    int number = new Random().Next(10, 100);
    int first = divide_number(number, 1);
    int second = divide_number(number, 2);
    if (first > second)
        Console.WriteLine($"В числе {number} наибольшая цифра {first}");
    else if (first == second)
        Console.WriteLine($"В числе {number} цифры равны");
    else
        Console.WriteLine($"В числе {number} наибольшая цифра {second}");
}
