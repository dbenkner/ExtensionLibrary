﻿namespace ExtensionLibrary
{
    public static class StringExtensions
    {
        public static decimal ToDecimal(this string str)
        {
            var s = str;
            s = s.Trim();
            if (s[0] == '$')
            {
                s = s.Substring(1);
            }
            s = s.Replace(",", "");
            decimal nbr;
            var rc = decimal.TryParse(s, out nbr);
            if(!rc)
            {
                throw new Exception("string contains non numeric charachters");
            }
            return nbr;
        }
        public static string AllCaps(this string str)
        {
            return str.ToUpper();
        }
        public static string AllSmall(this string str)
        {
            return str.ToLower();
        }
        public static void WriteLine(this string str)
        {
            Console.WriteLine(str);
        }
            public static int Eval(this int x)
            {
                return (x * x) + (3 * x) + 5;
            }
    }
}