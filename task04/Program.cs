﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter numberC");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (max < numberB) max = numberB;
if (max < numberC) max = numberC;
Console.WriteLine(max);