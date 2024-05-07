// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=7.0.0

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

var ARTIFACT = Argument<string>("artifact");
var TASK = Argument<string>("task", Argument<string>("t", "Default"));

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
        Information ($"MAVEN_PROPS            : {groupPropsPath}");
        CopyFile(groupPropsPath, $"./src/libs/BindingHost/{artifactParts[0]}_maven.props");
    } else {
        Information("NO CUSTOM maven.props for group");
    }
    var artifactPropsPath = $"./src/android/{artifactParts[0]}/{artifactParts[1]}/maven.props";
    if (FileExists(artifactPropsPath))
    {
        Information ($"MAVEN_PROPS            : {artifactPropsPath}");
        CopyFile(artifactPropsPath, $"./src/libs/BindingHost/{artifactParts[0]})_{artifactParts[1]}_maven.props");
    } else {
        Information("NO CUSTOM maven.props for artifact");
    }
});

Task("Default")
    .IsDependentOn("Create BindingHost.props")
    .IsDependentOn("Copy group maven.props")
    .Does(() => {
        Information ($"DONE");
    });

RunTarget (TASK);