using DotnetBindings.Cake;

public static class Program
{
    public static int Main(string[] args)
    {
        return new CakeHost()
            .AddAssembly(typeof(BuildContext).Assembly)
            .UseContext<BuildContext>()
            .Run(args);
    }
}

[TaskName("Default")]
[IsDependentOn(typeof(NugetTask))]
public class DefaultTask : FrostingTask
{
}