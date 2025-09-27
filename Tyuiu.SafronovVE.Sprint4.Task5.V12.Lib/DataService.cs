using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SafronovVE.Sprint4.Task5.V12.Lib
{
    public class DataService : ISprint4Task5V12
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
