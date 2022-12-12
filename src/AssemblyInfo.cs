using System.Reflection;
using System.Runtime.CompilerServices;
using Android.App;

#if !NETCOREAPP
[assembly: Android.LinkerSafe]
#endif

[assembly: AssemblyMetadata ("IsTrimmable", "True")]

[assembly: Android.App.UsesLibrary("org.apache.http.legacy", Required=false)]