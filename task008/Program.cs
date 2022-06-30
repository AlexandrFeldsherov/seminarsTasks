/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Ведите число ");
int number = Convert.ToInt32(Console.ReadLine());
for (int outputNumber = 1; outputNumber <= number; outputNumber++)
{
    int remains = outputNumber % 2;
    if (remains == 0) Console.Write($"{outputNumber}, ");
}