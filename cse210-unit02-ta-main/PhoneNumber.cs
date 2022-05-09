using System;

namespace Cse210_Unit02_Ta
{
    public class PhoneNumber
    {
        public string AreaCode;
        public string Prefix;
        public string Suffix;

        public PhoneNumber()
        {
            AreaCode = "000";
            Prefix = "000";
            Suffix = "0000";
        }

        public PhoneNumber(string areaCode, string prefix, string suffix)
        {
            AreaCode = areaCode;
            Prefix = prefix;
            Suffix = suffix;
        }

        public void DisplayNumber()
        {
            Console.WriteLine($"({AreaCode}) {Prefix}-{Suffix}");
        }
    }
}
