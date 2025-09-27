using Tyuiu.SafronovVE.Sprint4.Task6.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string[] array = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

        Console.Title = "Спринт #4 | Выполнил: Сафронов В. Е. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Сафронов Владимир Евгеньевич | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных, используя класс Array,                     *");
        Console.WriteLine("* выведите элементы массива, длина которых больше 5 символов.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}\t ");
        }

        string[] res = ds.Calculate(array);

        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Элементы, длина которых > 5: ");
        
        for (int i = 0; i < res.Length; i++)
        {
            Console.Write(res[i]);
        }

        Console.WriteLine();

        Console.ReadKey();
    }
}