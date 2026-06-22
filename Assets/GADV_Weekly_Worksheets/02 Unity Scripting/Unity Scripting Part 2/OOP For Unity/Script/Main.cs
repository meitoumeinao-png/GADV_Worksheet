using System;

public class player 
{
    public string name;

}

public class Car
{
    public float speed;
}

public class Program
{
    public static void Main()
    {
        player player1 = new player();
        Car car1 = new Car();

        player1.name = "Alex";
        car1.speed = 60;

        Console.WriteLine(player1.name);
        Console.WriteLine(car1.speed);
    }
}