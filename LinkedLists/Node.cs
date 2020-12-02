using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Node<T>
    {
        public Node<T> next;
        public T value;

        internal int Count
        {
            get
            {
                if (next is null)
                    return 1;
                return next.Count + 1;
            }
        }

        internal void Add(T value)
        {
            if (next is null)
                next = new Node<T> { value = value };
            else
                next.Add(value);
        }

        internal Node<T> Find(T value)
        {
            if (this.value.Equals(value))
                return this;
            return next.Find(value);
        }

        internal int IndexOf(T value, int counter)
        {
            if(this.value.Equals(value))
                return counter;
            return next.IndexOf(value, counter + 1);
        }

        internal void ChangeAtPos(T value, int index, int counter)
        {
            if (counter == index)
                this.value = value;
            else
                next.ChangeAtPos(value, index, counter + 1);
        }

        internal void Remove(T value, bool reached)
        {
            if (this.value.Equals(value))
                reached = true;
            
            if(next != null)
            {
                if (reached)
                    this.value = next.value;

                next.Remove(value, reached);
            }
        }

    }
}
