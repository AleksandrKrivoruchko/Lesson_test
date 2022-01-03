// Найти сумму чисел от 1 до А

int my_input(string msg)
{
    Console.Write(msg);
    string temp_str = Console.ReadLine() ?? String.Empty;
    bool flag = int.TryParse(temp_str, out int value);
    if(!flag || value < 0)
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
    int sum = 0;
    for(int i = 1; i <= value; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine(sum);
    Console.WriteLine(value*(value + 1)/2);
}