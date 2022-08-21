
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

if (b == a * a)
        {
            Console.Write("Да, число B является квадратом числа A ");
        }
if (a == 0)
        {
    Console.Write("ноль он и в квадрате ноль ");
}        
else
        {
            Console.Write("Нет, число B не является квадратом числа A ");
        }
