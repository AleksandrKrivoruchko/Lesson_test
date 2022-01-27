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

string RecursivMakeWord(char[] charArray, int countChar)
{
    string result = string.Empty;
    if (countChar == 0) return string.Empty;
    for (int i = 0; i < charArray.Length; i++)
    {
        result = result + $"{charArray[i]}" + RecursivMakeWord(charArray, countChar - 1);
    }
    return result;
}

// string[] MakeWord(char[] charArray, int indexChar, int countChar)
// {
//     string[] resultWords = new string[charArray.Length];
//     int count = 0;
//     int indexWord = 0;
//     resultWords[indexWord] += $"{charArray[indexChar]}";
//     for (int i = 0; i < charArray.Length; i++)
//     {
//         if (count < countChar - 1)
//         {
//             resultWords[indexWord] = resultWords[indexWord] + $"{charArray[i]}";
//             count++;
//         }
//         else
//         {
//             Console.WriteLine(resultWords[indexWord]);
//             indexWord++;
//             count = 0;
//             resultWords[indexWord] = resultWords[indexWord] + $"{charArray[indexChar]}";
//             i--;
//         }
//     }
//     return resultWords;
// }

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

string str = RecursivMakeWord(charArray, 2);
Console.WriteLine(str);

// string[] universalArray = MakeWord(charArray, 0, 3);

// for (int i = 0; i < universalArray.Length; i++)
// {
//     Console.WriteLine($"{i}\t{universalArray[i]}");
// }