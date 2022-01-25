// Написать программу вычисления функции Аккермана
// Определяется рекурсивно для неотрицательных чисел m и n
// A(m,n) =  n + 1,                 m = 0;
//           A(m - 1, 1),           m > 0, n = 0;
//           A(m - 1, A(m, n - 1)), m > 0, n > 0.
using static System.Console;

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}


int result = 0;
Write("n|m\t");
for (int i = 0; i < 5; i++)
{
    Write($"m={i}\t");
}
WriteLine();
for (int i = 0; i < 10; i++)
{
    Write($"n={i}\t");
    for (int j = 0; j < 5; j++)
    {

        if (j > 3 && i > 0) continue;
        result = AckermanFunction(j, i);
        Write(result + "\t");
    }
    WriteLine();
}