/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine("Введите целое натуральное число");
int N = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[N];
int count = 0;
for (int i = 0; i < N; i++)
{
    numbers[i] = new Random().Next(100, 1000);
    if (i != N - 1) Console.Write($"{numbers[i]}, ");
    else Console.WriteLine($"{numbers[i]}");
}
void CountEvenNum()
{
    for (int i = 0; i < N; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

CountEvenNum();
