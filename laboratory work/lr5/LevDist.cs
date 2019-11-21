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
            if (str1 == null || str2 == null) return -1;

            int length1 = str1.Length;
            int length2 = str2.Length;

            if (length1 == 0 && length2 == 0) return 0;
            if (length1 == 0) return length2;
            if (length2 == 0) return length1;

            string strUpp1 = str1.ToUpper();
            string strUpp2 = str2.ToUpper();

            int[,] matrix = new int[length1 + 1, length2 + 1];

            for (int i = 0; i <= length1; i++) matrix[i, 0] = i;
            for (int j = 0; j <= length2; j++) matrix[0, j] = j;

            for(int i = 0; i < length1; i++)
            {
                for(int j = 0; j < length2; j++)
                {

                }
            }
            return matrix[length1, length2];
        }
    }
}
