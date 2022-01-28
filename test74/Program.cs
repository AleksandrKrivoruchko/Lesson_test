// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
// Покажите все слова, состоящие из n букв,
// которые можно построить из букв этого алфавита

int n = 1;
void RecursivMakeWord(char[] charArray, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++}\t{new String(word)}");
        return;
    }
    for (int i = 0; i < charArray.Length; i++)
    {
        word[length] = charArray[i];
        RecursivMakeWord(charArray, word, length + 1);
    }
}

char[] charArray = { 'а', 'и', 'с', 'в' };
RecursivMakeWord(charArray, new char[3]);