﻿class Lasagna
{
    public const int time = 40;
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualTimeInOven)
    {
        return time-actualTimeInOven;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int noOfLayers)
    {
        return 2*noOfLayers;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int noOfLayers,int actualTimeInOven)
    {
        return PreparationTimeInMinutes(noOfLayers)+actualTimeInOven;
    }
}
//Main method can be avoided during solving the problem in exercism.org editor
class Mainprogram
{
    public static void Main(string[] args)
    {
        var lasagna = new Lasagna();
        Console.WriteLine(lasagna.ExpectedMinutesInOven());
        Console.WriteLine(lasagna.RemainingMinutesInOven(30));
        Console.WriteLine(lasagna.PreparationTimeInMinutes(2));
        Console.WriteLine(lasagna.ElapsedTimeInMinutes(3,20));
    }
}