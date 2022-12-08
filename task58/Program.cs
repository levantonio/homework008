// Задача 58: Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)
{
    int[,] arr2D1 = new int[rows, columns]; //строка и колонка

    Random rnd = new Random(); //надо делать так
    for (int i = 0; i < arr2D1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D1.GetLength(1); j++)
        {
            arr2D1[i, j] = rnd.Next(min, max + 1); //i = индекс массива
        }
    }
    return arr2D1;
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

Console.Write("Введите число столбцов и колонок: ");
int a = Convert.ToInt32(Console.ReadLine());
int[,] resultmatrix = new int[a, a];
int[,] arr2D = CreateMatrixRndInt(a, a, 1, 2);
PrintMatrix(arr2D);
Console.WriteLine();
int[,] arr2D1 = CreateMatrixRndInt1(a, a, 1, 5);
PrintMatrix(arr2D1);
Console.WriteLine();

int sum = 0;

for (int i = 0; i < resultmatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultmatrix.GetLength(1); j++)
    {
        for (int k = 0; k < arr2D.GetLength(1); k++)
        {
            sum += arr2D[i, k] * arr2D1[k, j];
        }
        resultmatrix[i, j] = sum;
    }
}
PrintMatrix(resultmatrix);
