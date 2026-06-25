using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core
{
    public class Generics
    {
        public static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
    }
    public class MyStack<T>
    {
        private readonly List<T> items = new();

        public bool IsEmpty => items.Count == 0;

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            T item = items[^1];
            items.RemoveAt(items.Count - 1);

            return item;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            return items[^1];
        }
    }
}
