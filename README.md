# dotnet-binding-utils

**dotnet-binding-utils** is a toolset to create binding libraries easier and more simple for native Android, native iOS libraries.

I hope it will enable everyone to create, maintain .NET binding libraries either privately or publically.

# Tools

## Brief
| ID | Name/Nuget           | Description                                                       |
|----|------------          |-------------                                                      |
| 01 | Dependencies.Gradle  | Make use of gradle to download Android/Java native dependencies   |
| 02 | Binderators.Gradle   | Make use of gradle to download dependencies, form up the dependent tree, then generated appropriate binding csproj and targets. |
| 03 | MetadataFetcher      | Fetch and map native libaries with their NuGet packages |

## Notes
You should install Android Studio or place Android SDK at the following location and use for Visual Studio.

- MacOS: `$(Home)/Library/Android/sdk`
- Windows: `$(UserProfile)/AppData/Local/Android/sdk`

## Usage

### 1) Dependencies.Gradle

**WHY** 

Gradle is the build tool for building Android using native tech stacks such as Java, Kotlin. A part of it is to resolve all dependencies of the working project and cache them globally within the development machine. By leverage Gradle, we will save disk space, bandwidth and downloading time if we also work with Java/Kotlin, Flutter, etc.

**HOW IT WORKS**

- We will create an empty Android project with initial setup of ZERO dependencies.
- We then define dependencies as items inside the CSPROJ file
- We can also define custom repositories with appropriate credentials
- We can also add custom properties as well
- We then generate appropriate properties file, appropriate build.gradle files
- We finally trigger `gradlew build` to resolve all dependencies upon building the csproj

**HOW TO USE**

a) Installation
```
dotnet add package Dependencies.Gradle
```

b) Add an implementation

```
<ItemGroup>
    <GradleImplementation Include="com.braintreepayments.api:three-d-secure:4.15.0" />
</ItemGroup>
```

equals to

```
dependencies {
    implementation 'com.braintreepayments.api:three-d-secure:4.15.0'
}
```

c) Add a repository

```
<ItemGroup>
    <GradleRepository Include="https://api.mapbox.com/downloads/v2/releases/maven">
        <Repository>
        maven {
            url 'https://api.mapbox.com/downloads/v2/releases/maven'
            authentication {
                basic(BasicAuthentication)
            }
            credentials {
                // Do not change the username below.
                // This should always be `mapbox` (not your username).
                username = "mapbox"
                // Use the secret token you stored in gradle.properties as the password
                password = MAPBOX_DOWNLOADS_TOKEN
            }
        }
        </Repository>
    </GradleRepository>
</ItemGroup>
```

equals to

```
repositories {
    maven {
        url 'https://api.mapbox.com/downloads/v2/releases/maven'
        authentication {
            basic(BasicAuthentication)
        }
        credentials {
            // Do not change the username below.
            // This should always be `mapbox` (not your username).
            username = "mapbox"
            // Use the secret token you stored in gradle.properties as the password
            password = MAPBOX_DOWNLOADS_TOKEN
        }
    }
}
```

d) Add a property

```
<ItemGroup>
    <GradleProperty Include="MAPBOX_DOWNLOADS_TOKEN">
        <Value>YOUR_MAPBOX_DOWNLOADS_TOKEN</Repository>
    </GradleRepository>
</ItemGroup>
```

equals to

```
MAPBOX_DOWNLOADS_TOKEN=YOUR_MAPBOX_DOWNLOADS_TOKEN
```

**NOTE** ATM, we have to
- Use the same SDK folder with Android Studio
- Run an Android project at least one

### Binderators.Gradle

**WHY**

After downloading dependencies, we need to create the binding assets. Following the way of creating a binding library for AndroidX library, we will need two assets
- `binding-library.csproj`: A Xamarin.Legacy.Sdk csproj file to target both Xamarin.Android and .net-android is the binding library itself.
- `binding-library.targets`: A XML file defines how the native library will be resolved by Gradle and included into the main Android project.

These assets are almos the same for every native libraries, except

- groupId, artifactId, version
- repository and additional properties

Hence, we formalize a data model and make use of [RazorLight](https://www.nuget.org/packages/RazorLight) to generate the above assets based on given Razor template file.

**NOTE** This library is intended to use with Cake Frosting approach.

a) Preparation
- Clone and make your own copies of `Projects.cshtml`, `Targets.cshtml`
- Edit relevant info for your libraries
- `POM.cshtml` - I have no idea what it is for yet =D
- Clone and make your own copies of `config.json`

The data model for these razor template will have following properties

- `StandardizedName`: A valid C# name to use
- `NuGetPackageId`: A valid C# name to use
- `NuGetVersion`: The NuGet version
- `Version`: The native version
- `Dependencies`: List of dependencies of the native library

    - `StandardizedName`: A valid C# name to use
    - `NuGetPackageId`: A valid C# name to use
    - `NuGetVersion`: The NuGet version
    - `Version`: The native version
    - `DependencyOnly`: True if no binding project required; False otherwise

b) Installation

```
dotnet add package Binderators.Gradle
```

**NOTE**: We will use this library along with `Dependencies.Gradle`. To trigger the gradle process to run, we have to add this property `<_GradleSyncIsAndroid>true</_GradleSyncIsAndroid>` to our CSPROJ file.

c) Make the call

- Get all native libraries' info for given groupId, artifactId and version
```
ArtifactScanner.Scan(
    List<ArtifactModel> existingArtifacts,  // pass an empty list for most cases
    string basePath,                        // pass the folder path where the generated file will be
    string groupId,                         
    string artifactId,
    string version,
    Action<string> log,                     // invoked when error, important event happens e.g. missing dependencies
    List<string> missingArtifacts = null    // missing items
)
```

- Generate files mentioned above
```
Engine.BinderateAsync(
    string configFile,              // confile file name with extension e.g. config.json
    string basePath,                // the folder path where files will be generated
    List<ArtifactModel> artifacts   // the list of artifacts to generate binding assets (received by Scan)
)
```

### 3) MetadataFetcher

**WHY**
- Many C# bound libraries are created for the same native library
- C# bound library has the different version and/or name from the native library's

This tool will allow use to grab the info of the preferred bound native libraries for native libraries so we can easily reuse in multiple binding projects later on.

**HOW TO USE**

a) Add new test case

For a particular bound C# library, we create a new inline data for the test in `FetcherTests.cs`

e.g.

```
[Theory]
[InlineData("Xamarin.AndroidX.Activity", "androidx.activity", "activity")]
....other test cases
....other test cases
....other test cases
public Task Fetch_Android(string nugetId, string groupId, string artifactId)
{
    return Fetcher.FetchAsync(nugetId, groupId, artifactId, "android", (packageId, error) =>
    {
        Console.WriteLine($"{packageId} >> {error}");
    });
}
```

b) Run the test

```
sh fetch.sh
```

## NOTES

1) Add metadata for `due to duplicate`

```js
// Use browser inspector to execute
var x = `FILTERED_ERRORS`;
console.log(
    x
    .split('\n')
    .filter(item => item.indexOf('Xamarin.Android.Bindings.Core.targets') == -1)
    .filter(item => item.indexOf('net6.0') == -1)
    .map(item => /'([^']+)'.+/.exec(item)[1])
    .map(item => /.(\w+)$/.exec(item)[1])
    .map(item => item[0].toLowerCase() + item.substring(1))
    .map(item => `<attr path="//field[@name='${item}']" name="managedName">${item}</attr>`)
    .join('\n')
)
```

2) Add metadata for `cannot change access modifiers when overriding`

```js
// Use browser inspector to execute
var x = `FILTERED_ERRORS`;
console.log(
    x
    .split('\n')
    .filter(item => item.indexOf('Xamarin.Android.Bindings.Core.targets') == -1)
    .filter(item => item.indexOf('net6.0') == -1)
    .map(item => /'([^']+)'.+/.exec(item)[1])
    .map(item => /(\w+).(\w+)\((.+)*\)/.exec(item))
    .map(item => Array.prototype.slice.call(item, 1, item.length))
    .map(item => `<attr path="//class[@name='${item[0]}']/method[@name='${item[1][0].toLowerCase() + item[1].substring(1)}' and count(parameter)=${(item[2] ? item[2].split(',').length : 0)}]" name="visibility">protected</attr>`)
    .join('\n')
)
```

3) Add metadata for `return type must be 'Object' to match overridden member`

```js
// Use browser inspector to execute
var x = `FILTERED_ERRORS`;
console.log(
    x
    .split('\n')
    .filter(item => item.indexOf('Xamarin.Android.Bindings.Core.targets') == -1)
    .filter(item => item.indexOf('net6.0') == -1)
    .map(item => /'([^']+)'.+/.exec(item)[1])
    .map(item => /(\w+).(\w+)\((.+)*\)/.exec(item))
    .map(item => Array.prototype.slice.call(item, 1, item.length))
    .map(item => `<attr path="//class[@name='${item[0]}']/method[@name='${item[1][0].toLowerCase() + item[1].substring(1)}' and count(parameter)=${(item[2] ? item[2].split(',').length : 0)}]" name="managedReturn">Java.Lang.Object</attr>`)
    .join('\n')
)
```

4) Add metadata for `type must be 'ICollection<string>' to match overridden member`

```js
// Use browser inspector to execute
var x = `FILTERED_ERRORS`;
console.log(
    x
    .split('\n')
    .filter(item => item.indexOf('Xamarin.Android.Bindings.Core.targets') == -1)
    .filter(item => item.indexOf('net6.0') == -1)
    .map(item => /'([^']+)'.+/.exec(item)[1])
    .map(item => /(\w+).(\w+)/.exec(item))
    .map(item => Array.prototype.slice.call(item, 1, item.length))
    .map(item => `<attr path="//class[@name='${item[0]}']/method[@name='get${item[1]}']" name="managedReturn">System.Collections.Generic.ICollection&lt;string&gt;</attr>`)
    .join('\n')
)
```

5) Add metadata for `it does not have the matching return type of 'ICollection<string>'`

```js
// Use browser inspector to execute
var x = `FILTERED_ERRORS`;
console.log(
    x
    .split('\n')
    .filter(item => item.indexOf('Xamarin.Android.Bindings.Core.targets') == -1)
    .filter(item => item.indexOf('net6.0') == -1)
    .map(item => /\. '([^']+)'.+/.exec(item)[1])
    .map(item => /(\w+).(\w+)/.exec(item))
    .map(item => Array.prototype.slice.call(item, 1, item.length))
    .map(item => `<attr path="//class[@name='${item[0]}']/method[@name='get${item[1]}']" name="managedReturn">System.Collections.Generic.ICollection&lt;string&gt;</attr>`)
    .join('\n')
)
```

6) Fix for Companion field
```
<attr path="//field[@name='Companion']" name="managedName">CompanionField</attr>
```

# Maintainer
This project is maintained by [tuyen-vuduc](https://github.com/tuyen-vuduc) in his spare time and/or when requested.<br>

If you find this project is helpful and benefit your work/business, please give it a star, become a sponsor of the project and/or buy him a coffee.

[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/tuyen.vuduc)

# License

The 3rd libraries will follow their associated licenses. This project itself is licensed under the 3-Clause BSD License.

Copyright 2023 tuyen-vuduc

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.

3. Neither the name of the copyright holder nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS “AS IS” AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.