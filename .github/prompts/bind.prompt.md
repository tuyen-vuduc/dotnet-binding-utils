# Create the binding library for a given Gradle artifact

Your task is to create the binding library for a given Gradle artifact based on the provided information.

DO AS SPECIFIED. DON'T DEVIATE. STOP IF UNSURE.

## Inputs

- $ARTIFACT: fully qualified artifact name (e.g., `com.example:my-artifact:1.0.0`)
- $MAVEN: Custom maven configuration for gradle (optional)

## Outputs

1/ Creates the necessary folder structure for the artifact in the Gradle repository.

Folder structure:

```
|-- src
    |-- android
        |-- {ARTIFACT_GROUP}
            |-- maven.props (if $MAVEN is provided, if exists, skip except forced)
            |-- {ARTIFACT_NAME} (folder)

```

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

2/ Execute `bind.sh` script to bind the artifact.

(ALWAYS RUN THIS COMMAND IN THE REPO ROOT FOLDER)
```
sh bind.sh --artifact $ARTIFACT
```

## GDL001 Troubleshooting

1/ Kill any hanging java processes then rerun the bind command:

```
sh kill-jd.sh
```

2/ Check gradle build status then re-run the bind command.

- navigate to `xgradle` folder
- run `./gradlew.bat build` (Windows) or `./gradlew build` (Linux/Mac)

2.a/ Missing reference to Google material design library
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

2.b/ Otherwise, stop the task entirely here (no retry)

3/ Keep the field names in upper case following [keep constants field names prompt](keep-constanst-field-names.prompt.md) guidelines

4/ Fix any NU1605 warnings following [fix nu1605 prompt](fix-NU1605.prompt.md) guidelines only if there are NU1605 warnings.

5/ Fix issue of BG8401 following [fix BG8401 prompt](fix-BG8401.prompt.md) guidelines only if there are BG8401 errors.

Otherwise, stop and suggest next steps.

