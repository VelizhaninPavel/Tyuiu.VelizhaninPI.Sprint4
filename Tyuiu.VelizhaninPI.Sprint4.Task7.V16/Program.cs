using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VelizhaninPI.Sprint4.Task7.V16.Test;
using Tyuiu.VelizhaninPI.Sprint4.Task7.V16.Lib;

namespace Tyuiu.VelizhaninPI.Sprint4.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Велижанин П. И. | ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Велижанин Павел Ильич | ИИПб-23-3                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '82976421897948'. Преобразуйте ее в   *");
            Console.WriteLine("* матрицу 5 на 3 и подсчитайте произведение четных чисел.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "382976421897948";
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            int index = 0;

            Console.WriteLine("\nПолучившийся массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение четных чисел массива = " + ds.Calculate(rows, columns, str));

            Console.ReadLine();
        }
    }
}
