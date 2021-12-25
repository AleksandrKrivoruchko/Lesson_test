//Удалить вторую цифру трёхзначного числа
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
    Console.WriteLine("Для продолжения нажмите Enter");
    flag = Console.ReadLine() ?? String.Empty;
    if (flag == "q")
        break;
    Console.WriteLine("Введите целое трёхзначное число:");
    string number_in = Console.ReadLine() ?? String.Empty;
    if (int.TryParse(number_in, out int number))
    {
        if (number < 100 || number > 999)
        {
            Console.WriteLine($"Число {number} не трёхзначное");
            continue;
        }
        else
        {
            number = divide_number(number, 3) * 10 + divide_number(number, 1);
            Console.WriteLine(number);
        }
    }
    else
    {
        Console.WriteLine($"{number_in} - не является целым числом");
    }
}