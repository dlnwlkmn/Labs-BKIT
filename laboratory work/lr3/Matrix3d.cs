using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    public class Matrix<T>
    {
        Dictionary<string, T> _matrix = new Dictionary<string, T>();

        // столбцы
        int maxX;

        // строки
        int maxY;

        // глубина (слои)
        int maxZ;

        // проверка пустого элемента
        IMatrixCheckEmpty<T> сheckEmpty;


        public Matrix(int px, int py, int pz, IMatrixCheckEmpty<T> сheckEmptyParam)
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.сheckEmpty = сheckEmptyParam;
        }

        public T this[int x, int y, int z]
        {
            set
            {
                CheckEdges(x, y, z);
                string key = DictKey(x, y, z);
                this._matrix.Add(key, value);
            }
            get
            {
                CheckEdges(x, y, z);
                string key = DictKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.сheckEmpty.getEmptyElement();
                }
            }
        }


        void CheckEdges(int x, int y, int z)
        {
            if (x < 0 || x >= this.maxX)
            {
                throw new ArgumentOutOfRangeException("x", "x=" + x + " выходит за границы");
            }
            if (y < 0 || y >= this.maxY)
            {
                throw new ArgumentOutOfRangeException("y", "y=" + y + " выходит за границы");
            }
            if (z < 0 || z >= this.maxZ)
            {
                throw new ArgumentOutOfRangeException("z", "z=" + z + " выходит за границы");
            }
        }

        string DictKey(int x, int y, int z)
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }


        public override string ToString()
        {
            //Класс StringBuilder используется для построения длинных строк
            //Это увеличивает производительность по сравнению с созданием и склеиванием 
            //большого количества обычных строк

            StringBuilder b = new StringBuilder();
            for (int k = 0; k < this.maxZ; k++)
            {
                b.Append("'слой' трехмерной матрицы\n");
                for (int j = 0; j < this.maxY; j++)
                {
                    b.Append("[");
                    for (int i = 0; i < this.maxX; i++)
                    {
                        //Добавление разделителя-табуляции
                        if (i > 0)
                        {
                            b.Append("\t");
                        }
                        //Если текущий элемент не пустой
                        if (!this.сheckEmpty.checkEmptyElement(this[i, j, k]))
                        {
                            //Добавить приведенный к строке текущий элемент
                            b.Append(this[i, j, k].ToString());
                        }
                        else
                        {
                            //Иначе добавить признак пустого значения
                            b.Append(" 0 ");
                        }
                    }
                    b.Append("]\n");
                }
                b.Append("\n");
            }
            return b.ToString();
        }
    }
}
