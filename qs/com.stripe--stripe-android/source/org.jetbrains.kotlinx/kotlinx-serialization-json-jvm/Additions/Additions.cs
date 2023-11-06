using Android.Runtime;
using Kotlinx.Serialization.Descriptors;
using Kotlinx.Serialization.Encoding;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kotlinx.Serialization.Json
{
    partial class JsonArray : global::Java.Util.IList
    {
        public bool Add(Java.Lang.Object e)
        {
            return Add(e as JsonElement);
        }

        public void Add(int index, Java.Lang.Object element)
        {
            Add(index, element as JsonElement);
        }

        public bool AddAll(int index, System.Collections.ICollection c)
        {
            return AddAll(index, (ICollection<JsonElement>)c?.Cast<JsonElement>().ToList());
        }

        public bool AddAll(System.Collections.ICollection c)
        {
            return AddAll((ICollection<JsonElement>)c?.Cast<JsonElement>().ToList());
        }

        public bool ContainsAll(System.Collections.ICollection c)
        {
            return ContainsAll((ICollection<global::Java.Lang.Object>)c?.Cast<global::Java.Lang.Object>().ToList());
        }

        Java.Lang.Object Java.Util.IList.Get(int index)
        {
            return Get(index);
        }

        Java.Lang.Object Java.Util.IList.Remove(int index)
        {
            return Remove(index);
        }

        public bool RemoveAll(System.Collections.ICollection c)
        {
            return RemoveAll((ICollection<global::Java.Lang.Object>)c?.Cast<global::Java.Lang.Object>().ToList());
        }

        public bool RetainAll(System.Collections.ICollection c)
        {
            return RetainAll((ICollection<global::Java.Lang.Object>)c?.Cast<global::Java.Lang.Object>().ToList());
        }

        public Java.Lang.Object Set(int index, Java.Lang.Object element)
        {
            return Set(index, element as JsonElement);
        }

        System.Collections.IList Java.Util.IList.SubList(int fromIndex, int toIndex)
        {
           return SubList(fromIndex, toIndex).ToList();
        }
    }

    partial class JsonObject : global::Java.Util.IMap
    {
        System.Collections.ICollection global::Java.Util.IMap.KeySet() => KeySet().ToList();
        System.Collections.ICollection global::Java.Util.IMap.EntrySet() => EntrySet().ToList();
        System.Collections.ICollection global::Java.Util.IMap.Values() => Values.ToList();
        Java.Lang.Object global::Java.Util.IMap.Get(Java.Lang.Object obj) => Get(obj);
        Java.Lang.Object global::Java.Util.IMap.Put(Java.Lang.Object key, Java.Lang.Object value) => Put(key.ToString(), value as JsonElement);
        void global::Java.Util.IMap.PutAll(IDictionary m) => PutAll(m as IDictionary<string, JsonElement>);
        Java.Lang.Object global::Java.Util.IMap.Remove(Java.Lang.Object key) => Remove(key.ToString());
    }
}