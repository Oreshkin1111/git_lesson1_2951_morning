/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве. 

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

 double DistanceAB3D()
{   
    Console.WriteLine("Введите координату x для точки A ");
    int Ax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y для точки A ");
    int Ay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y для точки A ");
    int Az = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату x для точки B ");
    int Bx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y для точки B ");
    int By = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y для точки B ");
    int Bz = Convert.ToInt32(Console.ReadLine());

    double distance = Math.Sqrt((Math.Pow((Ax - Bx), 2)) + Math.Pow((Ay - By), 2) + 
                      Math.Pow((Az - Bz), 2));
    return distance;
}
Console.WriteLine(DistanceAB3D());