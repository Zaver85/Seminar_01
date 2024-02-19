Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// // num < 100 -> третей цифры нет
// // num = 5789 / 10
// // num = 57
// int num2 = 0;
// if (num < 0) num = -num;

// if (num < 100)
// {
//     Console.WriteLine("третей цифры нет");
// }
// else
// {
//     while (num > 999)
//     {
//         num /= 10; // num = num / 10
//     }
//     Console.WriteLine(num);
//     num2 = num % 10;
//     Console.WriteLine(num2);
// }

string num = Console.ReadLine()!;
if (num.Length < 3)
{
    Console.WriteLine("третей цифры нет");
}
else
{
    Console.WriteLine(num[2]);
}
