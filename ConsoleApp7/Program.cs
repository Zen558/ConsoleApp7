using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение k: ");
        int k = int.Parse(Console.ReadLine());

       
        Console.WriteLine("\n" +" ");
        Console.WriteLine("{0,-5} {1,-5} {2,-10} {3,-10} {4,-10}",
                          "m", "n", "a", "b", "c");
        Console.WriteLine("");

        
        for (int m = 2; m < k; m++)
        {
            for (int n = 1; n < m; n++) 
            {
                int a = m * m - n * n;
                int b = 2 * m * n;
                int c = m * m + n * n;

                // Вывод строки таблицы
                Console.WriteLine("{0,-5} {1,-5} {2,-10} {3,-10} {4,-10}",
                                  m, n, a, b, c);
            }
        }

        Console.WriteLine(" ");
        Console.WriteLine($"Сгенерировано для k = {k}");
        Console.ReadKey(); 
    }
}
