using System;

namespace biblioteca_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество вершин: ");
            int n = int.Parse(Console.ReadLine());
            int[,] coord = new int[2, n];
            Console.WriteLine("***Кординаты вершины вводить через пробел***");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите координаты вершины {0}: ", i + 1);
                var input = Console.ReadLine().Split(' ');
                coord[0, i] = int.Parse(input[0]);
                coord[1, i] = int.Parse(input[1]);
            }

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n - 1; i++)
            {
                sum1 += coord[0, i] * coord[1, i + 1];
                sum2 += coord[1, i] * coord[0, i + 1];
            }

            double area = Math.Abs((sum1 - sum2) / 2d);
            Console.WriteLine("Пложадь многоугольника равна {0}", area);
            Console.ReadKey();
        }
    }
}
