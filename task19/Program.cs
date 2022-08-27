void Palindrome()
{
    int number;
    int result = 0;
    Console.Write("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    int res = number;
    if (number > 9999 && number < 100000)
    {
        while (number > 0)
        {   
            result *= 10;
            result += number % 10;
            number /= 10;
        }
        Console.WriteLine(result);
        if (result == res) Console.WriteLine("Это палиндром ");
        else Console.WriteLine("Введите другое пятизначное число ");
    }
    else Console.WriteLine("Введите пятизначное число ");
}
try
{
   Palindrome();
}
catch
{
   Console.WriteLine("Нужно вводить цифры ");
} 
