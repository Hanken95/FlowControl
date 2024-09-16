using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class LoopTools
    {
        public static void LoopInput(int timesToLoop = 10)
        {
            Console.Clear();
            Console.WriteLine("Enter input to be looped");
            Console.Write("Input: ");
            var input = Console.ReadLine();

            Console.Clear();
            for (int i = 0; i < timesToLoop; i++)
            {
                Console.Write(input + " ");
            }
        }
    }
}
