namespace Deliverable_4_Fibonacci_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fib;
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < 25; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }            
        }
    }
}