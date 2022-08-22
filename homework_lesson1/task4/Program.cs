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