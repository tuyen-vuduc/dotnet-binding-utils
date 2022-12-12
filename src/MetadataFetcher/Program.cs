using System.CommandLine;
 
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("NuGet Metadata Fetcher");
Console.WriteLine("=======================");

var nupkgIdOption = new Option<string>
    (new [] { "--nupkg-id", "-n" }, "A case-sensitive NuGet package ID");
var groupIdOption = new Option<string>
    (new [] { "--group-id", "-g" }, "The maven group ID of the native artifact");
var artifactIdOption = new Option<string>
    (new [] { "--artifact-id", "-a" }, "The native artifact ID");
var platformOption = new Option<string>
    (new [] { "--platform", "-p" }, () => "android", "e.g. android, ios, windows");

var rootCommand = new RootCommand("Parameter binding example");
rootCommand.Add(nupkgIdOption);
rootCommand.Add(groupIdOption);
rootCommand.Add(artifactIdOption);
rootCommand.Add(platformOption);

rootCommand.SetHandler(
    (nupkgId, groupId, artifactId, platform) 
        => Fetcher.FetchAsync(nupkgId, groupId, artifactId, platform, (packageId, errorMessage) => {
            Console.WriteLine("=======================");
            Console.WriteLine($"{packageId} >> {errorMessage}");
        }),
    nupkgIdOption, groupIdOption, artifactIdOption, platformOption
);

await rootCommand.InvokeAsync(args);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("=======================");
Console.WriteLine("DONE");
Console.ResetColor();