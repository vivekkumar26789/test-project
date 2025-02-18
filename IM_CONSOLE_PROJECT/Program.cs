using System;

namespace IM_CONSOLE_PROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Vivek! Now in "+ Globals.ENVIRONMENT_CODE);
            if (Globals.ENVIRONMENT_CODE == "PRODUCTION")
            {
                Console.WriteLine("Running in Production");
            }
            else if (Globals.ENVIRONMENT_CODE == "UAT")
            {
                Console.WriteLine("Running in UAT");
            }
        }
    }
}
