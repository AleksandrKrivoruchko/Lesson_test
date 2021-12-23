string[] week_days = { "Понедельник", "Вторник", "Среда", "Четверг",
                        "Пятница", "Суббота", "Воскресенье"};
Console.Write("Введите номер дня недели ");
try
{
    int week_day = int.Parse(Console.ReadLine());
    if (week_day < 8 && week_day > 0)
        Console.WriteLine("Вы ввели {0}й день это {1}", week_day, week_days[week_day - 1]);
    else
        Console.WriteLine("Нет такого дня недели {0}", week_day);
}
catch (FormatException)
{
    Console.WriteLine("Введено не целое число");
}
