using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;
using System.Net;

namespace BoxOfT
{
    public class Box<T>
    {
        public Box()
        {
            list = new List<T>();
        }
        private List<T> list;
        

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove()
        {
            T elementToRemove = list.Last();
            list.RemoveAt(list.IndexOf(list.Last()));
            return elementToRemove;
        }
        public int Count { get { return list.Count; } }
    }
}
