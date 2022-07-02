/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/


int DellNumber(int num)
{
    num = num / 10 % 10;
    return num;
}
Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
while (number / 1000 == 0 ^ number / 100 != 0)
{
    Console.Write("Вы ввели не трехзначное число, попоробуйте еще раз: ");
    number = Convert.ToInt32(Console.ReadLine());
}
int secondDigitNumbe = Math.Abs(DellNumber(number));
Console.Write($"{number}->{secondDigitNumbe}");