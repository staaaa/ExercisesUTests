using System;
using System.Collections.Generic;

namespace Exercises
{
    public class CharWar
    {
        public CharWar()
        {
        }
        public string Battle(string x, string y)
        {
            char[] allChar = new char[]{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            int point1 = 0;
            int point2 = 0;

            foreach(char c in x)
            {
                point1 += Array.IndexOf(allChar, c)+1;
            }
            foreach (char c in y)
            {
                point2 += Array.IndexOf(allChar, c) + 1;
            }
            if(point1 > point2)
            {
                return x;
            }
            else if(point1 < point2)
            {
                return y;
            }
            return "Tie!";
        }
    }
}
