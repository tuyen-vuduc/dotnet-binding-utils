namespace Com.Google.Android.Filament.Utils
{
    partial class Half : global::Java.Lang.IComparable
    {
        int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object other)
        {
            if (other is not global::Java.Lang.Short value)
            {
                return -1;
            }

            return CompareTo(value.ShortValue());
        }
    }
}