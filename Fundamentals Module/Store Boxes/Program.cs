using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputProps = Console.ReadLine().Split(' ');
            List<Box> sequence = new List<Box>();
            while (inputProps[0] != "end")
            {
                Box box = new Box();
                box.Item.Name = inputProps[1];
                box.Item.Price = decimal.Parse(inputProps[3]);

                box.SerialNumber = inputProps[0];
                box.Quantity = int.Parse(inputProps[2]);
                box.BoxPrice = box.Quantity * box.Item.Price;
                sequence.Add(box);

                inputProps = Console.ReadLine().Split(' ');
            }

            List<Box> orderedBoxes = sequence.OrderByDescending(x => x.BoxPrice).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal BoxPrice { get; set; }

    }
}
