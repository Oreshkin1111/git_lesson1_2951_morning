﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число, 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine());
int x1 = x / 10;
x = x1 % 10;
//x = x2 % 10;
Console.WriteLine(x);
