using CodeWars;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = ArrayPlusArray.DoArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 });
            Console.WriteLine("Result: {0}", result);
            Console.WriteLine("Hello, World!");
        }
    }
}