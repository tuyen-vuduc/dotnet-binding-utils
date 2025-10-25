# Keep constant field names as it is

Java constants are usually all uppercase (e.g. `CREATOR`, `MAX_VALUE`) and are fields, but when generating C# bindings, they are generated as C# fields in PascalCase (e.g. `Creator`, `MaxValue`), it will lead to the confusion when reading Java/Kotlin docs to convert to C# code. The other case is that the constant fields are in uppercase, so they won't conflict with other members in Java, but when generating C# bindings, the managed name may conflicts, e.g. `CREATOR` field and `Creator` class will be generated with the same name in C#.

Goal: Keep the constant field names as it is in Java.

DO EXACTLY AS SPECIFIED AND IN EXACT ORDER. DON'T DEVIATE. STOP IF UNSURE.

Execution contract (must be followed exactly)

- Scope: Only propose metadata edits to preserve constant field names. Do not modify generated C# or other source files unless explicitly authorized.
- Edit policy: For each candidate constant, show the `api.xml` fragment and the single-line metadata `attr` to add, then add entries for all uppercase fields found to `Transforms/Metadata.xml`.
- Exceptions: Skip `CREATOR` and other fields listed in shared/common metadata unless the user specifically requests changes.
- Reporting: After changes, report which constant names were preserved and show the diff applied.

## File structure

```
|-- src
    |-- android
        |-- {ARTIFACT_GROUP}
            |-- {ARTIFACT_NAME}
                |-- binding
                    |-- {ARTIFACT_GROUP}.{ARTIFACT_NAME}.csproj
                    |-- obj
                        |-- Release
                            |-- net9.0-android <--- your target framework
                                |-- api.xml  <--- Inspect this file to find duplicate nodes
                    |-- Transforms
                        |-- Metadata.xml  <--- Edit this file to fix BG8401
                |-- nuget.json
                |-- {ARTIFACT_VERSION}.json 
```

## Steps to Follow:

1) Ensure `api.xml` generated

Run the binding command you normally use (example):

```bash
sh bind.sh --artifact $INPUT
```

2) Identify csproj files for the next steps.


The build log will look like this:

```
ProjectNameA net9.0-android failed with 189 error(s) and 24 warning(s) (7.1s)
    obj\Release\net9.0-android\api.xml(12721,8): warning BG8701: Invalid return type 'java.util.List<org.apache.commons.lang3.time.FastDatePrinter.Rule>' for member 'Org.Apache.Commons.Lang3.Time.FastDatePrinter.ParsePattern ()'.
    C:\Program Files\dotnet\packs\Microsoft.Android.Sdk.Windows\35.0.101\tools\Xamarin.Android.Bindings.Core.targets(97,5): obj\Release\net9.0-android\api.xml(12721,8) warning BG8701: Invalid return type 'java.util.List<org.apache.commons.lang3.time.FastDatePrinter.Rule>' for member 'Org.Apache.Commons.Lang3.Time.FastDatePrinter.ParsePattern ()'.
    obj\Release\net9.0-android\api.xml(12726,8): error BG8700: Unknown return type 'org.apache.commons.lang3.time.FastDatePrinter.NumberRule' for member 'Org.Apache.Commons.Lang3.Time.FastDatePrinter.SelectNumberRule (int, int)'.
ProjectNameB net9.0-android failed with 189 error(s) and 24 warning(s) (7.1s)
    obj\Release\net9.0-android\api.xml(12721,8): warning BG8701: Invalid return type 'java.util.List<org.apache.commons.lang3.time.FastDatePrinter.Rule>' for member 'Org.Apache.Commons.Lang3.Time.FastDatePrinter.ParsePattern ()'.
    C:\Program Files\dotnet\packs\Microsoft.Android.Sdk.Windows\35.0.101\tools\Xamarin.Android.Bindings.Core.targets(97,5): obj\Release\net9.0-android\api.xml(12721,8) warning BG8701: Invalid return type 'java.util.List<org.apache.commons.lang3.time.FastDatePrinter.Rule>' for member 'Org.Apache.Commons.Lang3.Time.FastDatePrinter.ParsePattern ()'.
    obj\Release\net9.0-android\api.xml(12726,8): error BG8700: Unknown return type 'org.apache.commons.lang3.time.FastDatePrinter.NumberRule' for member 'Org.Apache.Commons.Lang3.Time.FastDatePrinter.SelectNumberRule (int, int)'.
```

Based on the above, we have two csproj files to inspect: `ProjectNameA.csproj` and `ProjectNameB.csproj`. Each project name is composed of `{ARTIFACT_GROUP}.{ARTIFACT_NAME}`, so you can locate the project file in the folder structure above.

E.g. for `Org.Apache.Commons.CommonsLang3`, the csproj file is located at: `src/android/org.apache.commons/commons-lang3/binding/org.apache.commons.commonslang3.csproj`

3) Locate the generated api.xml

Each csproject has its own `obj/Release/net9.0-android/api.xml` file. You must identify the correct one for the error you're fixing based on the file structure above.

E.g. for `Org.Apache.Commons.CommonsLang3`, the api.xml file is located at: `src/android/org.apache.commons/commons-lang3/binding/obj/Release/net9.0-android/api.xml`

NOTE: 
- Target framework may vary (e.g. `net8.0-android` or `net9.0-android`, or other), so adjust accordingly.
- If project is built in Debug configuration, the path will be `obj/Debug/net9.0-android/api.xml`.
- If project is built in Release configuration, the path will be `obj/Release/net9.0-android/api.xml`.
- If project supports multiple target frameworks, you may have multiple folders under `obj/Release` (e.g. `net8.0-android`, `net9.0-android`), so inspect only the correct highest target framework folder.

LIST ALL `api.xml` FILES FOR EACH PROJECT IDENTIFIED IN STEP 2 for references.

4) Inspect the XML for all field nodes whose name attribute is in upper case

You're looking for field nodes which have the name attribute values in upper case (e.g. `MAX_VALUE`):

Examples (not exact schema — inspect your file):

```xml
<class name="MutableTriple">
	<field name="MAX_VALUE" type="..."/>
</class>
```

DISPLAY TOP 5 FIELD NAMES ALPHABETICALLY

If no field node is found, STOP HERE and ask for help.

Quick extraction (fast awk heuristic)

You can quickly list uppercase constant field names (fast heuristic, not XML-aware) with:

```bash
awk -F'name="' '{for(i=2;i<=NF;i++){split($i,a,"\""); if(a[1] ~ /^[A-Z0-9_]{2,}$/) print a[1]}}' "src/android/<group>/<artifact>/binding/obj/Release/net9.0-android/api.xml" | sort -u
```

Short explanation: this splits lines on `name="`, extracts the attribute value up to the next `"`, and prints only tokens that are entirely uppercase letters/digits/underscores (2+ chars). Use it for quick ad-hoc extraction; for robust/CI usage prefer an XML-aware tool (xmlstarlet/xmllint) or a small Python script.

5) Amend `Metadata.xml` within artifact folder only

For each field found, add an entry in `Metadata.xml` to keep the field name as it is in Java, i.e. all uppercase.
- targets the field by XPath: `//field[@name='FIELD_NAME']` <-- use the exact name from the XML
- and sets the `managedName` to the original name attribute value.

Example fix:
```xml
<attr path="//field[@name='MAX_VALUE']" name="managedName">MAX_VALUE</attr>
```

NOTE: Skip attr for `CREATOR` field as it's defined in the common file already.

6) Re-run the binding and verify

Run the bind script again or rebuild the binding project.


