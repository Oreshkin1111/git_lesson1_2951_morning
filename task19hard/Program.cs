/* Задача 19 HARD
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

void Palindrome()
{
    int number;
    int result = 0;
    Console.Write("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
    int res = number;
    if (number > 0)
    {
        while (number > 0)
        {   
            result *= 10;
            result += number % 10;
            number /= 10;
        }
        Console.WriteLine(result);
        if (result == res) Console.WriteLine("Это палиндром! ");
        else Console.WriteLine("Это не палиндром!");
    }
    else Console.WriteLine("Это не палиндром!");
}
try
{
   Palindrome();
}
catch
{
   Console.WriteLine("Нужно вводить цифры! ");
} 
