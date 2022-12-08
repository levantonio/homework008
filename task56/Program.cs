// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка вхождения

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

void SumStringMatrix(int[,] matrix)
{
    int sumrowres = 0;
    int resul = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sumrowres += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum += matrix[i, j];
        if (sum < sumrowres)
        {
            sumrowres = sum;
            resul = i;
        }
        sum = 0;
    }

    Console.Write($"Лидирует -> {resul + 1} строка, с результатом: {sumrowres}!");
}

int[,] arr2D = CreateMatrixRndInt(3, 5, 1, 5);
PrintMatrix(arr2D);
Console.WriteLine();

SumStringMatrix(arr2D);
