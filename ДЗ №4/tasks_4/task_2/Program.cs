using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment a = new(8, 8);
            Segment b = new(12, 8);
            Console.WriteLine(a.Length);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a + b);

            //Console.WriteLine((uint)b);

            Segment c = (4, 2);
            Console.WriteLine(c);

            Segment d = null;
            //Console.WriteLine(d + c);


            Console.WriteLine(a.Equals(null));
        }
    }
}
