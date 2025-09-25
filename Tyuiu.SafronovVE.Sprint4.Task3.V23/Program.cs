using System.Data;
using Tyuiu.SafronovVE.Sprint4.Task3.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int[,] array = new int[5, 5] { 
            { 7, 5, 5, 6, 7 },
            { 8, 7, 8, 4, 3 },
            { 5, 6, 7, 8, 3 },
            { 4, 2, 3, 6, 4 },
            { 5, 2, 4, 2, 3 } 
        };
        int rows = array.GetUpperBound(0) + 1;
        int columns = array.Length / rows;

        Console.Title = "Спринт #4 | Выполнил: Сафронов В. Е. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Сафронов Владимир Евгеньевич | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
        Console.WriteLine("* заполненный статическими значениями в диапазоне от 2 до 8.              *");
        Console.WriteLine("* Подсчитайте количество четных элементов во всем массиве.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Матрица: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Количество чётных элементов массива: " + ds.Calculate(array));

        Console.ReadKey();
    }
}