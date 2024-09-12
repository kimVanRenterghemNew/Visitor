namespace RuntimeOverLoading;

public interface Player
{
    void Draw();
}

public class Hero : Player
{
    public void Draw()
    {
        Console.WriteLine("Draw Hero");
    }
}

public class Elf : Player
{
    public void Draw()
    {
        Console.WriteLine("Draw Elf");
    }
}

public class Wizard : Player
{
    public void Draw()
    {
        Console.WriteLine("Draw Wizard");
    }
}