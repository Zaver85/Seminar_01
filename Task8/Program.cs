Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;
int conunt = 0;
while (m > 0)
{
  conunt++;
  m /= 10;
}

while (conunt > 0)
{
  Console.Write($"{n / Convert.ToInt32(Math.Pow(10, conunt - 1)) % 10}, ");
  conunt--;
}
