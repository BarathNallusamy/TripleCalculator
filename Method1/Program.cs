using System;

namespace Method1
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var product = TripleCalc(5, 10, 15, out int sum);
            Console.WriteLine(product + " : " + sum);

            var tuple = TripleCalc(1, 2, 10);
            Console.WriteLine(tuple.product + " : " + tuple.sum);

            Console.WriteLine(Add(10, 20));
        }

        public static int TripleCalc(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return a * b * c;
        }

        //below hown is a method overload from the above
        public static (int sum, int product) TripleCalc(int a, int b, int c)
        {

            return ((a + b + c), (a * b * c));
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

    }
}
