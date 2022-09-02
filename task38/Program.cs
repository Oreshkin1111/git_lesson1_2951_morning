/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.WriteLine("Введите целое натуральное число");
int N = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double[N];
double max = 0;
double min = numbers[0];
for (int i = 0; i < N; i++)
{
    numbers[i] = new Random().Next(0, 100);
    if (i != N - 1) Console.Write($"{numbers[i]}, ");
    else Console.WriteLine($"{numbers[i]}");
}
void Difference()
{
    void MaxValue()
    {
        N = numbers.Length;
        max = numbers[0];
        for (int j = 0; j < N; j++)
        {
            if (numbers[j] > max)
            {
                max = numbers[j];
            }
        }
        Console.WriteLine("Максимальное число: " + max);
    }
    void MinValue()
    {
        min = numbers[0];
        for (int j = 0; j < N; j++)
        {
            if (numbers[j] < min)
            {
                min = numbers[j];
            }
        }
        Console.WriteLine("Минимальное число: " + min);
    }
    MaxValue();
    MinValue();
    Console.WriteLine("разность между максимальным и минимальным числом массива: " + $"{max - min}");
}
Difference();
