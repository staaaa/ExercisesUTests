using System;
using System.Linq;

namespace Exercises
{
    public class StringSort
    {
        public StringSort()
        {
        }
        public string Longest(string input1, string input2)
        {
            string bigString = input1 + input2;

            char[] distinctString = bigString.Distinct().ToArray();
            Array.Sort(distinctString);
            return new string(distinctString);
        }
    }
}
