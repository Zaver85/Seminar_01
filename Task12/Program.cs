using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Ввод строки с клавиатуры
        Console.WriteLine("Введите строку, состоящую из слов, разделенных пробелами:");
        string inputString = Console.ReadLine();

        // Разделение строки на слова
        string[] words = inputString.Split(' ');

        // Создание новой строки с обратным порядком слов
        StringBuilder reversedStringBuilder = new StringBuilder();
        for (int i = words.Length - 1; i >= 0; i--)
        {
            reversedStringBuilder.Append(words[i]);
            if (i > 0)
            {
                reversedStringBuilder.Append(" ");
            }
        }

        // Вывод результата
        Console.WriteLine("Строка с обратным порядком слов:");
        Console.WriteLine(reversedStringBuilder.ToString());
    }
}
