# HOW to USE

## Preparation

1/ Copy `nugets` folder to the root of your SLN folder

```
- root-project-folder
    |- your-sln-file.sln
    |- nugets
        |- *.nupkg
```

2/ Create a `nuget.config` file with this similar content

```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="Local" value="./nugets" />
  </packageSources>
  <packageSourceCredentials>
  </packageSourceCredentials>
</configuration>
```

NOTE: Place it in your sln root folder
```
- root-project-folder
    |- your-sln-file.sln
    |- nugets
        |- *.nupkg
    |- nuget.config
```


2/ Create `{your-project-file-name}.props` file with this content
```
<?xml version="1.0" encoding="UTF-8" ?>
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
	<ItemGroup>
        <GradleRepository Include="https://maven.pkg.github.com/ims-developers/android-sdk">
            <Repository>
        maven {
            url 'https://maven.pkg.github.com/ims-developers/android-sdk'
            credentials {
                username 'YOUR_GITHUB_USERNAME'
                password 'YOUR_GITHUB_PAT'
            }
        }
            </Repository>
        </GradleRepository>
	</ItemGroup>
</Project>
```

NOTE-1/3: Place it in your project folder

```
- root-project-folder
    |- your-sln-file.sln
    |- nugets
        |- *.nupkg
    |- nuget.config
    |- your-project-folder-name
        |- your-project-file-name.csproj
        |- your-project-file-name.props
```

NOTE-2/3: If you have multiple projects, you can share this `props` file accross them

NOTE-3/3: You shouldn't commit this file into GIT

3/ Amend your app `{your-project-file-name}.csproj` file

```
<Project Sdk="Microsoft.NET.Sdk">
	<Import Condition="EXISTS('{your-project-file-name}.props')" Project="{your-project-file-name}.props" />
    <!-- other lines -->
</Project>
```

## Installation

CHOOSE ONE OF THESE FOLLOWING APPROACHES

1/ Amend your app `{your-project-file-name}.csproj` file
```
<ItemGroup>
      <PackageReference Include="Com.Intellimec.Mobile.Android.Tripdetectionumbrella" Version="1.16.0" />
      <PackageReference Include="Com.Intellimec.Mobile.Android.Distracteddriving" Version="3.11.0" />
      <PackageReference Include="Com.Drivesync.Android.DevicesWedge" Version="1.16.0" />
</ItemGroup>
```

2/ User CLI or Nuget Package Manager
```
dotnet nuget add Com.Intellimec.Mobile.Android.Tripdetectionumbrella
dotnet nuget add Com.Intellimec.Mobile.Android.Distracteddriving
dotnet nuget add Com.Drivesync.Android.DevicesWedge
```