﻿// 
using static System.Console;
using static NewMethod.MyMethod;

//t number = InputInt("Введите число");
double value = InputDouble("Введите число");
double value1 = InputDouble("Введите второе число");
double newValue = PowerNumber(value);
WriteLine($"Квадрат числа {value} равен {newValue}");
bool flag = IsSquareNumber(value, value1);
if (flag)
{
    WriteLine($"Число {value} является квадратом числа {value1}");
}
else
{
    WriteLine($"Число {value} не является квадратои числа {value1}");
}
//Test(number, value);
