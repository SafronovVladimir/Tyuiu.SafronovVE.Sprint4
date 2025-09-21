using Tyuiu.SafronovVE.Sprint4.Task1.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Сафронов В. Е. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры                             *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Сафронов Владимир Евгеньевич | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8 подсчитать сумму четных   *");
        Console.WriteLine("* элементов массива.  С клавиатуры: 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите длину массива: ");
        int len = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        int[] array = new int[len];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите {i} элемент массива: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма четных элементов массива: " + ds.Calculate(array));

        Console.ReadKey();
    }
}