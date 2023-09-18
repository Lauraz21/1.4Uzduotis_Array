using System.Reflection.Metadata.Ecma335;

namespace _1._4Uzduotis_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5 };

            ReverseInts(ints);
        }
        public static void ReverseInts(int[] ints)
        {
            for (int i = ints.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ints[i]);
            }
        }
    }
}