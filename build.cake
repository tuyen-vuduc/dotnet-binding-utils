// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=7.0.0

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

var ARTIFACT = Argument<string>("artifact");

Task("Default")
    .Does(() =>
{
    Information ($"ARTIFACT            : {ARTIFACT}");
    var props = $@"
    <Project>
    <ItemGroup>
        <GradleImplementation Include=""{ARTIFACT}""></GradleImplementation>
    </ItemGroup>
</Project>
    ";
    FileWriteText("./src/libs/BindingHost/BindingHost.xprops", props);
});

RunTarget ("Default");