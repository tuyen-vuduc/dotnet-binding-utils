using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Maps.Plugins.Attributions
{
    partial class AttributionViewImpl : global::Com.Mapbox.Maps.Plugins.Attributions.IAttributionView
    {

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.maps.plugin.attribution']/class[@name='AttributionViewImpl']/method[@name='setContentDescription' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
        [Register("setContentDescription", "(Ljava/lang/CharSequence;)V", "")]
        public unsafe void SetContentDescription(global::Java.Lang.ICharSequence? contentDescription)
        {
            const string __id = "setContentDescription.(Ljava/lang/CharSequence;)V";
            IntPtr native_contentDescription = CharSequence.ToLocalJniHandle(contentDescription);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_contentDescription);
                _members.InstanceMethods.InvokeAbstractVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_contentDescription);
                global::System.GC.KeepAlive(contentDescription);
            }
        }
    }
}