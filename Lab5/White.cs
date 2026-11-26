using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class White
    {
        public double Task1(int[,] matrix)
        {
            double average = 0;

            // code here
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        average += matrix[i, j];
                        count++;
                    }
                }
            }

            if (count > 0)
            {
                average /= count;
            }

            // end

            return average;
        }
        public (int row, int col) Task2(int[,] matrix)
        {
            int row = 0, col = 0;

            // code here
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < matrix[row, col])
                    {
                        row = i;
                        col = j;
                    }
                }
            }

            // end

            return (row, col);
        }
        public void Task3(int[,] matrix, int k)
        {

            // code here
            if (k >= 0 && k < matrix.GetLength(1))
            {
                int row = 0;

                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, k] > matrix[row, k])
                        row = i;
                }

                if (row != 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int temp = matrix[0, j];
                        matrix[0, j] = matrix[row, j];
                        matrix[row, j] = temp;
                    }
                }
            }

            // end

        }
        public int[,] Task4(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int row = 0;

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0] < matrix[row, 0])
                    row = i;
            }

            answer = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
            int newRow = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i == row)
                    continue;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    answer[newRow, j] = matrix[i, j];
                }

                newRow++;
            }

            // end

            return answer;
        }
        public int Task5(int[,] matrix)
        {
            int sum = 0;

            // code here
            if (matrix.GetLength(0) == matrix.GetLength(1))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, i];
                }
            }

            // end

            return sum;
        }
        public void Task6(int[,] matrix)
        {

            // code here
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max = 0;
                int negative = -1;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        negative = j;
                        break;
                    }

                    if (matrix[i, j] > matrix[i, max])
                        max = j;
                }

                if (negative > 0)
                {
                    for (int j = negative + 1; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] < 0)
                            negative = j;
                    }

                    int temp = matrix[i, max];
                    matrix[i, max] = matrix[i, negative];
                    matrix[i, negative] = temp;
                }
            }

            // end

        }
        public int[] Task7(int[,] matrix)
        {
            int[] negatives = null;

            // code here
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                        count++;
                }
            }

            if (count > 0)
            {
                negatives = new int[count];
                int index = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] < 0)
                        {
                            negatives[index] = matrix[i, j];
                            index++;
                        }
                    }
                }
            }

            // end

            return negatives;
        }
        public void Task8(int[,] matrix)
        {

            // code here
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix.GetLength(1) == 1)
                    continue;

                int max = 0;

                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > matrix[i, max])
                        max = j;
                }

                if (max == 0)
                    matrix[i, 1] *= 2;
                else if (max == matrix.GetLength(1) - 1)
                    matrix[i, max - 1] *= 2;
                else if (matrix[i, max - 1] <= matrix[i, max + 1])
                    matrix[i, max - 1] *= 2;
                else
                    matrix[i, max + 1] *= 2;
            }

            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here
            int columns = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < columns / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, columns - 1 - j];
                    matrix[i, columns - 1 - j] = temp;
                }
            }

            // end

        }
        public void Task10(int[,] matrix)
        {

            // code here
            int n = matrix.GetLength(0);

            if (n == matrix.GetLength(1))
            {
                for (int i = n / 2; i < n; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            // end

        }
        public int[,] Task11(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            bool[] hasZero = new bool[matrix.GetLength(0)];
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        hasZero[i] = true;
                        break;
                    }
                }

                if (!hasZero[i])
                    count++;
            }

            answer = new int[count, matrix.GetLength(1)];
            int row = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (hasZero[i])
                    continue;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    answer[row, j] = matrix[i, j];
                }

                row++;
            }

            // end

            return answer;
        }
        public void Task12(int[][] array)
        {

            // code here
            long[] sums = new long[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sums[i] += array[i][j];
                }
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (sums[j] > sums[j + 1])
                    {
                        long tempSum = sums[j];
                        sums[j] = sums[j + 1];
                        sums[j + 1] = tempSum;

                        int[] temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            // end

        }
    }
}
