using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> asd = new EqualityScale<int>(32, 42);

            asd.AreEqual();
            Console.WriteLine(asd.AreEqual());
        }
    }
}
