// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
using static System.Console;
using static NewMethod.MyMethod;
using static OneDimensionalArrays.WorkingWithArrays;
int len = InputInt("Введите количество элементов массива:");
int min = InputInt("Введите начальное число диапазона чисел массива:");
int max = InputInt("Введите конечное число диапазона чисел массива:");
int[] workArray = CreateArray(len, min, max);
PrintArray(workArray);

int sumPositive = SumPositiveElements(workArray);
int sumNegative = SumNegativeEkements(workArray);
WriteLine($"Сумма положтельных элементов массива равна {sumPositive}");
WriteLine($"Сумма отрицательных элементов массива равна {sumNegative}");
