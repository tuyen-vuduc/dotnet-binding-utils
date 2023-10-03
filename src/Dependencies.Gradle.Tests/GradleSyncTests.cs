﻿using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Xamarin.ContentPipeline.Tests;

namespace Dependencies.Gradle.Tests;

public class GradleSyncTests : TestsBase
{
    public static string Configuration = "Release";
    public static readonly string[] DEFAULT_IGNORE_PATTERNS = { "*.overridetasks", "*.tasks" };

    void AddCoreTargets(ProjectRootElement el)
    {
        var baseDir = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;

        var props = Path.Combine(baseDir, "..", "..", "source", "Dependencies.Gradle", "bin", Configuration, "netstandard20", "Dependencies.Gradle.props");

        if (!File.Exists(props))
            props = Path.Combine(baseDir, "..", "Dependencies.Gradle.props");

        el.AddImport(props);
        var targets = Path.Combine(baseDir, "..", "..", "source", "Dependencies.Gradle", "bin", Configuration, "netstandard20", "Dependencies.Gradle.targets");
        if (!File.Exists(targets))
            targets = Path.Combine(baseDir, "..", "Dependencies.Gradle.targets");

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

        prel.AddProperty("_GradleSyncIsAndroid", "true");
        prel.AddProperty("AndroidSdkDirectory", androidSdkFullPath);

        prel.AddItem(
            "GradleImplementation",
            "com.braintreepayments.api:three-d-secure:4.15.0",
            new Dictionary<string, string> { });
        prel.AddItem(
            "GradleRepository",
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
        
        AddCoreTargets(prel);

        var project = new ProjectInstance(prel);

        var log = new MSBuildTestLogger();
        var success = BuildProject(engine, project, "_GradleSync", log);

        AssertNoMessagesOrWarnings(log, DEFAULT_IGNORE_PATTERNS);
        Assert.True(success);
    }
}
