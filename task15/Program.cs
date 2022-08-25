/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */
void WeekendOrNotWeekend()
{
    Console.WriteLine("Введите номер дня недели: ");
    int day_of_the_week = int.Parse(Console.ReadLine());
    if (day_of_the_week < 6)
    {
        Console.WriteLine("упс, не выходной :(  ");
    }
    else if (day_of_the_week == 6 ^ day_of_the_week == 7)
    {
        Console.WriteLine("ура, выходной!!!!! :) ");
    }
    else
    {
        Console.WriteLine("Введите число от 1 до 7 ");
    }
}
WeekendOrNotWeekend();