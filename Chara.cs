public interface ICharacter
{
    string Name { get; set; }
    int Health { get; set; }
    void Attack(ICharacter target);
}

public class Warrior : ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Warrior(string name)
    {
        Name = name;
        Health = 100;
    }

    public void Attack(ICharacter target)
    {
        // Attack logic here
        System.Console.WriteLine($"{Name} attacks {target.Name} with a sword!");
    }
}

public class Mage : ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Mage(string name)
    {
        Name = name;
        Health = 100;
    }

    public void Attack(ICharacter target)
    {
        // Attack logic here
        System.Console.WriteLine($"{Name} attacks {target.Name} with a fireball!");
    }
}
