int[,] GetMatrix(int rows, int cols, int MinValue, int MaxValue) // Заполняем двумерный массив
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++) // либо i < rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return matrix; // вернули заполненную таблицу
}

void PrintMatrix(int[,] matr) // Выводим на консоль массив
{
    for (int i = 0; i < matr.GetLength(0); i++) // либо i < rows
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] MultMatr(int[,] FirstMatr, int[,] SecondMatr) // Метод возвращает матрицу равную произведению 2-х матриц
{
    int[,] ResultMatr = new int[FirstMatr.GetLength(0), SecondMatr.GetLength(1)];
    for (int i = 0; i < FirstMatr.GetLength(0); i++)
    {
        for (int j = 0; j < SecondMatr.GetLength(1); j++)
        {
            ResultMatr[i, j] = 0;
            for (int k = 0; k < FirstMatr.GetLength(1); k++)
            {
                ResultMatr[i, j] = ResultMatr[i, j] + FirstMatr[i, k] * SecondMatr[k, j];
            }

        }
    }
   return ResultMatr;
}

int[,] FirstMatrix = GetMatrix(3, 2, 0, 10);
int[,] SecondMatrix = GetMatrix(2, 3, 0, 10);
PrintMatrix(FirstMatrix);
Console.WriteLine("");
PrintMatrix(SecondMatrix);
Console.WriteLine("");
PrintMatrix(MultMatr(FirstMatrix, SecondMatrix));


