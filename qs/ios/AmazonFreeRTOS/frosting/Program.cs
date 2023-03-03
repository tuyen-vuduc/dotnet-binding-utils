using Cake.Frosting;

public static class Program
{
    public static int Main(string[] args)
    {
        Console.WriteLine(string.Join("\n", args));

        return new CakeHost()
            .UseContext<BuildContext>()
            .Run(args);
    }
}
