using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public static class LevDist
    {
        public static int Distance(string str1, string str2)
        {

            int length1 = str1.Length;
            int length2 = str2.Length;

            if ((length1 == 0) && (length2 == 0)) return -1;
            if (length1 == 0) return length2;
            if (length2 == 0) return length1;

            string strUpp1 = str1.ToUpper();
            string strUpp2 = str2.ToUpper();

            int[,] matrix = new int[length1 + 1, length2 + 1];

            for (int i = 0; i <= length1; i++) matrix[i, 0] = i;
            for (int j = 0; j <= length2; j++) matrix[0, j] = j;

            for (int i = 1; i <= length1; i++)
            {
                for (int j = 1; j <= length2; j++)
                {
                    int symbEqual = ((str1.Substring(i - 1, 1) == str2.Substring(j - 1, 1)) ? 0 : 1);

                    int insert = matrix[i, j - 1] + 1; // добавление
                    int delete = matrix[i - 1, j] + 1; // удаление
                    int subst = matrix[i - 1, j - 1] + symbEqual; // замена

                    matrix[i, j] = Math.Min(Math.Min(insert, delete), subst);

                    if ((i > 1) && (j > 1) &&
                        (strUpp1.Substring(i - 1, 1) == strUpp2.Substring(j - 2, 1)) &&
                        (strUpp1.Substring(i - 2, 1) == strUpp2.Substring(j - 1, 1)))
                    {
                        matrix[i, j] = Math.Min(matrix[i, j], matrix[i - 2, j - 2] + symbEqual);
                    }

                }
            }
            return matrix[length1, length2];
        }
    }
}
