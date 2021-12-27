// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.Clear();
bool[] value1 = { true, false };
bool[] value2 = { true, false };
Console.WriteLine("  X      Y      !(X || Y)    !X && !Y");
for (int i = 0; i < value1.Length; i++)
{
    for (int j = 0; j < value2.Length; j++)
    {
        Console.Write($"{value1[i]}     {value2[j]}     {!(value1[i] || value2[j])}     {!value1[i] && !value2[j]}");
        Console.WriteLine();
    }
}