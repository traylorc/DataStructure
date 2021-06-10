using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLib
{
    class Item<T>
    {
        public T t  { get; set; }
        public int Next { get; set; } = -1;
        public int Prev { get; set; } = -1;

        public Item(T t)
        {
            this.t = t;
        }

    }
}
