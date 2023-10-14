// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] PullMatrix(int[,] matrix) { // Функция заполняет двумерный массив.
    var rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = rnd.Next(1, 15);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) { // Функция выводит двумерный массив.
    for(int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ReverseMatrix(int[,] matrix) { // Функция меняет местами 1ую и 2ую строку.
    for (int j = 0; j < matrix.GetLength(1); j++) {
        int temp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
    return matrix;
}

var rnd = new Random().Next(3, 5);
int[,] matrix =  new int[rnd, rnd];
PullMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ReverseMatrix(matrix);
PrintMatrix(matrix);