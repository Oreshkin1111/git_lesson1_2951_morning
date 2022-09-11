/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
ввёл пользователь.
5
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M), 
а подсчет количества чисел производится после того, как пользователь не ввел информацию 
и нажал Enter. */

Console.WriteLine("Введите целое натуральное число");
int N = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[N];
int sum = 0;
void GenerateArray()
{
    for (int i = 0; i < N; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
        if (i != N - 1) Console.Write($"{numbers[i]}, ");
        else Console.WriteLine($"{numbers[i]}");
    }
}
void CountPositiveNum()
{
    for (int i = 0; i < N; i++)
    {
        if (numbers[i] > 0)
        {
            sum += 1;
        }

    }
    Console.WriteLine(sum);
}
GenerateArray();
CountPositiveNum();
