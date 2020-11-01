using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] openlab = original.ToCharArray();
            Array.Reverse(openlab);
            return new string(openlab);
        }
    }
}
