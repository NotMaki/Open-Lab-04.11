using System;
using System.Linq;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            string s = String.Concat(str.OrderBy(ch => ch));
            return s;

        }
    }
}
