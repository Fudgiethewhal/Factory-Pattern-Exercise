using System.Drawing;

namespace FactoryPatternExercise;

class VehicleFactory
{
   public IVehicle CreateVehicle(string userInput)
   {
      switch (userInput.ToLower())
      {
         case "car":
            return new Car() { Color = "Blue", IsDriveable = true };
         case "Motorcycle":
           return new Motorcycle(); 
         default:
            return new Car();
         
      }
   }
}