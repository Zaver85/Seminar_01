int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 % num2 != 0)
{
  Console.WriteLine($"Число {num2} не является кратным {num1}! Остаток от деления: {num1 % num2}");
}
else
{
  Console.WriteLine($"Число {num2} является кратным {num1}!");
}
