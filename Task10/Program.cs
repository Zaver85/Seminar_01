//Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10].
//Замените отрицательные элементы на положительные, а положительные на отрицательные.
//
//Пример
//
//[1 -5 6]
//
//=> [-1 5 -6]



void RandomFillArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Random rnd = new Random();
    arr[i] = rnd.Next(-10, 10);
  }
}

void PrintArrayToScreen(int[] arr)
{
  foreach(var e in arr)
  { Console.Write($"{e} "); }
  Console.WriteLine();
}

int[] array = new int[10];
RandomFillArray(array);

PrintArrayToScreen(array);

for(int i = 0; i < array.Length; i++)
{
  array[i] *= -1;
}

PrintArrayToScreen(array);