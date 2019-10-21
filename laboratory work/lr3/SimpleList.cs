using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class SimpleList<T> : IEnumerable<T>
        where T : IComparable
    {
        // первый элемент списка
        protected SimpleListItem<T> first = null;

        // последний элемент списка
        protected SimpleListItem<T> last = null;

        int _count;
        public int count
        {
            get { return _count; }
            protected set { _count = value; }
        }

        // добавление элемента
        public void Add(T element)
        {
            SimpleListItem<T> newItem = new SimpleListItem<T>(element);
            this.count++;
            if (last == null) // если список пустой, а элемент соответственно первый
            {
                this.first = newItem;
                this.last = newItem;
            }
            else // добавляемый элемент становится поледним в списке
            {
                this.last.next = newItem;
                this.last = newItem;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            SimpleListItem<T> current = this.first;

            //Перебор элементов
            while (current != null)
            {
                //Возврат текущего значения
                yield return current.data;
                //Переход к следующему элементу
                current = current.next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
