Console.WriteLine("Введите номер дня недели: ");
int day_of_the_week = int.Parse(Console.ReadLine());

if (day_of_the_week == 1)
    {
        Console.WriteLine(" Понедельник ");
    }
if (day_of_the_week == 2)
    {
        Console.WriteLine(" Вторник ");
    }
if (day_of_the_week == 3)
    {
        Console.WriteLine(" Среда ");
    }
if (day_of_the_week == 4)
    {
        Console.WriteLine(" Четверг ");
    }
if (day_of_the_week == 5)
    {
        Console.WriteLine(" Пятница ");
    }
if (day_of_the_week == 6)
    {
        Console.WriteLine(" Суббота ");
    }
else
    {
        Console.WriteLine(" Воскресенье ");
    }
