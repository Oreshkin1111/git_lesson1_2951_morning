//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих
//чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

internal class partialProgram
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число A: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число B: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число C: ");
        int c = int.Parse(Console.ReadLine());

        int max = a;
        
        if (b > a)
            max = b;
        if (c > max)
            max = c;
        Console.WriteLine(max);
    }
}