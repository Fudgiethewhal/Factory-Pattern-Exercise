using System.Collections.Generic;

namespace FactoryPatternExercise;

public class Program
{
   public static void Main()
   {
       int numTires;
       while (true)
        {
            Console.Write("Enter number of tires: ");
            if (int.TryParse(Console.ReadLine(), out numTires))
            {
                IVehicle vehicle = VehicleFactory.GetVehicle(numTires);
                vehicle.Drive();
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
       
    }
}