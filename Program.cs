using System;
using System.Linq;

namespace ListConverter
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество вводимых строк: ");

            int N;
            // ввод N (количества вводимых строк)
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out N))
                    Console.WriteLine("Неправильный ввод. Ожидалось число");
                else
                    break;
            }

            string[] array = new string[N];
            int newArrayLen = 0; // длина нового массива
            // ввод строк (заполнение массива array)
            for (int i = 0; i < N; i++)
            {
                array[i] = Console.ReadLine();
                if (array[i].Length <= 3)
                    newArrayLen++;
            }

            string[] newArray = new string[newArrayLen];
            int index = 0; // индексатор нового массива
            for (int i = 0; i < N; i++)
            {
                if (array[i].Length <= 3)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }

            Console.WriteLine("Новый массив:");
            for (int i = 0; i < newArrayLen; i++)
            {
                Console.WriteLine(newArray[i]);
            }
        }
    }
}