Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());

if(a * a == b)
{
    Console.WriteLine("число B является квадратом числа A");
}
else if(a == 0)
{
    Console.WriteLine("0 является квадратом 0");
}
else
{
    Console.WriteLine("число B не является квадратом числа A");
}
