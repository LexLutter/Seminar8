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

int[,] SortRowsMatrix(int[,] matr) // Метод возвращает таблицу отсортированную в строках от большего к меньшему
{
    //int[,] SortMatrix = new int[3, 4];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int MaxPosicionRow = 0;
            int MaxPosicionCol = 0;
            int MaxValue = matr[i, j];
            for (int k = j; k < matr.GetLength(1); k++)
            {
                if (MaxValue <= matr[i, k])
                {
                    MaxValue = matr[i, k];
                    MaxPosicionRow = i;
                    MaxPosicionCol = k;
                }
            }
            
            if (matr[MaxPosicionRow, MaxPosicionCol] != matr[i, j])
            {
                matr[MaxPosicionRow, MaxPosicionCol] = matr[i, j];
                matr[i, j] = MaxValue;
            }
         
        }
    }
    return matr;
}

int[,] ResultMatrix = GetMatrix(3, 4, 0, 10);
PrintMatrix(ResultMatrix);
Console.WriteLine("");
PrintMatrix(SortRowsMatrix(ResultMatrix));