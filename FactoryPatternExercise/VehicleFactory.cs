using System.Drawing;

namespace FactoryPatternExercise;

public static class VehicleFactory
{
    public static IVehicle? GetVehicle(int numberOfTires)
    {
        switch (numberOfTires)
        {
            case 2:
                return new Motorcycle();
            case 4:
                return new Car();
            default:
                Console.WriteLine("Invalid number of Tires, no matching vehicle.");
                return new Car();
        }
    }
}