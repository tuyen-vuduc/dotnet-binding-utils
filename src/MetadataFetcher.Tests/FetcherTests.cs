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
    [InlineData("Xamarin.GooglePlayServices.InstantApps", "com.google.android.instantapps", "instantapps")]
    [InlineData("Xamarin.Google.Accompanist.FlowLayout", "com.google.accompanist", "accompanist-flowlayout")]
    [InlineData("Xamarin.Google.Accompanist.SystemUIController", "com.google.accompanist", "accompanist-systemuicontroller")]
    [InlineData("Xamarin.AndroidX.Navigation.Common", "androidx.navigation", "navigation-common")]
    [InlineData("Xamarin.AndroidX.Navigation.Common.Ktx", "androidx.navigation", "navigation-common-ktx")]
    [InlineData("Xamarin.AndroidX.Navigation.Compose", "androidx.navigation", "navigation-compose")]
    [InlineData("Xamarin.AndroidX.Navigation.Runtime", "androidx.navigation", "navigation-runtime")]
    [InlineData("Xamarin.AndroidX.Navigation.Runtime.Ktx", "androidx.navigation", "navigation-runtime-ktx")]
    [InlineData("Xamarin.AndroidX.Lifecycle.LiveData.Ktx", "androidx.lifecycle", "lifecycle-livedata-ktx")]
    [InlineData("Xamarin.AndroidX.Lifecycle.ViewModel.Compose", "androidx.lifecycle", "lifecycle-viewmodel-compose")]
    [InlineData("Xamarin.AndroidX.Compose.Runtime", "androidx.compose.runtime", "runtime")]
    [InlineData("Xamarin.AndroidX.Compose.Runtime.LiveData", "androidx.compose.runtime", "runtime-livedata")]
    [InlineData("Xamarin.AndroidX.Compose.Runtime.Saveable", "androidx.compose.runtime", "runtime-saveable")]
    [InlineData("Xamarin.AndroidX.Compose.Material", "androidx.compose.material", "material")]
    [InlineData("Xamarin.AndroidX.Compose.Material.Icons.Core", "androidx.compose.material", "material-icons-core")]
    [InlineData("Xamarin.AndroidX.Compose.Material.Ripple", "androidx.compose.material", "material-ripple")]
    [InlineData("Xamarin.AndroidX.Compose.Foundation", "androidx.compose.foundation", "foundation")]
    [InlineData("Xamarin.AndroidX.Compose.Foundation.Layout", "androidx.compose.foundation", "foundation-layout")]
    [InlineData("Xamarin.AndroidX.Compose.Animation", "androidx.compose.animation", "animation")]
    [InlineData("Xamarin.AndroidX.Compose.Animation.Core", "androidx.compose.animation", "animation-core")]
    [InlineData("Xamarin.AndroidX.Compose.Animation.Graphics", "androidx.compose.animation", "animation-graphics")]
    [InlineData("Xamarin.AndroidX.Compose.UI.Geometry", "androidx.compose.ui", "ui-geometry")]
    [InlineData("Xamarin.AndroidX.Compose.UI.Tooling.Preview", "androidx.compose.ui", "ui-tooling-preview")]
    [InlineData("Xamarin.AndroidX.Compose.UI.ViewBinding", "androidx.compose.ui", "ui-viewbinding")]
    [InlineData("Xamarin.AndroidX.Autofill", "androidx.autofill", "autofill")]
    [InlineData("Xamarin.AndroidX.Activity.Compose", "androidx.activity", "activity-compose")]
    [InlineData("Xamarin.AndroidX.Compose.UI.Util", "androidx.compose.ui", "ui-util")]
    [InlineData("Xamarin.AndroidX.Compose.UI.Unit", "androidx.compose.ui", "ui-unit")]
    [InlineData("Xamarin.AndroidX.Compose.UI.Graphics", "androidx.compose.ui", "ui-graphics")]
    [InlineData("Xamarin.AndroidX.Compose.UI.Text", "androidx.compose.ui", "ui-text")]
    [InlineData("Xamarin.KotlinX.Coroutines.Guava", "org.jetbrains.kotlinx", "kotlinx-coroutines-guava")]
    [InlineData("Xamarin.JavaX.Inject", "javax.inject", "javax.inject")]
    [InlineData("Xamarin.Android.ReactiveStreams", "org.reactivestreams", "reactive-streams")]
    [InlineData("Xamarin.Android.ReactiveX.RxAndroid", "io.reactivex.rxjava2", "rxandroid")]
    [InlineData("Xamarin.Android.ReactiveX.RxJava", "io.reactivex.rxjava2", "rxjava")]
    [InlineData("Square.Retrofit2.ConverterGson", "com.squareup.retrofit2", "converter-gson")]
    [InlineData("Square.Retrofit2.AdapterRxJava2", "com.squareup.retrofit2", "adapter-rxjava2")]
    [InlineData("Square.Retrofit2", "com.squareup.retrofit2", "retrofit")]
    [InlineData("Xamarin.Google.MLKit.BarcodeScanning", "com.google.mlkit", "barcode-scanning")]
    [InlineData("Xamarin.Google.MLKit.BarcodeScanning.Common", "com.google.mlkit", "barcode-scanning-common")]
    [InlineData("Xamarin.Google.MLKit.Common", "com.google.mlkit", "common")]
    [InlineData("Xamarin.Google.MLKit.FaceDetection", "com.google.mlkit", "face-detection")]
    [InlineData("Xamarin.Google.MLKit.Vision.Common", "com.google.mlkit", "vision-common")]
    [InlineData("Xamarin.Google.MLKit.Vision.Interfaces", "com.google.mlkit", "vision-interfaces")]
    [InlineData("Xamarin.Google.Guava.FailureAccess", "com.google.guava", "failureaccess")]
    [InlineData("Xamarin.Google.Guava", "com.google.guava", "guava")]
    [InlineData("Xamarin.Google.Guava.ListenableFuture", "com.google.guava", "listenablefuture")]
    [InlineData("Xamarin.Firebase.Annotations", "com.google.firebase", "firebase-annotations")]
    [InlineData("Xamarin.Firebase.Components", "com.google.firebase", "firebase-components")]
    [InlineData("Xamarin.Firebase.Encoders", "com.google.firebase", "firebase-encoders")]
    [InlineData("Xamarin.Firebase.Encoders.JSON", "com.google.firebase", "firebase-encoders-json")]
    [InlineData("Xamarin.Google.Android.ODML.Image", "com.google.android.odml", "image")]
    [InlineData("Xamarin.Google.AutoValue.Annotations", "com.google.auto.value", "auto-value-annotations")]
    [InlineData("Xamarin.Google.Dagger", "com.google.dagger", "dagger")]
    [InlineData("Xam.Plugins.Android.ExoPlayer.Core", "com.google.android.exoplayer", "exoplayer-core")]
    [InlineData("Xam.Plugins.Android.ExoPlayer.Dash", "com.google.android.exoplayer", "exoplayer-dash")]
    [InlineData("Xam.Plugins.Android.ExoPlayer.Hls", "com.google.android.exoplayer", "exoplayer-hls")]
    [InlineData("Xam.Plugins.Android.ExoPlayer.SmoothStreaming", "com.google.android.exoplayer", "exoplayer-smoothstreaming")]
    [InlineData("Xamarin.Google.Android.DataTransport.TransportApi", "com.google.android.datatransport", "transport-api")]
    [InlineData("Xamarin.Google.Android.DataTransport.TransportBackendCct", "com.google.android.datatransport", "transport-backend-cct")]
    [InlineData("Xamarin.Google.Android.DataTransport.TransportRuntime", "com.google.android.datatransport", "transport-runtime")]
    [InlineData("Xamarin.Android.Glide.Annotations", "com.github.bumptech.glide", "annotations")]
    [InlineData("Xamarin.Android.Glide.DiskLruCache", "com.github.bumptech.glide", "disklrucache")]
    [InlineData("Xamarin.Android.Glide.GifDecoder", "com.github.bumptech.glide", "gifdecoder")]
    [InlineData("Xamarin.Android.Glide", "com.github.bumptech.glide", "glide")]
    [InlineData("Xamarin.ReLinker", "com.getkeepsafe.relinker", "relinker")]
    [InlineData("xamarin.android.facebook.conceal", "com.facebook.conceal", "conceal")]
    [InlineData("Xamarin.Amplitude.Android", "com.amplitude", "android-sdk")]
    [InlineData("Xamarin.AndroidX.SlidingPaneLayout", "androidx.slidingpanelayout", "slidingpanelayout")]
    [InlineData("Xamarin.AndroidX.Print", "androidx.print", "print")]
    [InlineData("Xamarin.CheckerFramework.CheckerQual", "org.checkerframework", "checker-qual")]
    [InlineData("Xamarin.CheckerFramework.CheckerCompatQual", "org.checkerframework", "checker-compat-qual")]
    [InlineData("iProov.Android", "com.iproov.sdk", "iproov")]
    [InlineData("PSPDFKit.Android", "com.pspdfkit", "pspdfkit")]
    [InlineData("Xamarin.AndroidX.LocalBroadcastManager", "androidx.localbroadcastmanager", "localbroadcastmanager")]
    [InlineData("Xamarin.Kotlin.Reflect", "com.squareup.okio", "kotlin-reflect")]
    [InlineData("Square.OkIO", "com.squareup.okio", "okio")]
    [InlineData("Square.Moshi", "com.squareup.moshi", "moshi")]
    [InlineData("Square.Moshi.Kotlin", "com.squareup.moshi", "moshi-kotlin")]
    [InlineData("Square.Moshi.Adapters", "com.squareup.moshi", "moshi-adapters")]
    [InlineData("Xamarin.KotlinX.Coroutines.Core.Jvm", "org.jetbrains.kotlinx", "kotlinx-coroutines-core-jvm")] 
    [InlineData("Xamarin.Android.Support.Animated.Vector.Drawable", "com.android.support", "animated-vector-drawable")] 
    [InlineData("Xamarin.Android.Support.v7.AppCompat", "com.android.support", "appcompat-v7")] 
    [InlineData("Xamarin.Android.Support.Annotations", "com.android.support", "support-annotations")] 
    [InlineData("Xamarin.Android.Support.Compat", "com.android.support", "support-compat")] 
    [InlineData("Xamarin.Android.Support.Core.UI", "com.android.support", "support-core-ui")] 
    [InlineData("Xamarin.Android.Support.Core.Utils", "com.android.support", "support-core-utils")] 
    [InlineData("Xamarin.Android.Support.Fragment", "com.android.support", "support-fragment")] 
    [InlineData("Xamarin.Android.Support.Media.Compat", "com.android.support", "support-media-compat")] 
    [InlineData("Xamarin.Android.Support.V4", "com.android.support", "support-v4")] 
    [InlineData("Xamarin.Android.Support.Vector.Drawable", "com.android.support", "support-vector-drawable")] 
    [InlineData("Xamarin.AndroidX.Preference", "androidx.preference", "preference")] 
    [InlineData("Xamarin.AndroidX.Preference.Preference.Ktx", "androidx.preference", "preference-ktx")] 
    [InlineData("Xamarin.AndroidX.Palette", "androidx.palette", "palette")] 
    [InlineData("Xamarin.AndroidX.Palette.Palette.Ktx", "androidx.palette", "palette-ktx")] 
    [InlineData("Xamarin.AndroidX.Legacy.Support.Core.UI", "androidx.legacy", "legacy-support-core-ui")] 
    [InlineData("Xamarin.AndroidX.Legacy.Support.Core.Utils", "androidx.legacy", "legacy-support-core-utils")] 
    [InlineData("Xamarin.AndroidX.Legacy.Support.V4", "androidx.legacy", "legacy-support-v4")] 
    [InlineData("Xamarin.AndroidX.Media", "androidx.media", "media")] 
    [InlineData("Xamarin.AndroidX.MultiDex", "androidx.multidex", "multidex")] 
    [InlineData("Xamarin.AndroidX.DocumentFile", "androidx.documentfile", "documentfile")] 
    [InlineData("Xamarin.AndroidX.ExifInterface", "androidx.exifinterface", "exifinterface")] 
    [InlineData("Xamarin.AndroidX.GridLayout", "androidx.gridlayout", "gridlayout")] 
    [InlineData("Xamarin.AndroidX.DataBinding.DataBindingAdapters", "androidx.databinding", "databinding-adapters")] 
    [InlineData("Xamarin.AndroidX.DataBinding.DataBindingCommon", "androidx.databinding", "databinding-common")] 
    [InlineData("Xamarin.AndroidX.DataBinding.DataBindingRuntime", "androidx.databinding", "databinding-runtime")] 
    [InlineData("Xamarin.AndroidX.DataBinding.ViewBinding", "androidx.databinding", "viewbinding")] 
    [InlineData("Xamarin.AndroidX.CoordinatorLayout", "androidx.coordinatorlayout", "coordinatorlayout")] 
    [InlineData("Xamarin.AndroidX.Concurrent.Futures", "androidx.concurrent", "concurrent-futures")] 
    [InlineData("Xamarin.AndroidX.Compose.Runtime", "androidx.compose.runtime", "runtime")] 
    [InlineData("Xamarin.AndroidX.Compose.UI", "androidx.compose.ui", "ui")] 
    [InlineData("Xamarin.AndroidX.Compose.Runtime.RxJava2", "androidx.compose.runtime", "runtime-rxjava2")] 
    [InlineData("Xamarin.AndroidX.Camera.Core", "androidx.camera", "camera-core")] 
    [InlineData("Xamarin.AndroidX.Camera.Camera2", "androidx.camera", "camera-camera2")] 
    [InlineData("Xamarin.AndroidX.Camera.LifeCycle", "androidx.camera", "camera-lifecycle")] 
    [InlineData("Xamarin.AndroidX.Camera.View", "androidx.camera", "camera-view")] 
    [InlineData("Xamarin.AndroidX.AsyncLayoutInflater", "androidx.asynclayoutinflater", "asynclayoutinflater")] 
    [InlineData("Xamarin.Android.Arch.Lifecycle.Common", "android.arch.lifecycle", "common")] 
    [InlineData("Xamarin.Android.Arch.Lifecycle.Runtime", "android.arch.lifecycle", "runtime")] 
    [InlineData("Xamarin.Android.Arch.Lifecycle.LiveData.Core", "android.arch.lifecycle", "livedata-core")] 
    [InlineData("Xamarin.Android.Arch.Lifecycle.ViewModel", "android.arch.lifecycle", "viewmodel")] 
    [InlineData("Xamarin.AndroidX.Arch.Core.Common", "android.arch.core", "common")] 
    [InlineData("Xamarin.GooglePlayServices.Location", "com.google.android.gms", "play-services-location")] 
    [InlineData("Xamarin.GooglePlayServices.Base", "com.google.android.gms", "play-services-base")] 
    [InlineData("Xamarin.GooglePlayServices.Basement", "com.google.android.gms", "play-services-basement")] 
    [InlineData("Xamarin.GooglePlayServices.Identity", "com.google.android.gms", "play-services-identity")] 
    [InlineData("Xamarin.GooglePlayServices.Maps", "com.google.android.gms", "play-services-maps")] 
    [InlineData("Xamarin.GooglePlayServices.Tasks", "com.google.android.gms", "play-services-tasks")] 
    [InlineData("Xamarin.GooglePlayServices.Wallet", "com.google.android.gms", "play-services-wallet")] 
    [InlineData("Xamarin.GooglePlayServices.ClearCut", "com.google.android.gms", "play-services-clearcut")] 
    [InlineData("Xamarin.GooglePlayServices.Flags", "com.google.android.gms", "play-services-flags")] 
    [InlineData("Xamarin.GooglePlayServices.MLKit.BarcodeScanning", "com.google.android.gms", "play-services-mlkit-barcode-scanning")] 
    [InlineData("Xamarin.GooglePlayServices.MLKit.FaceDetection", "com.google.android.gms", "play-services-mlkit-face-detection")] 
    [InlineData("Xamarin.GooglePlayServices.Phenotype", "com.google.android.gms", "play-services-phenotype")] 
    [InlineData("Xamarin.GooglePlayServices.Vision", "com.google.android.gms", "play-services-vision")] 
    [InlineData("Xamarin.GooglePlayServices.Vision.Common", "com.google.android.gms", "play-services-vision-common")] 
    [InlineData("Xamarin.Android.Google.Android.Flexbox", "com.google.android.flexbox", "flexbox")] 
    [InlineData("Xamarin.AndroidX.CardView", "androidx.cardview", "cardview")] 
    [InlineData("Org.Jfrog.Cardinalcommerce.Gradle.Cardinalmobilesdk", "org.jfrog.cardinalcommerce.gradle", "cardinalmobilesdk")]
    [InlineData("Xamarin.AndroidX.CursorAdapter", "androidx.cursoradapter", "cursoradapter")] 
    [InlineData("Xamarin.AndroidX.Work.Runtime", "androidx.work", "work-runtime")] 
    [InlineData("Xamarin.AndroidX.Work.Work.Runtime.Ktx", "androidx.work", "work-runtime-ktx")] 
    [InlineData("Xamarin.AndroidX.CustomView", "androidx.customview", "customview")] 
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
    [InlineData("Square.OkHttp3.LoggingInterceptor", "com.squareup.okhttp3", "logging-interceptor")]
    [InlineData("Xamarin.Kotlin.StdLib", "org.jetbrains.kotlin", "kotlin-stdlib")]
    [InlineData("Xamarin.Kotlin.StdLib.Common", "org.jetbrains.kotlin", "kotlin-stdlib-common")]
    [InlineData("Xamarin.Kotlin.StdLib.Jdk7", "org.jetbrains.kotlin", "kotlin-stdlib-jdk7")]
    [InlineData("Xamarin.Kotlin.StdLib.Jdk8", "org.jetbrains.kotlin", "kotlin-stdlib-jdk8")]
    [InlineData("Xamarin.Kotlin.Android.Extensions.Runtime", "org.jetbrains.kotlin", "kotlin-android-extensions-runtime")]
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