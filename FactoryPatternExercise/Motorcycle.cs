namespace FactoryPatternExercise;

public class Motorcycle: IVehicle
{
   public void Drive()
    {
        Console.WriteLine("Building a new motorcycle.");
    }
}