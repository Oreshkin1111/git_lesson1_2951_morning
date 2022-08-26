/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

 void TableOfSquares()
{
    Console.WriteLine("Введите число N ");
    double N = Convert.ToInt32(Console.ReadLine());
    if (N > 1)
    {
        for (double i = 1; i <= N; i++)
        {
            double index = Math.Pow(i, 3);
            Console.Write(index + ", ");
        }
    }
    else Console.WriteLine("Введите положительное число");
}
try
{
    TableOfSquares();
}
catch
{
    Console.WriteLine("Введите положительное число");
} 