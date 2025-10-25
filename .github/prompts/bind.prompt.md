# Create the binding library for a given Gradle artifact

Your task is to create the binding library for a given Gradle artifact based on the provided information.

DO EXACTLY AS SPECIFIED AND IN EXACT ORDER. DON'T DEVIATE. STOP IF UNSURE.

ALWAYWS LIST ALL TASKS AND SUBTASKS IN ORDER.

## Execution contract (must be followed exactly)

- Scope: Only perform the exact steps the user requests. If there is a reference to an external guidance, follow that guidance. If there is any uncertainty, stop and ask for clarification.
- Edit policy: Prefer edits only to artifact-specific `Transforms/Metadata.xml`; otherwise approvals required. Do not modify generated code unless explicitly asked; temporary generated-file edits must be reverted and not committed.
- Branch & commit policy: Don't create branches or commits without explicit user approval.
- Reporting: After any run or edit, return a short structured report: (1) exact command(s) run, (2) files changed with one-line reason, (3) build/test/lint summary, (4) next recommended steps.
- Always run commands in bash terminal unless explicitly instructed otherwise.
- Do step by step, no skipping.

## Inputs

- $ARTIFACT: fully qualified artifact name (e.g., `com.example:my-artifact:1.0.0`)
- $MAVEN: Custom maven configuration for gradle (optional)

## Steps

### 1/ Creates the necessary folder structure for the artifact in the Gradle repository.

Folder structure:

```
|-- src
    |-- android
        |-- {ARTIFACT_GROUP}
            |-- maven.props (if $MAVEN is provided, if exists, skip except forced)
            |-- {ARTIFACT_NAME} (folder)

```

- Only create maven.props file if $MAVEN is provided. 
- Rewrite $MAVEN configuration in Kotlin DSL as needed.

Example of `maven.props` content:

<Project> 
  <ItemGroup>
    <GradleRepository Include="{MAVEN_URL}">
      <Repository>
      {$MAVEN}
      </Repository>
    </GradleRepository>
  </ItemGroup>
</Project>

### 2/ Execute `bind.sh` script to bind the artifact.

(ALWAYS RUN THIS COMMAND IN THE REPO ROOT FOLDER)
```
sh bind.sh --artifact $ARTIFACT
```

### 3/ Fix GDL001/GDL004 error if any

#### 3.1/ Kill any hanging java processes then rerun the bind command:

```
sh kill-jd.sh
```

#### 3.2/ Check gradle build status then re-run the bind command.

- navigate to `xgradle` folder
- run `./gradlew.bat build` (Windows) or `./gradlew build` (Linux/Mac)

##### 3.2.a/ Missing reference to Google material design library
if you see error like:

```
Android resource linking failed
     error: resource style/Theme.MaterialComponents.DayNight.NoActionBar.Bridge (aka tech.tuyen_vuduc.gradle_util:style/Theme.MaterialComponents.DayNight.NoActionBar.Bridge) not found.
```

Then we will add

- one item to `{ARTIFACT_VERSION}.missing.json` file (create if not exists) in the artifact folder with the missing dependency.:

Example of `{ARTIFACT_VERSION}.missing.json` content:
```
[
  "com.google.android.material:material:1.12.0"
]
```
- one item to `maven.props` file (create if not exists) in the artifact group folder with the missing dependency.:
Example of `maven.props` content:
```
<Project>
  <ItemGroup>
    <GradleImplementation Include="com.google.android.material:material:1.12.0"></GradleImplementation>
  </ItemGroup>
</Project>
```

Then re-run the bind command.

##### 3.2.b/ Need to enable Jetifier

if you see error like:

```
A failure occurred while executing com.android.build.gradle.internal.tasks.CheckDuplicatesRunnable
   > Duplicate class android.support.v4.app.INotificationSideChannel found in modules core-1.9.0.aar -> core-1.9.0-runtime (androidx.core:core:1.9.0) and support-compat-26.1.0.aar -> support-compat-26.1.0-runtime (com.android.support:support-compat:26.1.0)
     Duplicate class android.support.v4.app.INotificationSideChannel$Stub found in modules core-1.9.0.aar
```

We will add one item to `maven.props` file (create if not exists) in the artifact group folder with the missing dependency.

Example of `maven.props` content:
```
<Project>
  <PropertyGroup>
    <GradleSyncEnableJetifier>true</GradleSyncEnableJetifier>
  </PropertyGroup>
</Project>
```
Then re-run the bind command.

##### Otherwise, stop the task entirely here (no retry)

### 4/ Keep the field names in upper case following [keep constant field names prompt](keep-constanst-field-names.prompt.md) guidelines

### 5/ Fix any NU1605 warnings following [fix nu1605 prompt](fix-NU1605.prompt.md) guidelines only if there are NU1605 warnings.

### 6/ Fix issue of BG8401 following [fix BG8401 prompt](fix-BG8401.prompt.md) guidelines only if there are BG8401 errors.

### 7/ Fix error XDCDJ7028

If you see error like:

```
C:\Program Files\dotnet\packs\Microsoft.Android.Sdk.Windows\34.0.154\tools\Xamarin.Android.Common.targets(893,3): error XACDJ7028:
      System.IO.FileNotFoundException: Could not find file '~\.gradle\caches\modules-2\files-2.1\org.jetbrains.kotlin\kotlin-android-extensions-runtime\1.6.10\4a6b6e4fb87c54c5d2
      a7eb51a497ac23dd200d62\kotlin-android-extensions-runtime-1.6.10.jar'.
      File name: '~\.gradle\caches\modules-2\files-2.1\org.jetbrains.kotlin\kotlin-android-extensions-runtime\1.6.10\4a6b6e4fb87c54c5d2a7eb51a497ac23dd200d62\kotlin-android-exte
      nsions-runtime-1.6.10.jar'
```

Then we will add one item to `maven.props` file (create if not exists) in the artifact group folder with the missing dependency.

```
<Project>
  <ItemGroup>
    <GradleImplementation Include="org.jetbrains.kotlin:kotlin-android-extensions-runtime:1.6.10"></GradleImplementation>
  </ItemGroup>
</Project>
```

### Otherwise, stop and suggest next steps.

