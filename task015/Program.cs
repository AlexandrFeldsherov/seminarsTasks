/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int Weekend(int num)
{
    return num > 5 ? 1 : 0;
}
Console.Write("Введите цифру от 1 до 7 обозначающую номер дня недели по порядку:");
int number = Convert.ToInt32(Console.ReadLine());
while (1 > number ^ number > 7)
{
    Console.Write("Вы ввели цифру не от 1 до 7, a в недели 7 дней, попробуйте еще раз :");
    number = Convert.ToInt32(Console.ReadLine());
}
int numberOutput = Weekend(number);
string output = numberOutput > 0 ? "да" : "нет";
Console.WriteLine(output);