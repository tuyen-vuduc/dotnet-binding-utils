using Android.Runtime;

namespace Com.Intellimec.Mobile.Android.Portal.Alert
{
    partial class Alert
    {
        [Register("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
        public virtual int CompareTo(global::Java.Lang.Object o)
        {
            return CompareTo(o as Alert);
        }

        partial class Target
        {
            [Register("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
            public virtual int CompareTo(global::Java.Lang.Object o)
            {
                return CompareTo(o as Target);
            }
        }
    }
}

namespace Com.Intellimec.Mobile.Android.Portal.Vehicle
{
    partial class Vehicle
    {
        [Register("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
        public unsafe int CompareTo(global::Java.Lang.Object o)
        {
            return CompareTo(o as Vehicle);
        }
    }
}