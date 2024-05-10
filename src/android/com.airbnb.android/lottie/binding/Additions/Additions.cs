#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Airbnb.Lottie.Model.Animatable
{
    partial class AnimatablePathValue
    {
        global::System.Collections.IList? global::Com.Airbnb.Lottie.Model.Animatable.IAnimatableValue.Keyframes => Keyframes?.ToArray();
    }
    partial class AnimatableSplitDimensionPathValue
    {
        global::System.Collections.IList? global::Com.Airbnb.Lottie.Model.Animatable.IAnimatableValue.Keyframes => Keyframes?.ToArray();
    }
}