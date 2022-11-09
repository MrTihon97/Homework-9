// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 
// 3 2 | 

// 3 4 |
// 3 3 |
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}  ");
            else Console.Write($"{matrix[i, j],3}  ");
        }
        Console.WriteLine("|");
    }
}

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix2(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}  ");
            else Console.Write($"{matrix[i, j],3}  ");
        }
        Console.WriteLine("|");
    }
}

int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{

    var resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1))
    {
        System.Console.WriteLine("Ошибка! Матрицы не перемножаться");
    }
    else
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
                Console.Write($"  {resultMatrix[i, j]}  ");
            }
            Console.WriteLine();
        }

    return resultMatrix;
}



int[,] array2D = CreateMatrixRndInt(2, 2, 1, 6);
PrintMatrix(array2D);
System.Console.WriteLine();
int[,] array22D = CreateMatrixRndInt2(2, 2, 1, 6);
PrintMatrix2(array22D);

System.Console.WriteLine("Произведения матриц: ");
MultiplicationMatrix(array2D, array22D);
