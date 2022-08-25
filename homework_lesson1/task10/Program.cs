//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
void ShowThirdDigit()
{
    Console.WriteLine("Введите число больше 99: ");
    string s = Console.ReadLine();
    char[] dig_mas = new char[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        dig_mas[i] = s[i];
        Console.Write(dig_mas[i] + ", ");
    }
    if (s.Length > 2)
    {
        Console.WriteLine("Третья цифра числа: " + dig_mas[2]);
    }
    else
    {
        Console.WriteLine("Вы ввели число меньше 100");
    }
}

ShowThirdDigit();





