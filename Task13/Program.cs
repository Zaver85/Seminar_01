using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 5, 6, 7, 8 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        ReverseArray(array);

        Console.WriteLine("\nПеревёрнутый массив:");
        PrintArray(array);
    }

    static void ReverseArray(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[length - i - 1];
            arr[length - i - 1] = temp;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
