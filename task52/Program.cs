/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3 */

Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
double [,]arr = new double [n, m];
double []sum = new double [m];
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
void AverageColumn()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum[i] += arr[j, i];
        }
    }
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        Console.Write(sum[i] / n + ";\t");
    }
}
Console.WriteLine();
FillArray();
AverageColumn();
Console.WriteLine();