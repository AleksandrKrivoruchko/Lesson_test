// В Указанном массиве вещественных чисел найдите разницу
// между максимальным и минимальным элементом
void FillArrayDouble(double[] darray, int range)
{
    int mark = 0;
    Random rnd = new Random();
    for (int i = 0; i < darray.Length; i++)
    {
        mark = rnd.Next(0, 2);
        if (mark == 0)
            darray[i] = rnd.NextDouble() * range;
        else
            darray[i] = rnd.NextDouble() * -range;
    }
}

void PrintArray(double[] darray)
{
    int k = 1;
    for (int i = 0; i < darray.Length; i++)
    {
        Console.Write($"{darray[i],7:N2}\t");
        if (k % 7 == 0)
            Console.WriteLine();
        k++;
    }
    Console.WriteLine();
}

void Difference(double[] darray, int[] min_max)
{
    for (int i = 0; i < darray.Length; i++)
    {
        if (darray[i] > darray[min_max[1]])
            min_max[1] = i;
        if (darray[i] < darray[min_max[0]])
            min_max[0] = i;
    }
}

double[] darray = new double[20];
int[] min_max = { 0, 0 };
FillArrayDouble(darray, 100);
PrintArray(darray);
Difference(darray, min_max);
Console.WriteLine($"{darray[min_max[1]]:N2} - {darray[min_max[0]]:N2} = {darray[min_max[1]] - darray[min_max[0]]:N2}");