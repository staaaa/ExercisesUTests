using System;
namespace Exercises
{
    public class AreEven
    {
        public string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            return "Odd";
        }
    }
}
