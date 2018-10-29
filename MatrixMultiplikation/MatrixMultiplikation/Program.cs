using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplikation
{
    class Matrix
    {

        public void MatrixMultiplication(int[,] mas1, int[,] mas2, int mas1height, int mas2width)
        {
            int[,] mas3 = new int[mas1height, mas2width];

            for (int i = 0; i < mas1height; i++)
            {
                for (int j = 0; j < mas2width; j++)
                {
                    for (int k = 0; k < mas2width; k++)
                    {
                        mas3[i, j] += mas1[i, k] * mas2[k, j];
                    }
                }
            }

            Console.WriteLine("Результат: ");

            for (int i = 0; i < mas1height; i++)
            {
                for (int j = 0; j < mas2width; j++)
                {
                    Console.Write(mas3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Определение и создание матриц
            Console.WriteLine("Введите количество строк первой матрицы: ");
            int mas1height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов первой матрицы: ");
            int mas1width = Convert.ToInt32(Console.ReadLine());

            int[,] mas1 = new int[mas1height, mas1width];

            Console.WriteLine("Введите количество строк второй матрицы: ");
            int mas2height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов второй матрицы: ");
            int mas2width = Convert.ToInt32(Console.ReadLine());

            int[,] mas2 = new int[mas2height, mas2width];

            // Проверка длины матриц
            if (mas1width != mas2height)
            {
                Console.WriteLine("Умножать матрицы можно тогда и только тогда, когда количество столбцов первой матрицы равно количеству строк второй матрицы!");
                Console.WriteLine("Умножение невозможно.");
                goto End;
            }

            // Заполнение матриц значениями

            Console.WriteLine("Введите значения первой матрицы построчно через пробел: ");

            int[,] substring = new int[mas1height, mas2width];

            for (int i = 0; i < mas1height; i++)
            {
                string str1 = Console.ReadLine();
                int[] array = str1.Split(' ').Select(x => int.Parse(x)).ToArray();


                for (int k = 0; k < array.Length; k++)
                {
                    substring[i, k] = array[k];
                }
            }

            Console.WriteLine("Введите значения второй матрицы построчно через пробел: ");

            int[,] substring2 = new int[mas1height, mas2width];

            for (int i = 0; i < mas1height; i++)
            {
                string str2 = Console.ReadLine();
                int[] array2 = str2.Split(' ').Select(x => int.Parse(x)).ToArray();


                for (int k = 0; k < array2.Length; k++)
                {
                    substring2[i, k] = array2[k];
                }
            }



            // Вызов метода
            Matrix result = new Matrix();
            result.MatrixMultiplication(mas1, mas2, mas1height, mas2width);

            End:
            Console.ReadLine();

        }

    }
}
