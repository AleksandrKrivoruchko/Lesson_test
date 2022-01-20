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

int[,] matrixA = CreateTwoDimensionArray(2, 3, 0, 3);
PrintTwoDimensionArray(matrixA);
int[,] matrixB = CreateTwoDimensionArray(3, 2, -2, 5);
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