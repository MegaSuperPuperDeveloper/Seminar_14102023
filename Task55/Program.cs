// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] PullMatrix(int[,] matrix) // Функция заполняет двумерный массив.
{
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 15);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // Функция выводит двумерный массив.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j], 6} ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}

int[,] ReplaceLineColumn(int[,] matrix) // Функция меняет строки и столбцы местами.
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
    return matrix;
}

var rnd = new Random().Next(3, 5);
int[,] matrix =  new int[rnd, rnd];
PullMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ReplaceLineColumn(matrix);
PrintMatrix(matrix);