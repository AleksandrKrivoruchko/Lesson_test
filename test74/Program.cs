// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
// Покажите все слова, состоящие из n букв,
// которые можно построить из букв этого алфавита
int PowerInt(int number, int power)
{
    int degree = 1;
    for (int i = 0; i < power; i++)
    {
        degree *= number;
    }
    return degree;
}

char[] charArray = { 'а', 'и', 'с', 'в' };
int countChars = 2;
int count = 0;
int iteration = PowerInt(countChars, charArray.Length);
string[] resultArray = new string[iteration];

for (int i = 0; i < charArray.Length; i++)
{
    for (int j = 0; j < charArray.Length; j++)
    {
        resultArray[count] = $"{charArray[i]}{charArray[j]}";
        count++;
    }
}
for (int i = 0; i < resultArray.Length; i++)
{
    Console.WriteLine($"{i}\t{resultArray[i]}");
}