using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Mp4parser.Muxer.Tracks.Encryption
{
    partial class CencDecryptingSampleList
    {
        public override unsafe global::Java.Lang.Object Get(int index) => (global::Java.Lang.Object)(object)GetX(index);
    }
    partial class CencEncryptingSampleList
    {
        public override unsafe global::Java.Lang.Object Get(int index) => (global::Java.Lang.Object)(object)GetX(index);
    }
}

namespace Org.Mp4parser.Muxer.Container.Mp4 {

    partial class DefaultMp4SampleList
    {
        public override unsafe global::Java.Lang.Object Get(int index) => (global::Java.Lang.Object)(object)GetX(index);
    }
    partial class FragmentedMp4SampleList
    {
        public override unsafe global::Java.Lang.Object Get(int index) => (global::Java.Lang.Object)(object)GetX(index);
    }
    partial class Mp4SampleList
    {
        public override unsafe global::Java.Lang.Object Get(int index) => (global::Java.Lang.Object)(object)GetX(index);
    }
}