using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int n = int.Parse(Console.ReadLine());

        int[,] array = new int[m, n];
        Random random = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.Next(100);
            }
        }


        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", array[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (array[i, j] < array[i, k])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }

        Console.WriteLine("Отсортированный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}
