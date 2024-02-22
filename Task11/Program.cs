// Найдите произведения пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.
//
// Пример
//
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)


//функция
void Print_mas(int[] col)
{
  foreach (var item in col)
  {
    Console.Write($"{item} ");
  }
  Console.WriteLine();
}


//функция Random
int[] Random_mas(int[] col)
{
  for (int i = 0; i < col.Length; i++)
  {
    col[i] = new Random().Next(1,10);
  }
  return col;
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = Random_mas(new int[n]);

Print_mas(mas);

int[] mas_new = new int[mas.Length / 2];

for (int i = 0; i < mas_new.Length; i++)
{
  mas_new[i] = mas[i] * mas[mas.Length - 1 - i];
}

Print_mas(mas_new);