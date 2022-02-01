// Есть число N. Сколько групп M можно получить при разбиении всех чисел
// на группы, так чтобы в одной группе все числа были взаимно просты.
// Найти M при заданном N и получить одно из разбиений на группы N <= 10^20.

int NumberOfGroups(decimal range)
{
    int count = 0;
    decimal temp = range;
    Console.WriteLine(temp);
    while (temp / 2 > 1)
    {
        if (temp > 1024)
        {
            temp = temp / 1024;
            count += 10;
        }
        temp = temp / 2;
        count++;
        //Console.WriteLine($"{temp}  {count}");
    }
    return count;
}
decimal N = 10000000000000000000;
Console.WriteLine(NumberOfGroups(N));
Console.WriteLine(NumberOfGroups(10024));





