namespace FactoryPatternExercise;

public class Motorcycle
{
    public string Color { get; set; }
    public bool HasHandBrake { get; set; }

    public void Drive()
    {
        Console.WriteLine("Driving a motocycle and ");
    }
}