// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("max is " + numberA);
    Console.WriteLine("min is " + numberB);
}

else
{
    Console.WriteLine("max is " + numberB);
    Console.WriteLine("min is " + numberA);
}