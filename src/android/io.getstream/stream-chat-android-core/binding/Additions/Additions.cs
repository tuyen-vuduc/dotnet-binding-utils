#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Util;

namespace IO.Getstream.Chat.Android.Models
{
    partial class TimeDuration : global::Java.Lang.IComparable
    {
        int global::Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
            => CompareTo(o as TimeDuration);
    }

    partial class ReactionSortingBySumScore : global::IO.Getstream.Chat.Android.Models.IReactionSorting
    {
        int IComparator.Compare(Java.Lang.Object? o1, Java.Lang.Object? o2)
            => Compare(o1 as ReactionGroup, o2 as  ReactionGroup);
    }
    partial class ReactionSortingByLastReactionAt : global::IO.Getstream.Chat.Android.Models.IReactionSorting
    {
        int IComparator.Compare(Java.Lang.Object? o1, Java.Lang.Object? o2)
            => Compare(o1 as ReactionGroup, o2 as ReactionGroup);
    }
    partial class ReactionSortingByFirstReactionAt : global::IO.Getstream.Chat.Android.Models.IReactionSorting
    {
        int IComparator.Compare(Java.Lang.Object? o1, Java.Lang.Object? o2)
            => Compare(o1 as ReactionGroup, o2 as ReactionGroup);
    }
    partial class ReactionSortingByCount : global::IO.Getstream.Chat.Android.Models.IReactionSorting
    {
        int IComparator.Compare(Java.Lang.Object? o1, Java.Lang.Object? o2)
            => Compare(o1 as ReactionGroup, o2 as ReactionGroup);
    }
}