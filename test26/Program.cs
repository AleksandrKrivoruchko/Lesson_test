// Возведите число А в натуральную степень B используя цикл

int my_input(string msg, int marker=0)
{
    Console.Write(msg);
    string temp_str = Console.ReadLine() ?? String.Empty;
    bool flag = int.TryParse(temp_str, out int value);
    if(!flag || (marker > 0 && value < 0))
    {
        Console.WriteLine("Неверный ввод");
        return -1;
    }
    return value;
}

bool answer()
{
    Console.WriteLine("Введите q для выхода из программы, для продолжения нажмите Enter.");
    string flag = Console.ReadLine() ?? String.Empty;
    if(flag == "q")
        return false;
    return true;
}

while(answer())
{
    int value = my_input("Введите число: ");
    if(value == -1)
        continue;
    int power = my_input("Введите степень: ", 1);
    if(power == -1)
        continue;
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= value;
    }
    Console.WriteLine(result);
}