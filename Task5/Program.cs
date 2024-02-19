// Наришите программу, которая принимает на вход трхзначное число и
// возводит вторуб цифру этого числа в степень, равную третьей цифре.


int num = new Random().Next(10,1000);
Console.WriteLine(num);
if(num <= 999 && num >= 100)
{
    int num_3 = num % 10;
    int num_2 = num / 10 % 10; //123 / 10-> 12 % 10 -> 2 
    Console.WriteLine(Math.Pow(num_2, num_3));
}
else
{
    Console.WriteLine("Число не трехзначное");
}
