using System;

namespace DataStructureLib
{
    public class Stack<T>
    {
        private const int InitialSize = 8;
        private Item<T>[] stack;
        private int Top = -1;
        public int Count { get; private set; } = 0;
        private bool Full => Count == stack.Length;
        public bool Empty => Count == 0;

        
        public void Push(T t)
        {
            if (Full)
                DoubleCapacity();
            var item = new Item<T>(t);

            stack[++Top] = item;
            Count++;
        }

        public void Push(params T[] ts)
        {
            foreach(var t in ts)
            {
                Push(t);
            }
        }

        public T Pop()
        {
            if (Empty)
                throw new Exception("Stack is empty");
            Item<T> item = stack[Top];
            stack[Top--] = null;
            Count--;
            return item.t;
        }

        public void Reset()
        {
            Top = -1;
            Count = 0;
            stack = new Item<T>[InitialSize];
        }

        public void DoubleCapacity()
        {
            int newCapacity = stack.Length * 2;
            Item<T>[] newStack = new Item<T>[newCapacity];
            for (var idx = 0; idx<stack.Length; idx++)
            {
                newStack[idx] = stack[idx];  
            }
            stack = newStack;
        }



        public Stack()
        {
            stack = new Item<T>[InitialSize];
        }
    }
}
