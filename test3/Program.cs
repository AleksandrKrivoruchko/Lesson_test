using static System.Console;
using static NewMethod.MyMethod;

string[] weekDays = { "Понедельник", "Вторник", "Среда", "Четверг",
                        "Пятница", "Суббота", "Воскресенье"};
int weekDay = InputInt("Введите номер дня недели");
if (weekDay < 8 && weekDay > 0)
    Console.WriteLine("Вы ввели {0}й день это {1}", weekDay, weekDays[weekDay - 1]);
else
    Console.WriteLine("Нет такого дня недели {0}", weekDay);
