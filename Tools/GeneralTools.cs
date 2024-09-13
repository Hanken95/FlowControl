using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class GeneralTools
    {
        public static void WaitForUserContinueMessage(bool clearConsole = true)
        {
            if (clearConsole)
            {
                Console.Clear();
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey(true);
        }
    }
}
