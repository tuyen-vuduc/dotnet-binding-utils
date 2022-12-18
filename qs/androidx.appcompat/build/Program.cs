public static class Program
{
    public static int Main(string[] args)
    {
        return new CakeHost()
            .UseContext<BuildContext>()
            .Run(args);
    }
}

[TaskName("Default")]
[IsDependentOn(typeof(InitializeTask))]
public class DefaultTask : FrostingTask
{
}