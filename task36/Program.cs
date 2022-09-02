/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


Console.WriteLine("Введите целое натуральное число");
int N = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[N];
int sum = 0;
for (int i = 0; i < N; i++)
{
    numbers[i] = new Random().Next(-100, 100);
    if (i != N - 1) Console.Write($"{numbers[i]}, ");
    else Console.WriteLine($"{numbers[i]}");
}
void SumOdd()
{
    for (int i = 0; i < N; i++)
    {
        if (i % 2 == 1)
            sum = sum + numbers[i];
    }
    Console.WriteLine(sum);
}
SumOdd();