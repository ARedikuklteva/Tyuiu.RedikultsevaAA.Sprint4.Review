using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint4.TaskReview.V4.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.TaskReview.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4-Review | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4-Review                                                           *");
            Console.WriteLine("* Вариант #4                                                                 *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '382976421897'. Преобразуйте ее в        *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                         *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int rows = 3;
            int colums = 4;
            int[,] matrix = new int[rows, colums];

            string str = "382976421897";

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            int res = ds.Calculate(rows, colums, str);

            Console.WriteLine("Сумма нечетных элементов = " + res);
            Console.ReadKey();
        }
    }
}
