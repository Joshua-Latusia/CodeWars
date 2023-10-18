/*
https://www.codewars.com/kata/53da3dbb4a5168369a0000fe/train/csharp

8 kyu
Even or Odd

Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

*/
namespace CodeWars
{
    public class EvenOrOdd
    {
        public static string CalculateEvenOrOdd(int number)
        {
            return (number % 2 == 0) ? "Even" : "Odd";
        }
    }
}
