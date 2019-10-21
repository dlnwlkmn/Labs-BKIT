using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class SimpleListItem<T>
    {
        public T data { get; set; }

        // следующий элемент
        public SimpleListItem<T> next{ get; set; }

        public SimpleListItem(T parametr)
        {
            this.data = parametr;
        }

    }
}
