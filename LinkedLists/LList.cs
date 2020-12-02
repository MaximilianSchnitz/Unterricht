using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{

    public class LList<T>
    {

        public Node<T> first;

        public int Count
        {
            get
            {
                int i = 1;
                var current = first;
                while(current.next != null)
                {
                    i++;
                    current = current.next;
                }
                return i;
            }
        }

        public void Add(T value)
        {
            if (first is null)
                first = new Node<T> { value = value };
            else
            {
                var node = first;
                while (node.next != null)
                    node = node.next;
                node.next = new Node<T> { value = value };
            }
        }

        public Node<T> Find(T value)
        {
            var current = first;
            while(current.next != null)
            {
                if (current.value.Equals(value))
                    return current;
                current = current.next;
            }
            return null;
        }

        public int IndexOf(T value)
        {
            int i = 0;
            var current = first;
            while(current != null)
            {
                if (current.value.Equals(value))
                    return i;
                current = current.next;
                i++;
            }
            return -1;
        }

        public void ChangeAtPos(int index, T value)
        {
            int i = 0;
            var current = first;
            while(current.next != null)
            {
                if (i == index)
                {
                    current.value = value;
                    return;
                }
                current = current.next;
                i++;
            }
        }

        public void ChangeAtPos(T value, int index)
        {
            var current = first;
            for(int i = 0; i < index; i++)
                current = current.next;

            current.value = value;
        }

        public void Remove(T value)
        {
            var current = first;
            int index = IndexOf(value);
            for(int i = 1; i < index - 1; i++)
            {
                if(true)
                {

                }
            }
        }
    }
}
