// Определить, присутствует ли в заданном массиве, некоторое число 

/*int MyInput(string msg)
{
    Console.Write(msg);
    string answer = Console.ReadLine() ?? string.Empty;
    bool flag = int.TryParse(answer, out int range);
    if (flag)
        return range;
    return -1;
}*/
void FillAndPrintArray(int[] array, int Min, int Max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(Min, Max + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

/*bool IsNumber(int[] array, int element)
{
    foreach (int el in array)
        if (element == el)
            return true;
    return false;
}*/

(int, int) IsChet(int[] array)
{
    int chetnumber = 0;
    int nechet = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            chetnumber++;
        else
            nechet++;
    }
    return (chetnumber, nechet);
}

int ColNumber(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
            number++;
    }
    return number;
}

int Sum(int[] array)
{
    int number = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        number += array[i];
    }
    return number;
}

int[] array = new int[10];

FillAndPrintArray(array, 0, 10);
/*Console.WriteLine();
int answer = MyInput("Введите число: ");
if (answer == -1) 1
    Console.WriteLine("Неверный ввод");
else
{
    string msg = IsNumber(array, answer) ? "Элемент в массиве содержится" : "Элемента нет";
    Console.WriteLine(msg);
}*/

(int chet, int nechet) = IsChet(array);
Console.WriteLine($"Четных чисел {chet},нечентных чисел {nechet}");

Console.WriteLine($"Количество цифр в диапозоне [10, 99] {ColNumber(array)}");
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных индексах {Sum(array)}");