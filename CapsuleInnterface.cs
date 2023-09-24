public void Main(){
    // オブジェクトの作成
    IVehicle myCar = new Car("Toyota");
    IVehicle myBicycle = new Bicycle("Bianchi");
    
    // メソッドの呼び出し
    myCar.Move();  // "Toyota is moving on four wheels."と出力
    myBicycle.Move(); // "Bianchi is moving on two wheels."と出力

}
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
