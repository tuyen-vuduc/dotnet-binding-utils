// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=7.0.0

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

var ARTIFACT = Argument<string>("artifact");
var DOTNET_VERSION = Argument<string>("dotnet", "8.0");
var TASK = Argument<string>("task", Argument<string>("t", "Default"));


Task("Setup Global.json")
    .Does(() =>
{
    var globalJsonFile = DOTNET_VERSION.StartsWith("8.0")
        ? "global.8.json"
        : "global.7.json";
    
    CopyFile($"./{globalJsonFile}", $"./global.json");
});

Task("Create BindingHost.props")
    .Does(() =>
{
    Information ($"ARTIFACT            : {ARTIFACT}");
    var props = $@"<Project>
    <ItemGroup>
        <GradleImplementation Include=""{ARTIFACT}""></GradleImplementation>
    </ItemGroup>
</Project>
    ";
    FileWriteText("./src/libs/BindingHost/BindingHost.props", props);
});
Task("Copy group maven.props")
    .Does(() =>
{
    var artifactParts = ARTIFACT.Split(new [] { ":" }, StringSplitOptions.RemoveEmptyEntries);
    var groupPropsPath = $"./src/android/{artifactParts[0]}/maven.props";
    if (FileExists(groupPropsPath))
    {
        Information ($"Maven for group            : {groupPropsPath}");
        CopyFile(groupPropsPath, $"./src/libs/BindingHost/{artifactParts[0]}_maven.props");
    } else {
        Information ($"Maven for group            : N/A");
    }
    var artifactPropsPath = $"./src/android/{artifactParts[0]}/{artifactParts[1]}/maven.props";
    if (FileExists(artifactPropsPath))
    {
        Information ($"Maven for artifact            : {artifactPropsPath}");
        CopyFile(artifactPropsPath, $"./src/libs/BindingHost/{artifactParts[0]})_{artifactParts[1]}_maven.props");
    } else {
        Information ($"Maven for artifact            : N/A");
    }
});

Task("Default")
    .IsDependentOn("Setup Global.json")
    .IsDependentOn("Create BindingHost.props")
    .IsDependentOn("Copy group maven.props")
    .Does(() => {
        Information ($"DONE");
    });

RunTarget (TASK);