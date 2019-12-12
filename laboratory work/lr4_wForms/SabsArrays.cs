using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4_wForms
{
    public static class SabsArrays
    {
        public static List<MiniMax> DivideSubArrays(int beginIndex, int endIndex, int subArraysCount)
        {
            //Результирующий список пар с индексами подмассивов
            List<MiniMax> result = new List<MiniMax>();

            //Если число элементов в массиве слишком мало для деления то возвращается массив целиком
            if ((endIndex - beginIndex) <= subArraysCount)
            {
                result.Add(new MiniMax(0, (endIndex - beginIndex)));
            }
            else
            {
                //Размер подмассива
                int delta = (endIndex - beginIndex) / subArraysCount;
                //Начало отсчета
                int currentBegin = beginIndex;
                //Пока размер подмассива укладывается в оставшуюся последовательность
                while ((endIndex - currentBegin) >= 2 * delta)
                {
                    result.Add(new MiniMax(currentBegin, currentBegin + delta));
                    currentBegin += delta;
                }
                result.Add(new MiniMax(currentBegin, endIndex));
            }
            return result;
        }
    }
}
