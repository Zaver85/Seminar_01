//  Дано натуральное трёхзначное число. Создайте массив, состоящий из 
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м. 
// Пример
// 456 => [6 5 4]
//781 => [1 8 7]

void Print_mas(int[] col)
{
  foreach (var item in col)
  {
    Console.Write($"{item} ");
  }
  Console.WriteLine();
}

int n = new Random().Next(100, 1000);
Console.WriteLine(n);

int[] mas = new int[3];
for (int i = 0; i < mas.Lenght; i++)
{
  mas[i] = n % 10;
  n /= 10;
}
Print_mas(mas);
