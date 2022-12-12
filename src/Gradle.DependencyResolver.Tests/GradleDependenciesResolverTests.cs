using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Xamarin.ContentPipeline.Tests;

namespace Gradle.DependencyResolver.Tests;

public class GradleDependenciesResolverTests : TestsBase
{
    public static string Configuration = "Release";
    public static readonly string[] DEFAULT_IGNORE_PATTERNS = { "*.overridetasks", "*.tasks" };

    void AddCoreTargets(ProjectRootElement el)
    {
        var baseDir = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;

        var props = Path.Combine(baseDir, "..", "..", "source", "Gradle.DependencyResolver", "bin", Configuration, "netstandard20", "Gradle.DependencyResolver.props");

        if (!File.Exists(props))
            props = Path.Combine(baseDir, "..", "Gradle.DependencyResolver.props");

        el.AddImport(props);
        var targets = Path.Combine(baseDir, "..", "..", "source", "Gradle.DependencyResolver", "bin", Configuration, "netstandard20", "Gradle.DependencyResolver.targets");
        if (!File.Exists(targets))
            targets = Path.Combine(baseDir, "..", "Gradle.DependencyResolver.targets");

        el.AddImport(targets);

    }

    [Fact]
    public void CheckItOutTest()
    {
        var localPath = Xamarin.Build.Download.Platform.IsWindows
            ? Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            : Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        var androidSdkFullPath = Path.Combine(localPath, "Library/Android/sdk");

        var engine = new ProjectCollection();
        var prel = ProjectRootElement.Create(Path.Combine(TempDir, "project.csproj"), engine);

        prel.AddProperty("_GradleDependencyResolverIsAndroid", "true");
        prel.AddProperty("AndroidSdkDirectory", androidSdkFullPath);

        prel.AddItem(
            "GradleDependencyResolverProperty",
            "MAPBOX_DOWNLOADS_TOKEN=sk.eyJ1IjoidHV5ZW52IiwiYSI6ImNsMnRqNTc2MTA0dHIzcW13emF5M2cycTEifQ.3_F3OAZMw5Tq9S_9PK_olA",
            new Dictionary<string, string> {});

        prel.AddItem(
            "GradleDependencyResolverImplementation",
            "com.braintreepayments.api:three-d-secure:4.15.0",
            new Dictionary<string, string> { });
        prel.AddItem(
            "GradleDependencyResolverImplementation",
            "com.mapbox.maps:android:10.5.0",
            new Dictionary<string, string> { });
        prel.AddItem(
            "GradleDependencyResolverRepository",
            "https://cardinalcommerceprod.jfrog.io/artifactory/android",
            new Dictionary<string, string> {
                    { "Repository", @"maven {
    url ""https://cardinalcommerceprod.jfrog.io/artifactory/android""
    credentials {
        username 'braintree_team_sdk'
        password 'AKCp8jQcoDy2hxSWhDAUQKXLDPDx6NYRkqrgFLRc3qDrayg6rrCbJpsKKyMwaykVL8FWusJpp'
    }
}" },
            });
        prel.AddItem(
            "GradleDependencyResolverRepository",
            "https://api.mapbox.com/downloads/v2/releases/maven",
            new Dictionary<string, string> {
                    { "Repository", @"
        maven {
            url 'https://api.mapbox.com/downloads/v2/releases/maven'
            authentication {
                basic(BasicAuthentication)
            }
            credentials {
                // Do not change the username below.
                // This should always be `mapbox` (not your username).
                username = ""mapbox""
                // Use the secret token you stored in gradle.properties as the password
                password = MAPBOX_DOWNLOADS_TOKEN
            }
        }" },
            });
        AddCoreTargets(prel);

        var project = new ProjectInstance(prel);

        var log = new MSBuildTestLogger();
        var success = BuildProject(engine, project, "_GradleDependencyResolver", log);

        AssertNoMessagesOrWarnings(log, DEFAULT_IGNORE_PATTERNS);
        Assert.True(success);
    }
}
