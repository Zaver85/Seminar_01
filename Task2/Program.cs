// Напишите программу, которая на вход принимает целое число N, а на выходе 
// показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    num = num * (-1);
}
int index = -num;
while (index <= num)
{
    Console.Write($"{index} ");
    index++;
}