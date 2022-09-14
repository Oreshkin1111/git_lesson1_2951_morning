/* Задача 50. Напишите программу, которая на вход принимает  число и ищет его в двумерном массиве, 
и либо возвращает значение этого элемента если он есть в данном массиве или же указывает, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
double [,]arr = new double [n, m];
void FillArray()
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(0, 100);
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FoundNumber()
{
Console.WriteLine("Введите число: ");
double x = Convert.ToUInt32(Console.ReadLine());
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (x == arr[i, j]) Console.WriteLine($"{x}, {i}, {j}");
        }
    }
}
FillArray();
try
{
    FoundNumber();
}
catch (System.Exception)
{
    
    throw;
}