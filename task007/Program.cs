/*Задача 7: Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8*/

Console.Write("Введите трехзначное число ");
string number = Console.ReadLine();
int numberOfCharacters = number.Length;

while (numberOfCharacters != 3)
{
    Console.Write("Вы ввели не трехзначное число, попоробуйте еще раз: ");
    number = Console.ReadLine();
    numberOfCharacters = number.Length;
}
int outputNumber = Convert.ToInt32(number.Remove(0, 2));
Console.WriteLine(outputNumber);