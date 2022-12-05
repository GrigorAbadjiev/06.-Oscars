using System;
using System.ComponentModel;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int reviewersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < reviewersCount; i++)
            {
                string reviewerName = Console.ReadLine();
                double reviewerPoints = double.Parse(Console.ReadLine());
                double newPoints = reviewerName.Length * reviewerPoints / 2;

                startingPoints += newPoints;
                if (startingPoints > 1250.5)
                {
                    break;
                }
            }
            if (startingPoints > 1250.5)
            { 
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {startingPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - startingPoints:f1} more!");
            }
        }
    }
}
