namespace MetadataFetcher.Tests;

public class FetcherTests
{
    static FetcherTests()
    {
        Fetcher.BasePath = Path.Combine(
            Environment.CurrentDirectory,
            "../../../../.."
        );
    }

    [Theory]
    [InlineData("Xamarin.AndroidX.Activity", "androidx.activity", "activity")]
    public Task Fetch_Android(string nugetId, string groupId, string artifactId)
    {
        return Fetcher.FetchAsync(nugetId, groupId, artifactId, "android", (packageId, error) =>
        {
            Console.WriteLine($"{packageId} >> {error}");
        });
    }
}