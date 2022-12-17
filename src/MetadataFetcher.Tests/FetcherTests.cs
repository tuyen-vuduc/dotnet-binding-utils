namespace MetadataFetcher.Tests;

public class FetcherTests
{
    static FetcherTests()
    {
        Fetcher.BasePath = Path.Combine(
            Environment.CurrentDirectory,
            "../../../../.."
        );
    }

    [Theory]
    [InlineData("Xamarin.AndroidX.Activity", "androidx.activity", "activity")]
    [InlineData("Xamarin.AndroidX.Annotation", "androidx.annotation", "annotation")]
    [InlineData("Xamarin.AndroidX.AppCompat", "androidx.appcompat", "appcompat")]
    [InlineData("Xamarin.AndroidX.Arch.Core.Common", "androidx.arch.core", "core-common")]
    [InlineData("Xamarin.AndroidX.Arch.Core.Runtime", "androidx.arch.core", "core-runtime")]
    [InlineData("Xamarin.AndroidX.Browser", "androidx.browser", "browser")]
    [InlineData("Xamarin.AndroidX.Core", "androidx.core", "core")]
    [InlineData("Xamarin.AndroidX.Core.Core.Ktx", "androidx.core", "core-ktx")]
    [InlineData("Xamarin.AndroidX.DrawerLayout", "androidx.drawerlayout", "drawerlayout")]
    [InlineData("Xamarin.AndroidX.Fragment", "androidx.fragment", "fragment")]
    [InlineData("Xamarin.AndroidX.Interpolator", "androidx.interpolator", "interpolator")]
    [InlineData("Xamarin.AndroidX.Lifecycle.Common", "androidx.lifecycle", "lifecycle-common")]
    [InlineData("Xamarin.AndroidX.Lifecycle.Runtime", "androidx.lifecycle", "lifecycle-runtime")]
    [InlineData("Xamarin.AndroidX.Lifecycle.Viewmodel", "androidx.lifecycle", "lifecycle-viewmodel")]
    [InlineData("Xamarin.AndroidX.RecyclerView", "androidx.recyclerview", "recyclerview")]
    [InlineData("Xamarin.AndroidX.Room.Runtime", "androidx.room", "room-runtime")]
    [InlineData("Xamarin.AndroidX.SavedState", "androidx.savedstate", "savedstate")]
    [InlineData("Xamarin.AndroidX.Security.SecurityCrypto", "androidx.security", "security-crypto")]
    [InlineData("Xamarin.AndroidX.Startup.StartupRuntime", "androidx.startup", "startup-runtime")]
    [InlineData("Xamarin.AndroidX.Tracing.Tracing", "androidx.tracing", "tracing")]
    [InlineData("Xamarin.Google.Android.Material", "com.google.android.material", "material")]
    [InlineData("GoogleGson", "com.google.code.gson", "gson")]
    [InlineData("Square.OkHttp3", "com.squareup.okhttp3", "okhttp")]
    [InlineData("Xamarin.Kotlin.StdLib", "org.jetbrains.kotlin", "kotlin-stdlib")]
    [InlineData("Xamarin.Kotlin.StdLib.Common", "org.jetbrains.kotlin", "kotlin-stdlib-common")]
    [InlineData("Xamarin.Kotlin.StdLib.Jdk7", "org.jetbrains.kotlin", "kotlin-stdlib-jdk7")]
    [InlineData("Xamarin.Kotlin.StdLib.Jdk8", "org.jetbrains.kotlin", "kotlin-stdlib-jdk8")]
    public Task Fetch_Android(string nugetId, string groupId, string artifactId)
    {
        return Fetcher.FetchAsync(nugetId, groupId, artifactId, "android", (packageId, error) =>
        {
            Console.WriteLine($"{packageId} >> {error}");
        });
    }
}