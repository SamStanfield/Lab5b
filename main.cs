using System;

class MainClass {
  public static void Main (string[] args) {
    int total = 0;
    int car = 0;
    Console.WriteLine("Input total number of cars.");
    double totalcars = Convert.ToDouble(Console.ReadLine());
    for(int counter=0;counter<totalcars;counter++)
    {
      car++;
      Console.WriteLine("Input the distance for car#" + car);
      double distance = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Input the time of car#" + car);
      double time = Convert.ToDouble(Console.ReadLine());
      double speed = distance/time;
      Console.WriteLine("the speed of car#" + car + " is " + speed);
      total++;

    }
    double average = total/car;
    Console.WriteLine("the average of the cars is " + average);
  }
}