using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    public interface IMatrixCheckEmpty<T>
    {
        // возврат пустого элемента
        T getEmptyElement();

        // проверка, пумтой ли элемент
        bool checkEmptyElement(T element);
    }
}
