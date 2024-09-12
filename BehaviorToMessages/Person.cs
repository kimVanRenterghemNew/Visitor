namespace BehaviorToMessages;

public interface PersonVisitor
{
    string Type { get; }
    void Visit(LocationRules location);
}


public record Person(string Name, string Type);

public record Developer(string Lang, string Name) : Person(Name, "Developer"), PersonVisitor
{
    public void Visit(LocationRules location)
    {
        location.Accept(this);
    }
}
public record Architect(string Name) : Person(Name, "Architect"), PersonVisitor
{
    public void Visit(LocationRules location)
    {
        location.Accept(this);
    }
}

