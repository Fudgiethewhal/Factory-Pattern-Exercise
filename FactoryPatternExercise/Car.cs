namespace FactoryPatternExercise;

class Car : IVehicle 
{
    public string Color { get; set; }
    public bool IsDriveable { get; set; }

    public void Drive()
    {
        Console.WriteLine($"Sorry can't text, I'm driving my {Color} car");
    }
}
