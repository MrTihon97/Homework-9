// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    var matrix = new int[rows, columns, depth];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             int k = 0;
            while (k < matrix.GetLength(2))
            {
               int element = new Random().Next(min, max + 1);
               if (FindElement(matrix, element)) continue;
                matrix[i, j, k] = element;
                k++;
            }
        }
    }
    return matrix;
}


void PrintMatrixWithIdex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k]);
                Console.Write($"({i},{j},{k})  ", 0, 1, 2);

            }

        }
        Console.WriteLine();
    }

}

        bool FindElement(int[,,] matrix, int el)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == el) return true;
            }
        }
    }
    return false;
}



int[,,] array2D = CreateMatrixRndInt(2, 2, 2, 10, 100);
PrintMatrixWithIdex(array2D);

