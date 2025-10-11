# Fix BG8401 — duplicate nested type errors in generated api.xml

This prompt explains how to locate and fix BG8401 errors produced by the Xamarin.Android binding generator when the generated `api.xml` contains duplicate nested-type/class nodes. Example error we want to fix:

```
obj\Release\net9.0-android\api.xml(6946,8): error BG8401: Skipping 'Com.Izettl
			e.UI.Components.Modal.OttoDialogComponent.DialogComponentClickListeners.CREATOR'
			 due to a duplicate nested type name. (Java type: 'com.izettle.ui.components.mod
			al.OttoDialogComponent.DialogComponentClickListeners')
```

Goal: edit or remove the problematic node(s) in the generated XML so the binding build no longer emits BG8401 for that Java type, while keeping the binding behavior correct.

DO AS SPECIFIED. DON'T DEVIATE. STOP IF UNSURE.

Execution contract (must be followed exactly)

- Scope: Only perform actions explicitly requested by the user. If there is a reference to an external guidance, follow that guidance. If there is any uncertainty, stop and ask for clarification.
- Metadata-first policy: Always prefer adding `managedName` attributes to `Transforms/Metadata.xml` in the artifact folder. Editing generated `api.xml` or generated C# is only allowed for diagnostics with explicit approval and must be reverted.
- Approval workflow: For any edit, present (a) the api.xml fragment causing BG8401, (b) the metadata patch as a unified diff, and (c) apply changes except if you change files other than `Transforms/Metadata.xml`.
- Reporting: After applying a change, provide a 4-line report: what change, why, files edited, and verification results (BG8401 cleared or new errors).

## Why this happens

1/ When generating C# bindings for Java/Kotlin libraries, a field with proper wrapper methods will be generated as a property in C#. If the field is private, it won't be generated a field in C#, but when the field is public or protected, it will be generated as a field in C#. For this case, the name in C# will be the same as the mapped property name -> causes conflict.
2/ Java constants are usually all uppercase (e.g. `CREATOR`, `MAX_VALUE`) and are fields, but when generating C# bindings, they are generated as C# fields in PascalCase (e.g. `Creator`, `MaxValue`), it will lead to the confusion when reading Java/Kotlin docs to convert to C# code. The other case is that the constant fields are in uppercase, so they won't conflict with other members in Java, but when generating C# bindings, the managed name may conflicts, e.g. `CREATOR` field and `Creator` class will be generated with the same name in C#.

When either of these happens, we will get error of BG8401: The nested type 'X' was skipped because a member with the same name already exists in the enclosing type 'Y'. Consider renaming one of the members to avoid the conflict.

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

1) Reproduce the error

Run the binding command you normally use (example):

```bash
sh bind.sh --artifact $INPUT
```

2) Group the errors by csproj file for the next steps.

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

Errors/warnings/messages are indented under the project name line. Group them by project file for the next steps.

2) Locate the generated api.xml

Each csproject has its own `obj/Release/net9.0-android/api.xml` file. You must identify the correct one for the error you're fixing based on the file structure above.

E.g. for `Org.Apache.Commons.CommonsLang3`, the api.xml file is located at: `src/android/org.apache.commons/commons-lang3/binding/obj/Release/net9.0-android/api.xml`

NOTE: 
- Target framework may vary (e.g. `net8.0-android` or `net9.0-android`, or other), so adjust accordingly.
- If project is built in Debug configuration, the path will be `obj/Debug/net9.0-android/api.xml`.
- If project is built in Release configuration, the path will be `obj/Release/net9.0-android/api.xml`.
- If project supports multiple target frameworks, you may have multiple folders under `obj/Release` (e.g. `net8.0-android`, `net9.0-android`), so inspect the correct single target framework folder is OK.

3) Inspect the XML around each match

Given that we have this error:

```
obj\Release\net8.0-android\api.xml(13242,8): error BG8401: Skipping 'Org.Apache.Commons.Lang3.Tuple.MutableTriple.Left' due to a duplicate field or property name. (Java type: 'org.apache.commons.lang3.tuple.MutableTriple')
```

- Search the file for the Java type (case-insensitive): the fully-qualified nested type string or just the nested simple name `MutableTriple`.
- Look for field nodes matching the field mentioned in the error (e.g. `Left`):

Examples (not exact schema — inspect your file):

```xml
<class name="MutableTriple">
	<field name="left" type="..."/>
</class>
```

Take all the names of the matching field nodes for the next steps.

If no field node is found, STOP HERE and ask for help.

4) Amend `Metadata.xml` within artifact folder only to avoid the conflict

For each field that needs renaming, add an `<attr>` entry that 
- targets the field by XPath: `//field[@name='FIELD_NAME']` <-- use the exact name from the XML
- and sets the `managedName` by suffixing an underscore (`_`) to the original name.

Example fix:
```xml
<attr path="//field[@name='left']" name="managedName">left_</attr>
<attr path="//field[@name='MAX_COUNT']" name="managedName">MAX_COUNT_</attr>
```

5) Re-run the binding and verify

Run the bind script again or rebuild the binding project. Confirm the BG8401 error no longer appears and the build completes.

Notes and troubleshooting
- BG8401 is emitted when the generator discovers two nested types with the same simple name in the same enclosing type. The skip is safe in many cases but you should ensure the omitted member isn't required at runtime.
- If edits to `api.xml` are reverted by the next full regenerate, add the permanent fix (metadata) instead.
- If you're unsure which node to remove, paste the XML fragment around both duplicates and ask for help—include both fragments and the exact error text.

Deliverable: a short, reproducible edit and verification steps that remove the BG8401 error for the specified Java type.

If you'd like, I can now:
- search the workspace for occurrences of `DialogComponentClickListeners` and open `obj/Release/net9.0-android/api.xml` to show the exact duplicate nodes, or
- prepare a recommended `Metadata.xml` patch to permanently hide/rename the duplicate.
Pick one and I'll proceed.


