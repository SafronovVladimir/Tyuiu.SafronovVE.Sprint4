using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SafronovVE.Sprint4.Task4.V19.Lib
{
    public class DataService : ISprint4Task4V19
    {
        public int Calculate(int[,] matrix)
        {
            var sum = 0;
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
