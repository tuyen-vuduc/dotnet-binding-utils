# Keep constant field names as it is

Java constants are usually all uppercase (e.g. `CREATOR`, `MAX_VALUE`) and are fields, but when generating C# bindings, they are generated as C# fields in PascalCase (e.g. `Creator`, `MaxValue`), it will lead to the confusion when reading Java/Kotlin docs to convert to C# code. The other case is that the constant fields are in uppercase, so they won't conflict with other members in Java, but when generating C# bindings, the managed name may conflicts, e.g. `CREATOR` field and `Creator` class will be generated with the same name in C#.

Goal: Keep the constant field names as it is in Java, i.e. all uppercase.

DO AS SPECIFIED. DON'T DEVIATE. STOP IF UNSURE.

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

2) Locate the generated api.xml

Open the file reported in the error. Example path relative to the project root:

```
obj/Release/net9.0-android/api.xml
```

3) Inspect the XML for all fields' names in upper case

You're looking for field nodes which have the names in upper case (e.g. `MAX_VALUE`):

Examples (not exact schema — inspect your file):

```xml
<class name="com.izettle.ui.components.modal.OttoDialogComponent.DialogComponentClickListeners">
	<field name="MAX_VALUE" type="..."/>
</class>
```

If no field node is found, STOP HERE and ask for help.

4) Amend `Metadata.xml` within artifact folder only

For each field found, add an entry in `Metadata.xml` to keep the field name as it is in Java, i.e. all uppercase.
- targets the field by XPath: `//field[@name='FIELD_NAME']`
- and sets the `managedName` to the original name.

Example fix:
```xml
<attr path="//field[@name='MAX_VALUE']" name="managedName">MAX_VALUE</attr>
```

NOTE: Skip attr for `CREATOR` field as it's defined in the common file already.

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


