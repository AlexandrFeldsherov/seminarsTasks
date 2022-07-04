/*Задача 5: Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"*/
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int numberMeaning=(Math.Abs(number) * 2);
int numberSign = number / Math.Abs(number);
for (int i = 0; i <= numberMeaning; i++)
{
     Console.Write($"{-(number - (numberSign)*i)}, ");
}
