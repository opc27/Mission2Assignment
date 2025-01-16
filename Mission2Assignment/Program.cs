// Olivia Christensen
// 1/15/25
// Mission #2 Assignment 

namespace Mission2Assignment;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        // ask the user how many times they want to roll
        Console.Write("How many dice rolls would you like to simulate? ");

        var rollNumInput = Console.ReadLine();
        int rollNum = int.Parse(rollNumInput);

        // pass roleNum to second Class
        SecondClass sc = new SecondClass();

        // call the Simulation method and grab the array 
        int[] totals = sc.Simulation(rollNum);

        // set total to 0
        int totalSum = 0;

        // print out histogram using array
        for (int i = 0; i < totals.Length; i++)
        {
            // sum up the array
            totalSum += totals[i];
        }

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.\n");
        Console.WriteLine($"The number of rolls is {rollNum}.\n");

        for (int i = 0; i < totals.Length; i++)
        {
            if (totalSum > 0)
            {
                double percentage = (totals[i] / (double)totalSum) * 100;
                
                // round for asterisk
                int asteriskCount = (int)Math.Round(percentage);
                
                Console.WriteLine($"{i + 2}: {new string('*', asteriskCount)}");
            }
            else
            {
                Console.WriteLine($"{i + 2}:");
            }

        }
    }
}

