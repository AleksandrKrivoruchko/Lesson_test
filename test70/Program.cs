// Найти сумму цифр числа
int GetSumOfDigits(int number)
{
    if (number / 10 > 0)
        return number % 10 + GetSumOfDigits(number / 10);
    else
        return number % 10;
}

Console.Write($"Введите число: ");
string answer = Console.ReadLine() ?? string.Empty;
int number = 0;
bool isIntNumber = int.TryParse(answer, out number);
if (!isIntNumber)
{
    Console.WriteLine($"Неверный ввод {answer}");
    Environment.Exit(1);
}
if (number < 0)
    number = -number;
int sumOfDigits = GetSumOfDigits(number);
Console.WriteLine($"Введено число {number} сумма цифр числа {sumOfDigits}");