using System;

namespace DCSL.RPNFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var rpnEngine = new RPNEngine();

            Console.WriteLine("Insert the total of Robustly Prime Numbers to be available, from 1 to 2209. Keep in mind that it becomes exponentialy slower!!!");
            Console.WriteLine("For example: The first 1097 RPN numbers are calculated in around 5 seconds, but until the 1700th it can take up to 20 minutes.");
            var total = Convert.ToInt32(Console.ReadLine());

            rpnEngine.LoadRPNPrimes(total);

            while (true)
            {
                try
                {
                    Console.WriteLine($"Insert the index from 1 to {total}, to display the Robustly Prime Number on that position...");
                    var index = Convert.ToInt32(Console.ReadLine());

                    if (index > 0 && index <= total)
                    {
                        var result = rpnEngine.GetRPNByIndex(index);

                        Console.WriteLine($"The RPN with index {index} is: {result}");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"The index {index} is not valid.");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.ReadLine();
                    throw;
                }
            }
        }
    }
}
