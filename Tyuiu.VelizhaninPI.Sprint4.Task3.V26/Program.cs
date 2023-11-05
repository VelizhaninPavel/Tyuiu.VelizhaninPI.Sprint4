using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VelizhaninPI.Sprint4.Task3.V26.Lib;
using Tyuiu.VelizhaninPI.Sprint4.Task3.V26.Test;

namespace Tyuiu.VelizhaninPI.Sprint4.Task3.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Велижанин П. И. | ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                            * ");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Велижанин Павел Ильич | ИИПб-23-3                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 6. Найдите максимальный     *");
            Console.WriteLine("* элемент во второй строке массива.                                       *");
            Console.WriteLine("* 4, 3, 2, 6, 2,                                                          *");
            Console.WriteLine("* 5, 2, 2, 5, 6,                                                          *");
            Console.WriteLine("* 2, 5, 4, 5, 6,                                                          *");
            Console.WriteLine("* 4, 5, 2, 4, 6,                                                          *");
            Console.WriteLine("* 6, 5, 4, 3, 6,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array ={{4, 3, 2, 6, 2, },
                           { 5, 2, 2, 5, 6, },
                           { 2, 5, 4, 5, 6, },
                           { 4, 5, 2, 4, 6, },
                           { 6, 5, 4, 3, 6, } };

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.WriteLine("Массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("максимальный элемент во второй строке массива = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
