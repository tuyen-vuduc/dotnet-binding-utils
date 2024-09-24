using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Kotlinx.Datetime
{
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
namespace Kotlinx.Datetime.Internal
{
    partial class DecimalFraction : global::Java.Lang.IComparable
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
            => CompareTo(o as DecimalFraction);
    }
}
namespace Kotlinx.Datetime.Format
{
    partial class DateTimeComponentsFormat
    {
        protected override global::Kotlinx.Datetime.Internal.Format.CachedFormatStructure RawActualFormat => ActualFormat;

        protected override global::Java.Lang.Object RawEmptyIntermediate => EmptyIntermediate;

        public override global::Java.Lang.Object IntermediateFromValue(global::Java.Lang.Object? p0)
            => IntermediateFromValueX(p0 as global::Kotlinx.Datetime.Format.DateTimeComponents);

        public override global::Java.Lang.Object? ValueFromIntermediate(global::Java.Lang.Object p0)
            => ValueFromIntermediateX(p0 as global::Kotlinx.Datetime.Format.DateTimeComponentsContents);
    }
    partial class UtcOffsetFormat
    {
        protected override global::Kotlinx.Datetime.Internal.Format.CachedFormatStructure RawActualFormat => ActualFormat;

        protected override global::Java.Lang.Object RawEmptyIntermediate => EmptyIntermediate;

        public override global::Java.Lang.Object IntermediateFromValue(global::Java.Lang.Object? p0)
            => IntermediateFromValueX(p0 as global::Kotlinx.Datetime.UtcOffset);

        public override global::Java.Lang.Object? ValueFromIntermediate(global::Java.Lang.Object p0)
            => ValueFromIntermediateX(p0 as global::Kotlinx.Datetime.Format.IncompleteUtcOffset);
    }
    partial class LocalTimeFormat
    {
        protected override global::Kotlinx.Datetime.Internal.Format.CachedFormatStructure RawActualFormat => ActualFormat;

        protected override global::Java.Lang.Object RawEmptyIntermediate => EmptyIntermediate;

        public override global::Java.Lang.Object IntermediateFromValue(global::Java.Lang.Object? p0)
            => IntermediateFromValueX(p0 as global::Kotlinx.Datetime.LocalTime);

        public override global::Java.Lang.Object? ValueFromIntermediate(global::Java.Lang.Object p0)
            => ValueFromIntermediateX(p0 as global::Kotlinx.Datetime.Format.IncompleteLocalTime);
    }
    partial class LocalDateFormat
    {
        protected override global::Kotlinx.Datetime.Internal.Format.CachedFormatStructure RawActualFormat => ActualFormat;

        protected override global::Java.Lang.Object RawEmptyIntermediate => EmptyIntermediate;

        public override global::Java.Lang.Object IntermediateFromValue(global::Java.Lang.Object? p0)
            => IntermediateFromValueX(p0 as global::Kotlinx.Datetime.LocalDate);

        public override global::Java.Lang.Object? ValueFromIntermediate(global::Java.Lang.Object p0)
            => ValueFromIntermediateX(p0 as global::Kotlinx.Datetime.Format.IncompleteLocalDate);
    }
    partial class LocalDateTimeFormat
    {
        protected override global::Kotlinx.Datetime.Internal.Format.CachedFormatStructure RawActualFormat => ActualFormat;

        protected override global::Java.Lang.Object RawEmptyIntermediate => EmptyIntermediate;

        public override global::Java.Lang.Object IntermediateFromValue(global::Java.Lang.Object? p0)
            => IntermediateFromValueX(p0 as global::Kotlinx.Datetime.LocalDateTime);

        public override global::Java.Lang.Object? ValueFromIntermediate(global::Java.Lang.Object p0)
            => ValueFromIntermediateX(p0 as global::Kotlinx.Datetime.Format.IncompleteLocalDateTime);
    }
}
namespace Kotlinx.Datetime.Internal.Format
{
    partial class AbstractFieldSpec : IFieldSpec
    {
        IAccessor IFieldSpec.Accessor => Accessor;

        Java.Lang.Object? IFieldSpec.DefaultValue => DefaultValue;

        IFieldSign? IFieldSpec.Sign => Sign;
    }
    partial class UnsignedFieldSpec {
        protected override unsafe global::Java.Lang.Integer? DefaultValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='kotlinx.datetime.internal.format']/class[@name='UnsignedFieldSpec']/method[@name='getDefaultValue' and count(parameter)=0]"
			[Register ("getDefaultValue", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getDefaultValue.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}
    }
    partial class UnsignedIntFieldFormatDirective : global::Kotlinx.Datetime.Internal.Format.IFieldFormatDirective
    {
        IFieldSpec IFieldFormatDirective.Field => Field;
    }
    partial class NamedUnsignedIntFieldFormatDirective : global::Kotlinx.Datetime.Internal.Format.IFieldFormatDirective
    {
        IFieldSpec IFieldFormatDirective.Field => Field;
    }
}