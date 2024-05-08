using System;
using System.Collections;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;
using Java.Util;

namespace Kotlinx.Serialization.Json
{
    partial class JsonObject : global::Java.Util.IMap
    {
        System.Collections.ICollection IMap.EntrySet()
            => EntrySet().ToList();

        Java.Lang.Object? IMap.Get(Java.Lang.Object? key)
            => Get(key);

        System.Collections.ICollection IMap.KeySet()
            => KeySet().ToList();

        Java.Lang.Object? IMap.Put(Java.Lang.Object? key, Java.Lang.Object? value)
            => Put(key?.ToString(), value as global::Kotlinx.Serialization.Json.JsonElement);

        void IMap.PutAll(IDictionary m)
            => PutAll(new Dictionary<string, global::Kotlinx.Serialization.Json.JsonElement>(
                m.Keys.Cast<string>().Select(x => new KeyValuePair<string, global::Kotlinx.Serialization.Json.JsonElement>(
                x, m[x] as global::Kotlinx.Serialization.Json.JsonElement
                ))));

        Java.Lang.Object? IMap.Remove(Java.Lang.Object? key)
            => Remove(key);

        int IMap.Size() => Size;

        System.Collections.ICollection IMap.Values()
            => Values.ToList();
    }


    partial class JsonArray : global::Java.Util.IList
    {
        bool global::Java.Util.IList.Add(global::Java.Lang.Object obj)
            => Add(obj as global::Kotlinx.Serialization.Json.JsonElement);
        void global::Java.Util.IList.Add(int index, global::Java.Lang.Object obj)
            => Add(index, obj as global::Kotlinx.Serialization.Json.JsonElement);

        bool Java.Util.ICollection.Add(Java.Lang.Object? obj)
            => Add(obj as global::Kotlinx.Serialization.Json.JsonElement);

        bool global::Java.Util.IList.AddAll(global::System.Collections.ICollection items)
            => AddAll(items.Cast<global::Kotlinx.Serialization.Json.JsonElement>().ToList());
        bool global::Java.Util.IList.AddAll(int index, global::System.Collections.ICollection items)
            => AddAll(index, items.Cast<global::Kotlinx.Serialization.Json.JsonElement>().ToList());

        bool Java.Util.ICollection.AddAll(System.Collections.ICollection items)
            => AddAll(items.Cast<global::Kotlinx.Serialization.Json.JsonElement>().ToList());

        bool Java.Util.IList.Contains(Java.Lang.Object? o)
            => Contains(o as global::Kotlinx.Serialization.Json.JsonElement);

        bool Java.Util.IList.ContainsAll(System.Collections.ICollection items)
            => ContainsAll(items.Cast<global::Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.ContainsAll(System.Collections.ICollection items)
            => ContainsAll(items.Cast<global::Java.Lang.Object>().ToList());

        Java.Lang.Object? Java.Util.IList.Get(int index)
            => Get(index);

        int Java.Util.IList.IndexOf(Java.Lang.Object? o)
            => IndexOf(o as global::Kotlinx.Serialization.Json.JsonElement);

        int Java.Util.IList.LastIndexOf(Java.Lang.Object? o)
            => LastIndexOf(o as global::Kotlinx.Serialization.Json.JsonElement);

        Java.Lang.Object? Java.Util.IList.Remove(int index)
            => Remove(index);
        bool Java.Util.IList.Remove(Java.Lang.Object? o)
            => Remove(o as global::Kotlinx.Serialization.Json.JsonElement);

        bool Java.Util.IList.RemoveAll(System.Collections.ICollection items)
            => RemoveAll(items.Cast<global::Java.Lang.Object>().ToList());
        bool Java.Util.ICollection.RemoveAll(System.Collections.ICollection items)
            => RemoveAll(items.Cast<global::Java.Lang.Object>().ToList());

        bool Java.Util.IList.RetainAll(System.Collections.ICollection items)
            => RetainAll(items.Cast<global::Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.RetainAll(System.Collections.ICollection items)
            => RetainAll(items.Cast<global::Java.Lang.Object>().ToList());

        Java.Lang.Object? Java.Util.IList.Set(int index, Java.Lang.Object? element)
            => Set(index, element as global::Kotlinx.Serialization.Json.JsonElement);

        int Java.Util.IList.Size() => Size;

        int Java.Util.ICollection.Size() => Size;

        System.Collections.IList Java.Util.IList.SubList(int fromIndex, int toIndex)
            => SubList(fromIndex, toIndex).ToList();
    }
}