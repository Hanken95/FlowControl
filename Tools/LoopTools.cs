using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class LoopTools
    {
        public static void LoopInputTenTimes()
        {
            Console.Clear();
            Console.WriteLine("Enter input to be looped");
            Console.Write("Input: ");
            var input = Console.ReadLine();

            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(input + " ");
            }
        }
    }
}
