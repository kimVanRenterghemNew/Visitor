namespace BehaviorToEnums;

public interface Executor
{
    void RunActive(Subject car);
    void RunInActive(Subject car);
}

public class StartEngion : Executor
{
    public void RunActive(Subject car)
    {
        Console.WriteLine($"stard");
    }

    public void RunInActive(Subject car)
    {
        throw new NotImplementedException();
    }
}