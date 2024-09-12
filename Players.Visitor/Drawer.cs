namespace Players.Visitor;



public class Drawer : PlayerVisitor
{
    public bool Draw(Elf player)
    {
        Console.WriteLine("Draw Elf");
        return true;
    }

    public bool Draw(Hero player)
    {
        Console.WriteLine("Draw Hero");
        return true;
    }

    public bool Draw(Wizard player)
    {
        Console.WriteLine("Draw Wizard");
        return true;
    }

    public bool Draw(Dragon player)
    {
        Console.WriteLine("Draw Dragon");
        return true;
    }
}

public class Printer : PlayerVisitor
{
    public bool Draw(Hero player)
    {
        throw new NotImplementedException();
    }

    public bool Draw(Elf player)
    {
        throw new NotImplementedException();
    }

    public bool Draw(Wizard player)
    {
        throw new NotImplementedException();
    }

    public bool Draw(Dragon player)
    {
        throw new NotImplementedException();
    }
}