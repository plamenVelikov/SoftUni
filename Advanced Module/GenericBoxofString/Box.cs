using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GenericBoxofString
{
    public class Box<T> where T : IComparable
    {
        public Box()
        {
            Items = new List<T>();
        }
        public List<T> Items { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString().TrimEnd();
        }

        public void Swapper(int index1, int index2)
        {
            T save = Items[index1];
            Items[index1] = Items[index2];
            Items[index2] = save;
        }

        public int Comparer(T element)
        {
            int counter = 0;

            foreach (var item in this.Items)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
