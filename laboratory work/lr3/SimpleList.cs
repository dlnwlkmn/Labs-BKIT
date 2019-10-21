using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class SimpleList<T>
    {
        // первый элемент списка
        protected SimpleListItem<T> first = null;

        // последний элемент списка
        protected SimpleListItem<T> second = null;

        int _count;
        public int count
        {
            get { return _count; }
            protected set { _count = value; }
        }

        
    }
}
