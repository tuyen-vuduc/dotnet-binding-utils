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

namespace KotlinX.Datetime.Format
{
    partial class DateTimeComponentsFormat
    {
        public override Java.Lang.Object GetEmptyIntermediate() => GetEmptyIntermediate_();
        public override Java.Lang.Object IntermediateFromValue(Java.Lang.Object? p0) => IntermediateFromValue(p0 as global::KotlinX.Datetime.Format.DateTimeComponents);
        override public Java.Lang.Object ValueFromIntermediate(Java.Lang.Object p0) => ValueFromIntermediate(p0 as global::KotlinX.Datetime.Format.DateTimeComponentsContents);
    }
    partial class LocalDateFormat
    {
        public override Java.Lang.Object GetEmptyIntermediate() => GetEmptyIntermediate_();
        public override Java.Lang.Object IntermediateFromValue(Java.Lang.Object? p0) => IntermediateFromValue(p0 as global::KotlinX.Datetime.LocalDate);
        override public Java.Lang.Object ValueFromIntermediate(Java.Lang.Object p0) => ValueFromIntermediate(p0 as global::KotlinX.Datetime.Format.IncompleteLocalDate);
    }
    partial class LocalTimeFormat
    {
        public override Java.Lang.Object GetEmptyIntermediate() => GetEmptyIntermediate_();
        public override Java.Lang.Object IntermediateFromValue(Java.Lang.Object? p0) => IntermediateFromValue(p0 as global::KotlinX.Datetime.LocalTime);
        override public Java.Lang.Object ValueFromIntermediate(Java.Lang.Object p0) => ValueFromIntermediate(p0 as global::KotlinX.Datetime.Format.IncompleteLocalTime);
    }
    partial class LocalDateTimeFormat
    {
        public override Java.Lang.Object GetEmptyIntermediate() => GetEmptyIntermediate_();
        public override Java.Lang.Object IntermediateFromValue(Java.Lang.Object? p0) => IntermediateFromValue(p0 as global::KotlinX.Datetime.LocalDateTime);
        override public Java.Lang.Object ValueFromIntermediate(Java.Lang.Object p0) => ValueFromIntermediate(p0 as global::KotlinX.Datetime.Format.IncompleteLocalDateTime);
    }
    partial class UtcOffsetFormat
    {
        public override Java.Lang.Object GetEmptyIntermediate() => GetEmptyIntermediate_();
        public override Java.Lang.Object IntermediateFromValue(Java.Lang.Object? p0) => IntermediateFromValue(p0 as global::KotlinX.Datetime.UtcOffset);
        override public Java.Lang.Object ValueFromIntermediate(Java.Lang.Object p0) => ValueFromIntermediate(p0 as global::KotlinX.Datetime.Format.IncompleteUtcOffset);
    }
}