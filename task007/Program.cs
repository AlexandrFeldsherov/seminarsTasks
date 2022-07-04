/*Задача 7: Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8*/

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
while ((int)Math.Log10(Math.Abs(number))!=2)
{
    Console.Write("Вы ввели не трехзначное число, попоробуйте еще раз: ");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Math.Abs(number%10));