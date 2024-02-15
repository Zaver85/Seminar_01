// Напишите программу, которая на вход принимает два целых числа и проверяет, 
// является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
// int.Parse("6546161");
// Convert.ToInt32("1125546");
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

// if(number1 == number2 * number2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


if (number1 == Math.Pow(number2, 2))
{
    Console.WriteLine($"Квадрат числа {number2} равен {number1}");
}
else
{
    Console.WriteLine("Квадрат числа {1} НЕ равен {0}", number1, number2);
}

// Console.WriteLine("Значение переменной number1 равно " + number1 + "vxvxv");