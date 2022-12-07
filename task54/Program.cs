// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:


// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; //строка и колонка

    Random rnd = new Random(); //надо делать так
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1); //i = индекс массива
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 4}, "); //выводим последний элемент без запятой в конце!!!!!
            else
                Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("]");
    }
}

void ResMaxToMin(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {

                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int res = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];

                    matrix[i, k] = res;
                }
            }
        }
    }
    
}

int[,] arr2D = CreateMatrixRndInt(3, 10, 1, 10);
PrintMatrix(arr2D);
Console.WriteLine();
ResMaxToMin(arr2D);
PrintMatrix(arr2D);
