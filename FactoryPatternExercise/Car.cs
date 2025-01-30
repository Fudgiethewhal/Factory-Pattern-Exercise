﻿namespace FactoryPatternExercise;

class Car : IVehicle 
{
  public void Drive()
    {
        Console.WriteLine("Building a new Car!");
    }
}
