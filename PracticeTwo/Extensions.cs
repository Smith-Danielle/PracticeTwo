using System;
namespace PracticeTwo
{
    public static class Extensions
    {
        static Extensions()
        {
        }
        public static void Print<T>(this T input)
        {
            Console.WriteLine(input);
        }
    }
}
