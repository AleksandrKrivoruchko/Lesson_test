// Написать программу возведения числа А в целую стень B
double RecursionPositivePowerInt(double number, int power)
{
    if (power == 0) return 1;
    return number * RecursionPositivePowerInt(number, power - 1);
}


Console.Write("Введите число: ");
double number = 0;
string inputNumber = Console.ReadLine() ?? string.Empty;
bool isNumber = double.TryParse(inputNumber, out number);
Console.Write("Введите степень: ");
int power = 0;
inputNumber = Console.ReadLine() ?? string.Empty;
isNumber = int.TryParse(inputNumber, out power);
if (power > 0)
    Console.WriteLine($"{RecursionPositivePowerInt(number, power)}");
else
    Console.WriteLine($"{1 / RecursionPositivePowerInt(number, -power)}");