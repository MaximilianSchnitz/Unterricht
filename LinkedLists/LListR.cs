using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LListR<T>
    {
        public Node<T> first;

        public int Count
        {
            get
            {
                if (first is null)
                    return 0;
                return first.Count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index == 0 && first != null)
                    return first.value;

                var current = first;
                for (int i = 0; i < index; i++)
                {
                    

                    current = current.next;
                }
                return current.value;
            }
            set
            {
                if(index == 0 && first != null)
                    first.value = value;

                var current = first;
                for (int i = 0; i < index; i++)
                    current = current.next;
                current.value = value;
            }
        }

        public void Add(T value)
        {
            if(first is null)
            {
                first = new Node<T> { value = value };
            }
            else
            {
                first.Add(value);
            }
        }

        public void Remove(T value)
        {
            first.Remove(value, false);
        }

        public int IndexOf(T value)
        {
            return first.IndexOf(value, 0);
        }

        public void ChangeAtPos(T value, int pos)
        {
            first.ChangeAtPos(value, pos, 0);
        }

    }
}
