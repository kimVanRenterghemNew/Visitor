namespace Players.Visitor;

public interface PlayerVisitor
{
    public bool Draw(Hero player);
    public bool Draw(Elf player);
    public bool Draw(Wizard player);
    public bool Draw(Dragon player);
}