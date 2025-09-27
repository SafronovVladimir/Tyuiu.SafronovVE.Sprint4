using Tyuiu.SafronovVE.Sprint4.Task4.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Сафронов В. Е. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил: Сафронов Владимир Евгеньевич | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
        Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 7.              *");
        Console.WriteLine("* Найдите сумму нечетных элементов массива.                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.Write("Введите количество строк в массиве: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов в массиве: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Введите {i},{j} элемент массива: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Матрица: ");
        for (int i = 0;i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма нечётных элементов массива: " + ds.Calculate(matrix));

        Console.ReadKey();
    }
}