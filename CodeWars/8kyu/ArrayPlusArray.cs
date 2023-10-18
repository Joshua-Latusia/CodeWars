/*
https://www.codewars.com/kata/5a2be17aee1aaefe2a000151/train/csharp

8 kyu
Array plus array

I'm new to coding and now I want to get the sum of two arrays... Actually the sum of all their elements. I'll appreciate for your help.

P.S. Each array includes only integer numbers. Output is a number too.

*/


namespace CodeWars._8kyu
{
    public static class ArrayPlusArray
    {
        public static int DoArrayPlusArray(int[] arr1, int[] arr2)
        {
            return arr1.Concat(arr2).ToArray().Sum();
        }
    }
}
