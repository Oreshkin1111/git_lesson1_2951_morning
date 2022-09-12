/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 10);
        }
    }
}
double[,] matr = new double[3, 4];
double[,] matrix = new double[3, 4];

void PrintArray(double[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        Console.WriteLine();
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]}   ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
FillArray(matr);
PrintArray(matr);