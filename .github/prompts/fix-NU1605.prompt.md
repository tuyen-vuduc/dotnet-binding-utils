# Fix Dependency NU1605 warning

You're the expert in creating .NET bindings for Android libraries. Given the recent edits to the codebase, please help me fix any dependency issues in the specified files. Ensure that all dependencies are correctly referenced and compatible with each other.

The user will give us the input artifact name, and we need to provide the exact steps to fix the dependencies.

DO AS SPECIFIED. DON'T DEVIATE.

## Context

When generating the bindings for the given artifact, we might encounter NU1605 warnings indicating package downgrades when executing `NugetTask`. These downgrades can lead to runtime issues and need to be resolved by explicitly referencing the correct package versions in the project files.

The initial generated files will the `{ARTIFACT_VERSION}.json` and possibly a `nuget.json` file. The `{ARTIFACT_VERSION}.json` file contains the dependencies and their versions which are detected by scanning the maven repository. If there are downgrades, we need to create a new `{ARTIFACT_VERSION}.fixed.json` file with the correct versions to be used for the dependencies.

## NOTE
- Don't need to modify the existing `{ARTIFACT_VERSION}.json` or `nuget.json` files.
- Only create or update the `{ARTIFACT_VERSION}.fixed.json` file when there are NU1605 warnings.
- Do not include duplicate entries in the `{ARTIFACT_VERSION}.fixed.json` file.
- Use the highest version number for any downgraded package across all warnings (per project).
- Don't forget to propagate the correct versions to dependent projects.
- Ensure the file content is properly formatted as JSON.

### Example content of `{ARTIFACT_VERSION}.fixed.json`

{
    "Xamarin.Kotlin.StdLib": "2.0.21.1",
    "Xamarin.AndroidX.Fragment": "1.8.5.1"
}

## Steps to Follow:

1/ Run command: `sh bind.sh --artifact $INPUT`

NOTE: If you faced issue of gradle build failure, try to run `sh kill-jd.sh` to kill any hanging java processes and re-run the command.

Where:

$INPUT is the artifact fully qualified name provided by the user, e.g. `com.mapbox.maps:android-ndk27:11.15.2`

ARTIFACT_VERSION is the version part of the artifact, e.g. `11.15.2`

2/ Analyze the build output for any NU1605 warnings.

e.g.

```text
your_repo_folder/src/android/com.facebook.android/facebook-login/binding/Com.Facebook.Android.FacebookLogin.csproj : warning NU1605:
      Detected package downgrade: Xamarin.Kotlin.StdLib from 2.2.0.1 to 1.8.20.1. Reference the package directly from the project to select a different version.
       Com.Facebook.Android.FacebookLogin -> Xamarin.AndroidX.AppCompat 1.1.0.2 -> Xamarin.AndroidX.Annotation 1.9.1.5 -> Xamarin.Kotlin.StdLib (>= 2.2.0.1)
       Com.Facebook.Android.FacebookLogin -> Xamarin.Kotlin.StdLib (>= 1.8.20.1)
```

3/ Group the warnings by the project file (e.g. `facebook-login/binding/Com.Facebook.Android.FacebookLogin.csproj`) and the downgraded package (e.g. `Xamarin.Kotlin.StdLib`).

4/ Create `artifact-version.fixed.json` files for each project that has downgrades. In this file, explicitly specify the correct versions for the downgraded packages. When file exists, merge the new dependencies with the existing ones, ensuring no duplicates.

File structure will look like this:

```
|-- src
    |-- android
        |-- {ARTIFACT_GROUP}
            |-- {ARTIFACT_NAME}
                |-- binding
                    |-- {ARTIFACT_GROUP}.{ARTIFACT_NAME}.csproj
                |-- nuget.json
                |-- {ARTIFACT_VERSION}.json 
                |-- {ARTIFACT_VERSION}.fixed.json  <--- Create this file with the correct versions

```

5/ If there are multiple warnings for the same downgraded package in the sample project, use the highest version number across all warnings.

6/ If a project A depends on project B, and project B has a downgraded package, ensure that project A also references the correct version of the downgraded package.

