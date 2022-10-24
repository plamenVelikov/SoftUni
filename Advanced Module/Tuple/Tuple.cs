using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<T1, T2, T3>
    {
        public T1 FirstItem { get; set; }
        public T2 SecondItem { get; set; }
        public T3 ThirdItem { get; set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
