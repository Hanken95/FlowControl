using Tools;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitLoop = false;
            while (!exitLoop)
            {
                Console.WriteLine("Welcome to the main menu. You can navigate the main menu by pressing the corresponding" +
                    " numbers to test the different functions");
                Console.WriteLine("1: Movie ticket price calculator");
                Console.WriteLine("2: Movie ticket price calculator for a group");
                Console.WriteLine("3: Loop a line 10 times");
                Console.WriteLine("0: Exit program");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        Console.WriteLine(CinemaTools.MovieTicketPriceCalculator());
                        GeneralTools.WaitForUserContinueMessage(false);
                        break;
                    case '2':
                        Console.WriteLine(CinemaTools.MovieTicketPriceCalculatorForGroup());
                        GeneralTools.WaitForUserContinueMessage(false);
                        break;
                    case '3':
                        LoopTools.LoopInputTenTimes();
                        GeneralTools.WaitForUserContinueMessage(false);
                        break;
                    case '0':
                        exitLoop = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input. Press any key to try again");
                        Console.ReadKey(true);
                        break;
                }
                Console.Clear();
            }
        }


        
    }
}
