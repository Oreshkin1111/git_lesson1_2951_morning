Console.WriteLine("Введите номер дня недели: ");
int day_of_the_week = int.Parse(Console.ReadLine());

if(day_of_the_week == 1) Console.WriteLine("понедельник");
if(day_of_the_week == 2) Console.WriteLine("вторник");
if(day_of_the_week == 3) Console.WriteLine("среда");
if(day_of_the_week == 4) Console.WriteLine("четверг");
if(day_of_the_week == 5) Console.WriteLine("пятница");
if(day_of_the_week == 6) Console.WriteLine("суббота");
if(day_of_the_week == 7) Console.WriteLine("воскресенье");
if(day_of_the_week > 7) Console.WriteLine("Введите число от 1 до 7");
