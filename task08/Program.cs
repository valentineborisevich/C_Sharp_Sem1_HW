// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 1)
{
    if (number % 2 == 0)
    {
        Console.Write(number + " ");
        number--;
    }
    else number--;
}
while (number < -1)
{
    if (number % 2 == 0)
    {
        Console.Write(number + " ");
        number++;
    }
    else number++;
}