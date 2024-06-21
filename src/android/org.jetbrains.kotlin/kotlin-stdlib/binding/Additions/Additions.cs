
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Kotlin {
    partial class KotlinVersion : global::Java.Lang.IComparable
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
            => CompareTo(o as  KotlinVersion);
    }
    partial class UByteArray
    {
        bool Java.Util.ICollection.Add(Java.Lang.Object? e)
            => Add((e as Java.Lang.Byte)?.ByteValue() ?? 0);

        bool Java.Util.ICollection.AddAll(global::System.Collections.ICollection c)
            => AddAll(c.Cast<UByte>().ToList());

        bool Java.Util.ICollection.ContainsAll(global::System.Collections.ICollection c)
            => ContainsAll(c.Cast<Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.RemoveAll(global::System.Collections.ICollection c)
            => RemoveAll(c.Cast<Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.RetainAll(global::System.Collections.ICollection c)
            => RetainAll(c.Cast<Java.Lang.Object>().ToList());

        int Java.Util.ICollection.Size() => GetSize();
    }
    partial class UIntArray
    {
        bool Java.Util.ICollection.Add(Java.Lang.Object? e)
            => Add((e as Java.Lang.Integer)?.IntValue() ?? 0);

        bool Java.Util.ICollection.AddAll(global::System.Collections.ICollection c)
            => AddAll(c.Cast<UInt>().ToList());

        bool Java.Util.ICollection.ContainsAll(global::System.Collections.ICollection c)
            => ContainsAll(c.Cast<Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.RemoveAll(global::System.Collections.ICollection c)
            => RemoveAll(c.Cast<Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.RetainAll(global::System.Collections.ICollection c)
            => RetainAll(c.Cast<Java.Lang.Object>().ToList());

        int Java.Util.ICollection.Size() => GetSize();
    }
    partial class ULongArray
    {
        bool Java.Util.ICollection.Add(Java.Lang.Object? e)
            => Add((e as Java.Lang.Long)?.LongValue() ?? 0);

        bool Java.Util.ICollection.AddAll(global::System.Collections.ICollection c)
            => AddAll(c.Cast<ULong>().ToList());

        bool Java.Util.ICollection.ContainsAll(global::System.Collections.ICollection c)
            => ContainsAll(c.Cast<Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.RemoveAll(global::System.Collections.ICollection c)
            => RemoveAll(c.Cast<Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.RetainAll(global::System.Collections.ICollection c)
            => RetainAll(c.Cast<Java.Lang.Object>().ToList());

        int Java.Util.ICollection.Size() => GetSize();
    }
    partial class UShortArray : global::Java.Util.ICollection   
    {
        bool Java.Util.ICollection.Add(Java.Lang.Object? e)
            => Add((e as Java.Lang.Short)?.ShortValue() ?? 0);

        bool Java.Util.ICollection.AddAll(global::System.Collections.ICollection c)
            => AddAll(c.Cast<UShort>().ToList());

        bool Java.Util.ICollection.ContainsAll(global::System.Collections.ICollection c)
            => ContainsAll(c.Cast<Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.RemoveAll(global::System.Collections.ICollection c)
            => RemoveAll(c.Cast<Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.RetainAll(global::System.Collections.ICollection c)
            => RetainAll(c.Cast<Java.Lang.Object>().ToList());

        int Java.Util.ICollection.Size() => GetSize();
    }
}

namespace Kotlin.Collections
{
    partial class AbstractList : global::Java.Util.IList
    {
    }

    partial class AbstractSet : global::Java.Util.ISet
    {

    }

    partial class AbstractMutableMap
    {
        public unsafe override global::System.Collections.ICollection EntrySet()
        {
            const string __id = "entrySet.()Ljava/util/Set;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
                var items = global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);

                return items?.ToList();
            }
            finally
            {
            }
        }
    }
    partial class AbstractMap : Java.Util.IMap
    {
        global::System.Collections.ICollection IMap.EntrySet()
            => EntrySet()?.ToList();

        global::System.Collections.ICollection IMap.Values()
            => Values;
    }

    partial class IntIterator : global::Java.Util.IIterator
    {
        Java.Lang.Object? IIterator.Next()
            => Next();
    }
    partial class ShortIterator : global::Java.Util.IIterator
    {
        Java.Lang.Object? IIterator.Next()
            => Next();
    }
    partial class FloatIterator : global::Java.Util.IIterator
    {
        Java.Lang.Object? IIterator.Next()
            => Next();
    }
    partial class LongIterator : global::Java.Util.IIterator
    {
        Java.Lang.Object? IIterator.Next()
            => Next();
    }
    partial class DoubleIterator : global::Java.Util.IIterator
    {
        Java.Lang.Object? IIterator.Next()
            => Next();
    }
    partial class CharIterator : global::Java.Util.IIterator
    {
        Java.Lang.Object? IIterator.Next()
            => Next();
    }
    partial class ByteIterator : global::Java.Util.IIterator
    {
        Java.Lang.Object? IIterator.Next()
            => Next();
    }
    partial class BooleanIterator : global::Java.Util.IIterator
    {
        Java.Lang.Object? IIterator.Next()
            => Next();
    }
}

namespace Kotlin.Ranges
{
    partial class CharProgression : global::Java.Lang.IIterable
    {
        IIterator IIterable.Iterator() => Iterator();
    }
    partial class IntProgression : global::Java.Lang.IIterable
    {
        IIterator IIterable.Iterator() => Iterator();
    }
    partial class LongProgression : global::Java.Lang.IIterable
    {
        IIterator IIterable.Iterator() => Iterator();
    }
}
namespace Kotlin.Collections.Builders {
    partial class  MapBuilder : IMap
    {
        global::System.Collections.ICollection IMap.EntrySet()
            => EntrySet()?.ToList();

        global::System.Collections.ICollection IMap.Values()
            => Values;

        partial class EntriesItr : global::Java.Util.IIterator
        {
            Java.Lang.Object? IIterator.Next() => Next();
        }
    }

    partial class MapBuilderEntries
    {
        public override bool Add(Java.Lang.Object? e)
            => Add(e as IMapEntry);
    }
}
namespace Kotlin.Time {
    partial interface ITimeSource
    { 
        partial class Monotonic
        {
            partial class ValueTimeMark : IComparableTimeMark, ITimeMark
            {
                int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
                    => CompareTo(o as IComparableTimeMark);

                long ITimeMark.ElapsedNow() => ElapsedNow_UwyO8pc();
            }
        }
    }

    partial class Duration : global::Java.Lang.IComparable
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
            => CompareTo((o as Java.Lang.Long)?.LongValue() ?? 0);
    }
}