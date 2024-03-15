using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Binderator.Gradle;

public static class SolutionFileBuilder
{
    public static string Build(BindingConfig config, Dictionary<string, BindingProjectModel> projects)
    {
        var csprojNamespaces = new XmlNamespaceManager(new NameTable());
        csprojNamespaces.AddNamespace("ns", "http://schemas.microsoft.com/developer/msbuild/2003");

        var s = new StringBuilder();

        s.AppendLine();
        s.AppendLine("Microsoft Visual Studio Solution File, Format Version 12.00");
        s.AppendLine("# Visual Studio Version 17");
        s.AppendLine("VisualStudioVersion = 17.7.34031.279");
        s.AppendLine("MinimumVisualStudioVersion = 10.0.40219.1");

        foreach (var project in projects)
        {
            s.AppendLine("Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") = \"" + 
                project.Value.Artifact.Nuget.PackageId + "\", \"" + 
                project.Key + "\", \"{" + project.Value.Id + "\"}");
            s.AppendLine("EndProject");
        }

        s.AppendLine("Global");

        s.AppendLine("\tGlobalSection(SolutionConfigurationPlatforms) = preSolution");
        s.AppendLine("\t\tDebug|Any CPU = Debug|Any CPU");
        s.AppendLine("\t\tRelease|Any CPU = Release|Any CPU");
        s.AppendLine("\tEndGlobalSection");

        s.AppendLine("\tGlobalSection(ProjectConfigurationPlatforms) = postSolution");
        foreach (var project in projects)
        {
            s.AppendLine("\t\t{" + project.Value.Id + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            s.AppendLine("\t\t{" + project.Value.Id + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            s.AppendLine("\t\t{" + project.Value.Id + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            s.AppendLine("\t\t{" + project.Value.Id + "}.Release|Any CPU.Build.0 = Release|Any CPU");
        }
        s.AppendLine("\tEndGlobalSection");

        s.AppendLine("EndGlobal");

        return s.ToString();
    }
}
