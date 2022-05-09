using System;

namespace Cse210_Unit02_Ta
{
    public class Program
    {
        public static void Main()
        {
            Address home = new Address("blue street", "Rexburg", "Udaho");
            home.DisplayMailingLabel();

            Address school = new Address();
            school.DisplayMailingLabel();

            PhoneNumber phone1 = new PhoneNumber();
            phone1.AreaCode = "505";
            phone1.Prefix = "555";
            phone1.Suffix = "7777";

            phone1.DisplayNumber();
        }
    }
}
