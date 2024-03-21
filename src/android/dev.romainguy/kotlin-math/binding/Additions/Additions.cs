namespace Dev.Romainguy.Kotlin.Math
{
    partial class Half : global::Java.Lang.IComparable
    {
        int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object o)
        {
            return o is global::Java.Lang.Short s ? CompareTo(s.ShortValue()) : -1;
        }
    }
    partial class Rational : global::Java.Lang.IComparable
    {
        int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object o)
        {
            return o is global::Java.Lang.Long s ? CompareTo(s.LongValue()) : -1;
        }
    }
}