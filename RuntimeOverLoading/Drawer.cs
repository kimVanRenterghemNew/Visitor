namespace RuntimeOverLoading;

public class Drawer
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
}