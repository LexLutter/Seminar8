
int[] GetArray(int size) // Одномерный массив с неповторяющимися двузначными числами 
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            if (array[i] == array[j]) i--;
        }
    }
    return array;
}

int[,,] GetMatrix(int rows, int cols, int deps, int[] Array) // Заполняем трехмерный массив
{
    int[,,] matrix = new int[rows, cols, deps];
    int PosicionArray = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = Array[PosicionArray];
                PosicionArray++;
            }
        }
    }
    return matrix; // вернули заполненную таблицу
}

void PrintMatrix(int[,,] matr) // Выводим на консоль массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write(matr[i, j, k] + "(" + i + "," + j + "," + k + ")" + " ");
                //Console.WriteLine($"{matr[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

int[,,] ThirdMatrix = GetMatrix(2, 2, 2, GetArray(90));
PrintMatrix(ThirdMatrix);