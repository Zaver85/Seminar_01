///Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
///Программа должна выдать ответ: Да/Нет.
//Примеры
//[1 3 4 19 3], 8 => Нет
//[-4 3 4 1], 3 => Да

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
int[] mas_2 = new int[n];
// Console.WriteLine(mas);


//whihe
int ind = 0;
while (ind < mas.Length)
{
  Console.Write($"{mas[ind]} ");
  ind++;
}
Console.WriteLine();

//for
for (int i = 0; i < mas.Length; i++)
{
  Console.Write($"{mas[i]} ");
}
Console.WriteLine();

//foreach
foreach (var item in mas)
{
  Console.Write($"{item} ");
}
Console.WriteLine();

//функция
void Print_mas(int[] col)
{
  foreach (var item in col)
  {
    Console.Write($"{item} ");
  }
  Console.WriteLine();
}

Print_mas(mas);
//функция Random
int[] Random_mas(int[] col)
{
  for (int i = 0; i < col.Length; i++)
  {
    col[i] = new Random().Next(1,10);
  }
  return col;
}

int[] new_mas = Random_mas(mas);
Print_mas(new_mas);

int[] ReadLine_mas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
  {
    Console.WriteLine($"Введите {i} элемент массива");
    col[i] = Convert.ToInt32(Console.ReadLine());
  }
  return col;
}

int[] new_mas_2 = ReadLine_mas(mas_2);
Print_mas(new_mas_2);


Console.Write("Введите искомое число: ");
int m = Convert.ToInt32(Console.ReadLine());

int c_R = 0;
int c_C = 0;

for (int i = 0; i < mas.Length; i++)
{
  if(new_mas[i] == m)
  {
    c_R ++;
  } 
  if(new_mas_2[i] == m) 
  {
    c_C ++;
  }
}

if (c_R == 0 && c_C == 0)
{
  Console.WriteLine("Нет");
}
else
{
  if (c_R > 0) Console.WriteLine("Искомый элемент найден в массиве new_mas");
  if (c_C > 0) Console.WriteLine("Искомый элемент найден в массиве new_mas_2");
}


