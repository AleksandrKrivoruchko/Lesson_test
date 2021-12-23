double my_square(double x) 
{
    return x*x;
}

Console.Write("Введите число  ");
try
{
    double x = double.Parse(Console.ReadLine());
    double square_x = my_square(x);
    Console.Write("Квадрат числа " + x + " = " + square_x);
}
catch(FormatException)
{
    Console.WriteLine("Неправильный ввод!");
}