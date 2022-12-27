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
    [InlineData("Xamarin.Jetbrains.Annotations", "org.jetbrains", "annotations")] 
    [InlineData("Xamarin.Google.ZXing.Core", "com.google.zxing", "core")] 
    [InlineData("Xamarin.AndroidX.ViewPager", "androidx.viewpager", "viewpager")] 
    [InlineData("Xamarin.AndroidX.ViewPager2", "androidx.viewpager2", "viewpager2")] 
    [InlineData("Xamarin.AndroidX.Transition", "androidx.transition", "transition")] 
    [InlineData("Xamarin.AndroidX.SwipeRefreshLayout", "androidx.swiperefreshlayout", "swiperefreshlayout")] 
    [InlineData("Xamarin.AndroidX.Loader", "androidx.loader", "loader")] 
    [InlineData("Xamarin.AndroidX.ConstraintLayout", "androidx.constraintlayout", "constraintlayout")] 
    [InlineData("Xamarin.AndroidX.ConstraintLayout.Solver", "androidx.constraintlayout", "constraintlayout-solver")] 
    [InlineData("Xamarin.AndroidX.AppCompat.AppCompatResources", "androidx.appcompat", "appcompat-resources")] 
    [InlineData("Xamarin.AndroidX.ResourceInspection.Annotation", "androidx.resourceinspection", "resourceinspection-annotation")] 
    [InlineData("Xamarin.AndroidX.VectorDrawable.Animated", "androidx.vectordrawable", "vectordrawable-animated")] 
    [InlineData("Xamarin.AndroidX.VectorDrawable", "androidx.vectordrawable", "vectordrawable")] 
    [InlineData("Xamarin.AndroidX.Emoji2", "androidx.emoji2", "emoji2")] 
    [InlineData("Xamarin.AndroidX.Emoji2.ViewsHelper", "androidx.emoji2", "emoji2-views-helper")]
    [InlineData("Xamarin.AndroidX.Collection", "androidx.collection", "collection")]
    [InlineData("Xamarin.AndroidX.Collection.Ktx", "androidx.collection", "collection-ktx")] 
    [InlineData("Xamarin.AndroidX.Activity", "androidx.activity", "activity")]
    [InlineData("Xamarin.AndroidX.Activity.Ktx", "androidx.activity", "activity-ktx")] 
    [InlineData("Xamarin.AndroidX.Annotation", "androidx.annotation", "annotation")]
    [InlineData("Xamarin.AndroidX.Annotation.Experimental", "androidx.annotation", "annotation-experimental")] 
    [InlineData("Xamarin.AndroidX.AppCompat", "androidx.appcompat", "appcompat")]
    [InlineData("Xamarin.AndroidX.Arch.Core.Common", "androidx.arch.core", "core-common")]
    [InlineData("Xamarin.AndroidX.Arch.Core.Runtime", "androidx.arch.core", "core-runtime")]
    [InlineData("Xamarin.AndroidX.Browser", "androidx.browser", "browser")]
    [InlineData("Xamarin.AndroidX.Core", "androidx.core", "core")]
    [InlineData("Xamarin.AndroidX.Core.Core.Ktx", "androidx.core", "core-ktx")]
    [InlineData("Xamarin.AndroidX.DrawerLayout", "androidx.drawerlayout", "drawerlayout")]
    [InlineData("Xamarin.AndroidX.Fragment", "androidx.fragment", "fragment")]
    [InlineData("Xamarin.AndroidX.Fragment.Ktx", "androidx.fragment", "fragment-ktx")]
    [InlineData("Xamarin.AndroidX.Interpolator", "androidx.interpolator", "interpolator")]
    [InlineData("Xamarin.AndroidX.Lifecycle.Common", "androidx.lifecycle", "lifecycle-common")]
    [InlineData("Xamarin.AndroidX.Lifecycle.Common.Java8", "androidx.lifecycle", "lifecycle-common-java8")]
    [InlineData("Xamarin.AndroidX.Lifecycle.Runtime", "androidx.lifecycle", "lifecycle-runtime")]
    [InlineData("Xamarin.AndroidX.Lifecycle.Runtime.Ktx", "androidx.lifecycle", "lifecycle-runtime-ktx")]
    [InlineData("Xamarin.AndroidX.Lifecycle.ViewModel", "androidx.lifecycle", "lifecycle-viewmodel")]
    [InlineData("Xamarin.AndroidX.Lifecycle.ViewModel.Ktx", "androidx.lifecycle", "lifecycle-viewmodel-ktx")]
    [InlineData("Xamarin.AndroidX.Lifecycle.ViewModelSavedState", "androidx.lifecycle", "lifecycle-viewmodel-savedstate")]
    [InlineData("Xamarin.AndroidX.Lifecycle.LiveData", "androidx.lifecycle", "lifecycle-livedata")]
    [InlineData("Xamarin.AndroidX.Lifecycle.LiveData.Core", "androidx.lifecycle", "lifecycle-livedata-core")]
    [InlineData("Xamarin.AndroidX.Lifecycle.LiveData.Core.Ktx", "androidx.lifecycle", "lifecycle-livedata-core-ktx")]
    [InlineData("Xamarin.AndroidX.ResourceInspection.Annotation", "androidx.lifecycle", "resourceinspection-annotation")]
    [InlineData("Xamarin.AndroidX.Lifecycle.Process", "androidx.lifecycle", "lifecycle-process")]
    [InlineData("Xamarin.AndroidX.RecyclerView", "androidx.recyclerview", "recyclerview")]
    [InlineData("Xamarin.AndroidX.Room.Runtime", "androidx.room", "room-runtime")]
    [InlineData("Xamarin.AndroidX.SavedState", "androidx.savedstate", "savedstate")]
    [InlineData("Xamarin.AndroidX.SavedState.SavedState.Ktx", "androidx.savedstate", "savedstate-ktx")]
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
    [InlineData("Xamarin.Kotlin.Android.Extensions.Runtime", "org.jetbrains.kotlin", "kotlin-android-extensions-runtime")]
    [InlineData("Xamarin.Android.JetBrains.Kotlin_Parcelize_Runtime", "org.jetbrains.kotlin", "kotlin-android-extensions-runtime")]
    [InlineData("Xamarin.KotlinX.Coroutines.Android", "org.jetbrains.kotlinx", "kotlinx-coroutines-android")]
    [InlineData("Xamarin.KotlinX.Coroutines.Core", "org.jetbrains.kotlinx", "kotlinx-coroutines-core")]
    public Task Fetch_Android(string nugetId, string groupId, string artifactId)
    {
        return Fetcher.FetchAsync(nugetId, groupId, artifactId, "android", (packageId, error) =>
        {
            Console.WriteLine($"{packageId} >> {error}");
        });
    }
}