using System;

namespace Array_is_reference_type
{
    internal class Program
    {
        public static void WorkWithArray(int[] arr)
        {
            arr[0] = 123;
        }
        static void Main(string[] args)
        {
            int[] na5 = { 1, 2, 3, 4, 5 };
            foreach (var v in na5) // 1 2 3 4 5
                Console.Write(v + " ");

            Console.WriteLine();
            WorkWithArray(na5);
            foreach (var v in na5) // 123 2 3 4 5
                Console.Write(v + " ");
            Console.WriteLine();
        }
    }
}
