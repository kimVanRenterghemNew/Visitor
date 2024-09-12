using System.Xml;

namespace BehaviorToEnums;


public interface InnerStatus
{
    string Name => this.GetType().Name;

    void Execute(Subject car, Executor executor);
}


public record Status
{
    private readonly InnerStatus _innerStatus;

    public static Status Inactive => new("Inactive");
    public static Status Active => new("Active");

    public Status(string status)
    {
        _innerStatus = status switch
        {
            "Active" => new Active(),
            "Inactive" => new Inactive(),
            _ => throw new NotSupportedException($"Status type '{status}' is not supported")
        };
    }

    public override string ToString()
    {
        return _innerStatus.Name;
    }

    public void Execute(Subject car, Executor executor)
    {
       _innerStatus.Execute(car, executor);
    }
}

public record Active : InnerStatus
{
    public void Execute(Subject car, Executor executor)
    {
        executor.RunActive(car);
    }
}

public record Inactive : InnerStatus
{
    public void Execute(Subject car, Executor executor)
    {
        executor.RunInActive(car);
    }
}