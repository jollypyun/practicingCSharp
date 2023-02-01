using System;

namespace IntegralConversion
{
    class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128;
            Console.WriteLine(x);

            sbyte y = (sbyte)x;
            Console.WriteLine(y);

            float c = 69.6875f;
            Console.WriteLine(c);

            double d = (double)c;
            Console.WriteLine("d : {0}", d);
            Console.WriteLine("69.6875 == d : {0}", 69.6875 == d);

            float w = 0.1f;
            Console.WriteLine(w);

            double z = (double)w;
            Console.WriteLine("z : {0}", z);
            Console.WriteLine("0.1 == z : {0}",  0.1 == z);
        }
    }
}