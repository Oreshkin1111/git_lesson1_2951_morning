/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
int number = 0;
int result = 0;
Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < number + 10; i++)
    {
        //result *= 10;
        result += number % 10;
        number /= 10;
    }
Console.WriteLine(result);