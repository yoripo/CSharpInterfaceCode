public interface IVehicle
{
    string Name { get; set; }
    void Move();
}

public class Car : IVehicle
{
    public string Name { get; set; }

    public Car(string name)
    {
        Name = name;
    }

    public void Move()
    {
        System.Console.WriteLine($"{Name} is moving on four wheels.");
    }
}

public class Bicycle : IVehicle
{
    public string Name { get; set; }

    public Bicycle(string name)
    {
        Name = name;
    }

    public void Move()
    {
        System.Console.WriteLine($"{Name} is moving on two wheels.");
    }
}
