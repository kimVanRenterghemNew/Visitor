namespace BehaviorToEnums;


public interface Subject {}

public class Car: Subject
{
    public string Plate { get; set; }
    public Status Status { get; set; }

    public void Execute(Executor executor)
    {
        Status.Execute(this, executor);
    }
}