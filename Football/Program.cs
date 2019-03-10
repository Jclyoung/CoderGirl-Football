using System;

namespace Football
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number of touchdowns(7 points): ");
            int touchdowns = int.Parse(Console.ReadLine());
            int touchdownsTotal = (touchdowns * 7);


            Console.Write("Enter the number of field goals(3 points): ");
            int fieldGoals = int.Parse(Console.ReadLine());
            int fieldGoalsTotal = (fieldGoals * 3);

            // Compute the number of points in a single line of code.
            int points = (touchdownsTotal + fieldGoalsTotal);
            


            Console.Write($"The team scored {points} points.");

            Console.ReadLine();
        }
    }
}
