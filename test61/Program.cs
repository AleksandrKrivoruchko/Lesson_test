// Найти произведение двух матриц
using static System.Console;
int[,] CreateTwoDimensionArray(int row, int column, int min, int max)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = rnd.Next(min, max + 1);
    return result;
}

void PrintTwoDimensionArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Write($"{array[i, j]}\t");
        WriteLine();
    }
    WriteLine();
}

int[,] ProductMatrix(int[,] matrix1, int[,] marix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), marix2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int[] tmpRow = GetMatrixRow(matrix1, i);
            int[] tmpColumn = GetMatrixColumn(marix2, j);
            resultMatrix[i, j] = CalculationMatrixElement(tmpRow, tmpColumn);
        }
    return resultMatrix;
}

int[] GetMatrixRow(int[,] array, int indexRow)
{
    int[] tempRow = new int[array.GetLength(1)];
    for (int i = 0; i < tempRow.Length; i++)
        tempRow[i] = array[indexRow, i];
    return tempRow;
}

int[] GetMatrixColumn(int[,] array, int indexColumn)
{
    int[] tempColumn = new int[array.GetLength(0)];
    for (int i = 0; i < tempColumn.Length; i++)
        tempColumn[i] = array[i, indexColumn];
    return tempColumn;
}

int CalculationMatrixElement(int[] matrixRow, int[] matrixColumn)
{
    int element = 0;
    for (int i = 0; i < matrixRow.Length; i++)
        element += matrixRow[i] * matrixColumn[i];
    return element;
}

int[,] TestMatrix(bool cursor)
{
    int[,] test = new int[2, 4];
    Random rnd = new Random();
    for (int i = 0; i < test.GetLength(1); i++)
        test[0, i] = rnd.Next(2, 5);
    if (cursor)
        test[0, 1] = test[0, 2];
    for (int i = 0; i < test.GetLength(1); i++)
        test[1, i] = rnd.Next(-10, 10);
    if (test[1, 0] > test[1, 1])
    {
        int tmp = test[1, 0];
        test[1, 0] = test[1, 1];
        test[1, 1] = tmp;
    }
    if (test[1, 2] > test[1, 3])
    {
        int tmp = test[1, 2];
        test[1, 2] = test[1, 3];
        test[1, 3] = tmp;
    }
    return test;
}

int[,] test = TestMatrix(false);

int[,] matrixA = CreateTwoDimensionArray(test[0, 0], test[0, 1], test[1, 0], test[1, 1]);
PrintTwoDimensionArray(matrixA);
int[,] matrixB = CreateTwoDimensionArray(test[0, 2], test[0, 3], test[1, 2], test[1, 3]);
PrintTwoDimensionArray(matrixB);
if (matrixA.GetLength(1) == matrixB.GetLength(0))
{
    int[,] matrixC = ProductMatrix(matrixA, matrixB);
    PrintTwoDimensionArray(matrixC);
}
else
{
    WriteLine($"Произведение матрицы с количеством столбцов {matrixA.GetLength(1)} ");
    WriteLine($"с матрицей с количеством строк {matrixB.GetLength(0)} невозможно");
}