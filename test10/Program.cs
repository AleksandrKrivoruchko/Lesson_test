//Показать вторую цифру трёхзначного числа
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
string number_in = String.Empty;
while (number_in != "q")
{

    Console.Write("Введите трёхзначное целое число: ");
    number_in = Console.ReadLine() ?? String.Empty;
    if (number_in == "q")
    {
        Console.WriteLine("До свидания!");
        break;
    }
    if (int.TryParse(number_in, out int number) && number > 99 && number < 999)
    {
        Console.WriteLine(divide_number(number, 2));
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
        Console.WriteLine(number_in);
    }
}