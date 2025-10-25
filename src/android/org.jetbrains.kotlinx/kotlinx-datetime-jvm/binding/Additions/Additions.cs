using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KotlinX.Datetime
{
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
    partial class Instant : global::Java.Lang.IComparable
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
            => CompareTo(o as Instant);
    }
}