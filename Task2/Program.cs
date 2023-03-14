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

void RowMinSum(int[,] matr) // Метод выводит номер строки с наименьшей суммой ее элементов
{
    int row = 0;
    int MinSum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        int Sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Sum += matr[i, j];
        }
        //Console.Write($"{Sum} \n");
        if (i == 0) MinSum = Sum;
        if (Sum < MinSum)
        {
            row = i + 1;
            MinSum = Sum;
        }
    }
    Console.Write($"В {row} строке содержится наименьшая сумма элементов.");
}

int[,] ResultMatrix = GetMatrix(4, 4, 0, 10);
PrintMatrix(ResultMatrix);
RowMinSum(ResultMatrix);