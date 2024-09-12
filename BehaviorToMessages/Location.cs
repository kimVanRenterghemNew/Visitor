namespace BehaviorToMessages;


public interface LocationRules
{
    string Type { get; }
    void Accept(Developer person);
    void Accept(Architect person);
}

public record Location(string Name, string Type);

public record ServerRoom(int Size, string Name) : Location(Name, "ServerRoom"), LocationRules
{
    public void Accept(Developer person)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{person.Name} is aloud to enter {Name}");
        Console.ResetColor();
    }

    public void Accept(Architect person)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{person.Name} is Not aloud to enter {Name}"); 
        Console.ResetColor();
    }
}
public record DevRoom(string  TeamName, string Name) : Location(Name, "DevRoom"), LocationRules
{
    public void Accept(Developer person)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{person.Name} is aloud to enter {Name}");
        Console.ResetColor();
    }

    public void Accept(Architect person)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{person.Name} is aloud to enter {Name}");
        Console.ResetColor();
    }
}