using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class SimpleStack<T> : SimpleList<T> where T : IComparable
    {
        public void Push(T elem)
        {
            Add(elem);
        }
        
        public T Pop()
        {
            T Result = default(T);
            if (this.count == 0) return Result; // если стэк пуст
            if(this.count == 1) // если в стэке один элемент
            {
                Result = this.first.data;
                this.first = null;
                this.last = null;
            }
            else // если в стэке больше одного элемента.
            {
                SimpleListItem<T> newLast = GetItem(this.count - 2);
                Result = newLast.next.data;
                this.last = newLast;
                newLast.next = null;
            }
            this.count--;
            return Result;
        }
    }
}
