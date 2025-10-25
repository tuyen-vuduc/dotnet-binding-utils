using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KotlinX.Datetime
{
    partial class LocalDateRange
    {
        // Explicit interface implementations delegating to existing strongly-typed properties.
        global::Java.Lang.Object global::Kotlin.Ranges.IClosedRange.EndInclusive => EndInclusive;
        global::Java.Lang.Object global::Kotlin.Ranges.IClosedRange.Start => Start;
        global::Java.Lang.Object global::Kotlin.Ranges.IOpenEndRange.EndExclusive => EndExclusive;
        global::Java.Lang.Object global::Kotlin.Ranges.IOpenEndRange.Start => Start;
    }
    partial class LocalDateProgression
    {
        bool global::Java.Util.ICollection.Add(global::Java.Lang.Object obj)
            => Add(obj as global::KotlinX.Datetime.LocalDate);
        
        bool Java.Util.ICollection.AddAll(System.Collections.ICollection items)
            => AddAll(items.Cast<global::KotlinX.Datetime.LocalDate>().ToList());

        bool Java.Util.ICollection.ContainsAll(System.Collections.ICollection items)
            => ContainsAll(items.ToCollection());

        bool Java.Util.ICollection.RemoveAll(System.Collections.ICollection items)
            => RemoveAll(items.ToCollection());

        bool Java.Util.ICollection.RetainAll(System.Collections.ICollection items)
            => RetainAll(items.ToCollection());
        int Java.Util.ICollection.Size() => Size;
    }

    partial class YearMonthRange
    {
        // Explicit interface implementations delegating to existing strongly-typed properties.
        global::Java.Lang.Object global::Kotlin.Ranges.IClosedRange.EndInclusive => EndInclusive;
        global::Java.Lang.Object global::Kotlin.Ranges.IClosedRange.Start => Start;
        global::Java.Lang.Object global::Kotlin.Ranges.IOpenEndRange.EndExclusive => EndExclusive;
        global::Java.Lang.Object global::Kotlin.Ranges.IOpenEndRange.Start => Start;
    }
    partial class YearMonthProgression
    {
        bool global::Java.Util.ICollection.Add(global::Java.Lang.Object obj)
            => Add(obj as global::KotlinX.Datetime.YearMonth);

        bool Java.Util.ICollection.AddAll(System.Collections.ICollection items)
            => AddAll(items.Cast<global::KotlinX.Datetime.YearMonth>().ToList());

        bool Java.Util.ICollection.ContainsAll(System.Collections.ICollection items)
            => ContainsAll(items.ToCollection());

        bool Java.Util.ICollection.RemoveAll(System.Collections.ICollection items)
            => RemoveAll(items.ToCollection());

        bool Java.Util.ICollection.RetainAll(System.Collections.ICollection items)
            => RetainAll(items.ToCollection());
        int Java.Util.ICollection.Size() => Size;
    }
    partial class DateTimeUnit
    {
        partial class DayBased
        {
            public override global::KotlinX.Datetime.DateTimeUnit Times(int scalar) => Times_(scalar);
        }
        partial class MonthBased
        {
            public override global::KotlinX.Datetime.DateTimeUnit Times(int scalar) => Times_(scalar);
        }
        partial class TimeBased
        {
            public override global::KotlinX.Datetime.DateTimeUnit Times(int scalar) => Times_(scalar);
        }
    }

    partial class YearMonth : global::Java.Lang.IComparable
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
            => CompareTo(o as YearMonth);
    }

    partial class LocalTime : global::Java.Lang.IComparable
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
            => CompareTo(o as LocalTime);
    }
    partial class LocalDateTime : global::Java.Lang.IComparable
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
            => CompareTo(o as LocalDateTime);
    }
    partial class LocalDate : global::Java.Lang.IComparable
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
            => CompareTo(o as LocalDate);
    }
}

static class X
{
    public static System.Collections.Generic.ICollection<object> ToCollection(this System.Collections.ICollection collection)
    {
        return collection.Cast<object>().ToList();
    }
}