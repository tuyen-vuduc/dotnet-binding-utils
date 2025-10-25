# Fix CS0535 — generated binding class missing interface member implementation

This prompt explains how to locate and fix C# compile error CS0535 produced by the Xamarin.Android binding generator when a generated C# type does not implement an interface member that the generated code expects to exist. Example error we want to fix:

```
obj\Release\net8.0-android\generated\src\Kotlinx.Serialization.Json.Internal.PolymorphismValidator.cs(21,80): error CS0535: 'PolymorphismValidator' does not implement interface member 'ISerializersModuleCollector.PolymorphicDefaultSerializer(IKClass, IFunction1)'
```

Goal: make a small, safe change so the generated binding either implements the required interface member (preferred), or the generator maps/renames the existing member to match the interface contract by adding a `Additions/Additions.cs` patch in the artifact folder. DO AS SPECIFIED. DON'T DEVIATE. STOP IF UNSURE.

Execution contract (must be followed exactly)

- Scope: Only perform actions explicitly requested by the user. If there is a reference to an external guidance, follow that guidance. If there is any uncertainty, stop and ask for clarification.
- Metadata-first policy: Always prefer adding or changing entries in `Additions/Additions.cs` in the artifact folder to correct the generated managed name or signature. Editing generated C# (`obj/.../generated/src/...`) is only allowed for diagnostics with explicit approval and must be reverted after confirming the permanent fix (metadata) works.
- Approval workflow: For any edit, present (a) the C# fragment causing CS0535, (b) the Additions.cs patch as a unified diff, and (c) apply changes except if you change files other than `Additions/Additions.cs`.
- Reporting: After applying a change, provide a 4-line report: what change, why, files edited, and verification results (CS0535 cleared or new errors).
- Code searching: Only searching for code within (`obj/.../generated/src/...`) and `Additions/Additions.cs` in the artifact folder is allowed. Do not search or reference any other files, including `Metadata.xml` or `api.xml`, unless explicitly requested by the user. If you can decompile the base C# class, then it'll be allowed to search that decompiled code.

Why this happens

1) Kotlin/Java function-type or synthetic signatures sometimes map to C# names that don't match the interface method expected by the generator. For example, a Java/Kotlin method named `polymorphicDefaultSerializer` may be emitted with a managed name that doesn't match `PolymorphicDefaultSerializer` or has a different parameter mapping (function types map to `IFunction1` / `IFunction2` wrappers).
2) Overloaded or mangled names, default-constructor marker parameters, or missing method stubs can produce a class that does not appear to implement the required interface method in C# (compile-time CS0535).

File structure

```
|-- src
    |-- android
        |-- {ARTIFACT_GROUP}
            |-- {ARTIFACT_NAME}
                |-- binding
                    |-- {ARTIFACT_GROUP}.{ARTIFACT_NAME}.csproj
                    |-- obj
                        |-- Release
                            |-- net9.0-android <--- or net8.0-android, check your target
                                |-- generated
                                    |-- src
                                        |-- Kotlinx.Serialization.Json.Internal.PolymorphismValidator.cs  <--- Inspect this file
                    |-- Transforms
                        |-- Metadata.xml
                    |-- Additions
                        |-- Additions.cs  <--- Edit this file to fix CS0535 (preferred)
                |-- nuget.json
                |-- {ARTIFACT_VERSION}.json 
```

Steps to Follow

1) Reproduce the error

Run your usual binding/build command to reproduce the CS0535. Example:

```bash
sh bind.sh --artifact org.jetbrains.kotlinx:kotlinx-serialization-json:1.3.1
```

2) Group the errors by csproj file

Group compiler errors by project so you know which binding project and which `Additions/Additions.cs` to edit. The build log groups errors under the project name.

3) Locate the generated C# file and the offending type

Open the generated file listed in the error (for example):

```
src/android/org.jetbrains.kotlinx/kotlinx-serialization-json-jvm/binding/obj/Release/net8.0-android/generated/src/KotlinX.Serialization.Json.Internal.PolymorphismValidator.cs
```

Inspect the `PolymorphismValidator` class and its implemented interfaces. Look for a method that should correspond to the interface member (for example a method whose Java name is `polymorphicDefaultSerializer` or similar). Note the exact managed method name and parameter types the generated file exposes.

If you cannot find any method of the exact name, stop and paste the relevant class fragment (or the `api.xml` fragment) and ask for help.

4) Prefer a Additions.cs fix

For most cases, you should fix the mapping in `Additions/Additions.cs` file so the generated C# will contain a method whose managed name/signature matches the interface member.

Steps to create the patch:
- Check if there is a method with an exact name but different parameter types or return type.
- A: If so,
    - Add the partial class for the targeted one in `Additions/Additions.cs`
    - Add an explicit interface implementation in `Additions/Additions.cs` that delegates to the exactly matching method.
- B: If not,
    - Add a new method in `Additions/Additions.cs` that implements the required interface member using the binding ways to call into Java/Kotlin.

Example Additions.cs patch for Approach A:

```csharp
namespace KotlinX.Serialization.Json.Internal {
    partial class PolymorphismValidator : global::KotlinX.Serialization.Serialization.ISerializersModuleCollector {
        // Implement the missing interface member by delegating to the existing method
        void global::KotlinX.Serialization.Serialization.ISerializersModuleCollector.PolymorphicDefaultSerializer(global::Kotlin.Reflect.IKClass baseClass, global::Kotlin.Jvm.Functions.IFunction1 defaultSerializerProvider) {
            this.PolymorphicDefaultSerializer(baseClass, defaultSerializerProvider);
        }
    }
}
```

Example Additions.cs patch for Approach B:

```csharp
namespace KotlinX.Serialization.Json.Internal {
    partial class PolymorphismValidator : global::KotlinX.Serialization.Serialization.ISerializersModuleCollector {
        // Metadata.xml XPath method reference: path="/api/package[@name='kotlinx.serialization.json.internal']/class[@name='PolymorphismValidator']/method[@name='polymorphicDefaultSerializer' and count(parameter)=2 and parameter[1][@type='kotlin.reflect.KClass&lt;Base&gt;'] and parameter[2][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, ? extends kotlinx.serialization.DeserializationStrategy&lt;? extends Base&gt;&gt;']]"
		[Register ("polymorphicDefaultSerializer", "(Lkotlin/reflect/KClass;Lkotlin/jvm/functions/Function1;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Base"})]
		public unsafe void PolymorphicDefaultSerializer (global::Kotlin.Reflect.IKClass baseClass, global::Kotlin.Jvm.Functions.IFunction1 defaultSerializerProvider)
		{
			const string __id = "polymorphicDefaultSerializer.(Lkotlin/reflect/KClass;Lkotlin/jvm/functions/Function1;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((baseClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseClass).Handle);
				__args [1] = new JniArgumentValue ((defaultSerializerProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultSerializerProvider).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (baseClass);
				global::System.GC.KeepAlive (defaultSerializerProvider);
			}
		}
    }
}
```

5) Re-run the binding and verify

Re-run your binding/build and confirm CS0535 no longer appears and compilation succeeds.

