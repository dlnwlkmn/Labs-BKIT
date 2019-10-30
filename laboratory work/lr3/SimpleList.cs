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

        public SimpleListItem<T> GetItem(int number)
        {
            if ((number < 0) || (number >= this.count))
            {
                //Можно создать собственный класс исключения
                throw new Exception("Выход за границу индекса");
            }

            SimpleListItem<T> current = this.first;
            int i = 0;

            //Пропускаем нужное количество элементов
            while (i < number)
            {
                //Переход к следующему элементу
                current = current.next;
                //Увеличение счетчика
                i++;
            }

            return current;
        }

        public T get(int num)
        {
            return GetItem(num).data;
        }

        private void swap(int i, int j)
        {
            SimpleListItem<T> ci = GetItem(i);
            SimpleListItem<T> cj = GetItem(j);
            T temp = ci.data;
            ci.data = cj.data;
            cj.data = temp;
        }

        public void Sort()
        {
            Sort(0, this.count - 1);
        }

        private void Sort(int low, int high)
        {
            int i = low;
            int j = high;
            T x = get((low + high) / 2);
            do
            {
                while (get(i).CompareTo(x) < 0) ++i;
                while (get(j).CompareTo(x) > 0) --j;
                if (i <= j)
                {
                    swap(i, j);
                    i++; j--;
                }
            } while (i <= j);

            if (low < j) Sort(low, j);
            if (i < high) Sort(i, high);
        }
    }
}
