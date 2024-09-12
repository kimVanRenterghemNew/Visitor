namespace Players.Visitor;

public interface Player
{
    void Visit(PlayerVisitor visitor);
}

public class Hero : Player
{
    public void Visit(PlayerVisitor visitor)
    {
        visitor.Draw(this);
    }
}


public class Dragon : Player
{
    public void Visit(PlayerVisitor visitor)
    {
        visitor.Draw(this);
    }
}

public class Elf : Player
{
    public void Visit(PlayerVisitor visitor)
    {
        visitor.Draw(this);
    }
}

public class Wizard : Player
{
    public void Visit(PlayerVisitor visitor)
    {
        visitor.Draw(this);
    }
}