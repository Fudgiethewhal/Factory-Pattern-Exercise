namespace FactoryPatternExercise;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What type of vehicle do you want to make? Car or Motorcycle???");
        string userInput = Console.ReadLine();

        switch (userInput.ToLower())
        {
            case "car":
                Car myCar = new Car(); 
                break;
            case "Motorcycle":
                Motorcycle myMotorcycle = new Motorcycle();
                break;
            default:
                break;
        }
    }
}