using static System.Console;
// Определить сколько чисел больше 0 введено с клавиатуры
string MyInput(string msg)
{
    WriteLine(msg);
    return ReadLine() ?? string.Empty;
}

int positive = 0;
string[] str = { "чисел", "число", "числа" };
string answer = string.Empty;
while (answer != "q")
{
    answer = MyInput("Введите число (для завершения введите q");
    if (double.TryParse(answer, out double value))
        if (value > 0)
            positive++;
}
if (positive % 10 == 1)
    answer = str[1];
else if (positive % 10 > 1 && positive % 10 < 5)
    answer = str[2];
else
    answer = str[0];

WriteLine($"С клавиатуры введено {positive} {answer} больше нуля");