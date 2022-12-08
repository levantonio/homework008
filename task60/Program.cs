// Задача 60. ...Сформируйте трёхмерный массив из
// неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:

// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateCubeRndIntMatrix(int rows, int columns, int depth, int min, int max)
{
    int[,,] cubematrix = new int[rows, columns, depth]; //строка и колонка

    int rnd = 44;
    for (int i = 0; i < cubematrix.GetLength(0); i++)
    {
        for (int j = 0; j < cubematrix.GetLength(1); j++)
        {
            for (int k = 0; k < cubematrix.GetLength(2); k++)
            {
                cubematrix[i, j, k] = rnd++; 
            }
        }
    }
    return cubematrix;
}

void PrintCubeMatrix(int[,,] cubematrix)
{
    for (int i = 0; i < cubematrix.GetLength(0); i++)
    {
        Console.Write("[     ");
        for (int j = 0; j < cubematrix.GetLength(1); j++)
        {
            for (int k = 0; k < cubematrix.GetLength(2); k++)
            {
                Console.Write(cubematrix[i, j, k]); // выводит значения
                Console.Write($" ({i},{j},{k})    "); //Выводит индексы
            }
        }
        Console.WriteLine("]");
    }
}

int[,,] array3D = CreateCubeRndIntMatrix(2, 2, 2, 10, 99);
PrintCubeMatrix(array3D);
