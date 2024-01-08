// using System;
// using System.Collections.Generic;
// using Android.Runtime;
// using Java.Interop;
// using System.Linq;

// namespace Com.Mapbox.Maps.Extension.Style
// {
//     delegate IntPtr _JniMarshal_PPLFLZLLL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, float p1, IntPtr p2, bool p3, IntPtr p4, IntPtr p5, IntPtr p6);
//     delegate IntPtr _JniMarshal_PPLLL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);

//     partial interface IStyleInterface : global::Com.Mapbox.Maps.IStyleManagerInterface
//     {

//     }

//     internal partial class IStyleInterfaceInvoker : global::Java.Lang.Object, IStyleInterface
//     {
//         static Delegate cb_isStyleLoaded;
// #pragma warning disable 0169
//         static Delegate GetIsStyleLoadedHandler()
//         {
//             if (cb_isStyleLoaded == null)
//                 cb_isStyleLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(n_IsStyleLoaded));
//             return cb_isStyleLoaded;
//         }

//         static bool n_IsStyleLoaded(IntPtr jnienv, IntPtr native__this)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             return __this.IsStyleLoaded;
//         }
// #pragma warning restore 0169

//         IntPtr id_isStyleLoaded;
//         public unsafe bool IsStyleLoaded
//         {
//             get
//             {
//                 if (id_isStyleLoaded == IntPtr.Zero)
//                     id_isStyleLoaded = JNIEnv.GetMethodID(class_ref, "isStyleLoaded", "()Z");
//                 return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isStyleLoaded);
//             }
//         }

//         static Delegate cb_getStyleDefaultCamera;
// #pragma warning disable 0169
//         static Delegate GetGetStyleDefaultCameraHandler()
//         {
//             if (cb_getStyleDefaultCamera == null)
//                 cb_getStyleDefaultCamera = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetStyleDefaultCamera));
//             return cb_getStyleDefaultCamera;
//         }

//         static IntPtr n_GetStyleDefaultCamera(IntPtr jnienv, IntPtr native__this)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             return JNIEnv.ToLocalJniHandle(__this.StyleDefaultCamera);
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleDefaultCamera;
//         public unsafe global::Com.Mapbox.Maps.CameraOptions StyleDefaultCamera
//         {
//             get
//             {
//                 if (id_getStyleDefaultCamera == IntPtr.Zero)
//                     id_getStyleDefaultCamera = JNIEnv.GetMethodID(class_ref, "getStyleDefaultCamera", "()Lcom/mapbox/maps/CameraOptions;");
//                 return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.CameraOptions>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleDefaultCamera), JniHandleOwnership.TransferLocalRef);
//             }
//         }

//         static Delegate cb_getStyleJSON;
// #pragma warning disable 0169
//         static Delegate GetGetStyleJSONHandler()
//         {
//             if (cb_getStyleJSON == null)
//                 cb_getStyleJSON = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetStyleJSON));
//             return cb_getStyleJSON;
//         }

//         static IntPtr n_GetStyleJSON(IntPtr jnienv, IntPtr native__this)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             return JNIEnv.NewString(__this.StyleJSON);
//         }
// #pragma warning restore 0169

//         static Delegate cb_setStyleJSON_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleJSON_Ljava_lang_String_Handler()
//         {
//             if (cb_setStyleJSON_Ljava_lang_String_ == null)
//                 cb_setStyleJSON_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(n_SetStyleJSON_Ljava_lang_String_));
//             return cb_setStyleJSON_Ljava_lang_String_;
//         }

//         static void n_SetStyleJSON_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var value = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
//             __this.StyleJSON = value;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleJSON;
//         IntPtr id_setStyleJSON_Ljava_lang_String_;
//         public unsafe string StyleJSON
//         {
//             get
//             {
//                 if (id_getStyleJSON == IntPtr.Zero)
//                     id_getStyleJSON = JNIEnv.GetMethodID(class_ref, "getStyleJSON", "()Ljava/lang/String;");
//                 return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleJSON), JniHandleOwnership.TransferLocalRef);
//             }
//             set
//             {
//                 if (id_setStyleJSON_Ljava_lang_String_ == IntPtr.Zero)
//                     id_setStyleJSON_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "setStyleJSON", "(Ljava/lang/String;)V");
//                 IntPtr native_value = JNIEnv.NewString((string)value);
//                 JValue* __args = stackalloc JValue[1];
//                 __args[0] = new JValue(native_value);
//                 JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setStyleJSON_Ljava_lang_String_, __args);
//                 JNIEnv.DeleteLocalRef(native_value);
//             }
//         }

//         static Delegate cb_getStyleLayers;
// #pragma warning disable 0169
//         static Delegate GetGetStyleLayersHandler()
//         {
//             if (cb_getStyleLayers == null)
//                 cb_getStyleLayers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetStyleLayers));
//             return cb_getStyleLayers;
//         }

//         static IntPtr n_GetStyleLayers(IntPtr jnienv, IntPtr native__this)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             return global::Android.Runtime.JavaList.ToLocalJniHandle(__this.StyleLayers.ToList());
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleLayers;
//         public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Maps.StyleObjectInfo> StyleLayers
//         {
//             get
//             {
//                 if (id_getStyleLayers == IntPtr.Zero)
//                     id_getStyleLayers = JNIEnv.GetMethodID(class_ref, "getStyleLayers", "()Ljava/util/List;");
//                 return global::Android.Runtime.JavaList<global::Com.Mapbox.Maps.StyleObjectInfo>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleLayers), JniHandleOwnership.TransferLocalRef);
//             }
//         }

//         static Delegate cb_getStyleLights;
// #pragma warning disable 0169
//         static Delegate GetGetStyleLightsHandler()
//         {
//             if (cb_getStyleLights == null)
//                 cb_getStyleLights = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetStyleLights));
//             return cb_getStyleLights;
//         }

//         static IntPtr n_GetStyleLights(IntPtr jnienv, IntPtr native__this)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             return global::Android.Runtime.JavaList.ToLocalJniHandle(__this.StyleLights.ToList());
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleLights;
//         public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Maps.StyleObjectInfo> StyleLights
//         {
//             get
//             {
//                 if (id_getStyleLights == IntPtr.Zero)
//                     id_getStyleLights = JNIEnv.GetMethodID(class_ref, "getStyleLights", "()Ljava/util/List;");
//                 return global::Android.Runtime.JavaList<global::Com.Mapbox.Maps.StyleObjectInfo>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleLights), JniHandleOwnership.TransferLocalRef);
//             }
//         }

//         static Delegate cb_getStyleSources;
// #pragma warning disable 0169
//         static Delegate GetGetStyleSourcesHandler()
//         {
//             if (cb_getStyleSources == null)
//                 cb_getStyleSources = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetStyleSources));
//             return cb_getStyleSources;
//         }

//         static IntPtr n_GetStyleSources(IntPtr jnienv, IntPtr native__this)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             return global::Android.Runtime.JavaList.ToLocalJniHandle(__this.StyleSources.ToList());
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleSources;
//         public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Maps.StyleObjectInfo> StyleSources
//         {
//             get
//             {
//                 if (id_getStyleSources == IntPtr.Zero)
//                     id_getStyleSources = JNIEnv.GetMethodID(class_ref, "getStyleSources", "()Ljava/util/List;");
//                 return global::Android.Runtime.JavaList<global::Com.Mapbox.Maps.StyleObjectInfo>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleSources), JniHandleOwnership.TransferLocalRef);
//             }
//         }

//         static Delegate cb_getStyleTransition;
// #pragma warning disable 0169
//         static Delegate GetGetStyleTransitionHandler()
//         {
//             if (cb_getStyleTransition == null)
//                 cb_getStyleTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetStyleTransition));
//             return cb_getStyleTransition;
//         }

//         static IntPtr n_GetStyleTransition(IntPtr jnienv, IntPtr native__this)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             return JNIEnv.ToLocalJniHandle(__this.StyleTransition);
//         }
// #pragma warning restore 0169

//         static Delegate cb_setStyleTransition_Lcom_mapbox_maps_TransitionOptions_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleTransition_Lcom_mapbox_maps_TransitionOptions_Handler()
//         {
//             if (cb_setStyleTransition_Lcom_mapbox_maps_TransitionOptions_ == null)
//                 cb_setStyleTransition_Lcom_mapbox_maps_TransitionOptions_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(n_SetStyleTransition_Lcom_mapbox_maps_TransitionOptions_));
//             return cb_setStyleTransition_Lcom_mapbox_maps_TransitionOptions_;
//         }

//         static void n_SetStyleTransition_Lcom_mapbox_maps_TransitionOptions_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var value = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.TransitionOptions>(native_value, JniHandleOwnership.DoNotTransfer);
//             __this.StyleTransition = value;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleTransition;
//         IntPtr id_setStyleTransition_Lcom_mapbox_maps_TransitionOptions_;
//         public unsafe global::Com.Mapbox.Maps.TransitionOptions StyleTransition
//         {
//             get
//             {
//                 if (id_getStyleTransition == IntPtr.Zero)
//                     id_getStyleTransition = JNIEnv.GetMethodID(class_ref, "getStyleTransition", "()Lcom/mapbox/maps/TransitionOptions;");
//                 return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.TransitionOptions>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleTransition), JniHandleOwnership.TransferLocalRef);
//             }
//             set
//             {
//                 if (id_setStyleTransition_Lcom_mapbox_maps_TransitionOptions_ == IntPtr.Zero)
//                     id_setStyleTransition_Lcom_mapbox_maps_TransitionOptions_ = JNIEnv.GetMethodID(class_ref, "setStyleTransition", "(Lcom/mapbox/maps/TransitionOptions;)V");
//                 JValue* __args = stackalloc JValue[1];
//                 __args[0] = new JValue((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object)value).Handle);
//                 JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setStyleTransition_Lcom_mapbox_maps_TransitionOptions_, __args);
//             }
//         }

//         static Delegate cb_getStyleURI;
// #pragma warning disable 0169
//         static Delegate GetGetStyleURIHandler()
//         {
//             if (cb_getStyleURI == null)
//                 cb_getStyleURI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetStyleURI));
//             return cb_getStyleURI;
//         }

//         static IntPtr n_GetStyleURI(IntPtr jnienv, IntPtr native__this)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             return JNIEnv.NewString(__this.StyleURI);
//         }
// #pragma warning restore 0169

//         static Delegate cb_setStyleURI_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleURI_Ljava_lang_String_Handler()
//         {
//             if (cb_setStyleURI_Ljava_lang_String_ == null)
//                 cb_setStyleURI_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(n_SetStyleURI_Ljava_lang_String_));
//             return cb_setStyleURI_Ljava_lang_String_;
//         }

//         static void n_SetStyleURI_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var value = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
//             __this.StyleURI = value;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleURI;
//         IntPtr id_setStyleURI_Ljava_lang_String_;
//         public unsafe string StyleURI
//         {
//             get
//             {
//                 if (id_getStyleURI == IntPtr.Zero)
//                     id_getStyleURI = JNIEnv.GetMethodID(class_ref, "getStyleURI", "()Ljava/lang/String;");
//                 return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleURI), JniHandleOwnership.TransferLocalRef);
//             }
//             set
//             {
//                 if (id_setStyleURI_Ljava_lang_String_ == IntPtr.Zero)
//                     id_setStyleURI_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "setStyleURI", "(Ljava/lang/String;)V");
//                 IntPtr native_value = JNIEnv.NewString((string)value);
//                 JValue* __args = stackalloc JValue[1];
//                 __args[0] = new JValue(native_value);
//                 JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setStyleURI_Ljava_lang_String_, __args);
//                 JNIEnv.DeleteLocalRef(native_value);
//             }
//         }

//         static Delegate cb_addPersistentStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_;
// #pragma warning disable 0169
//         static Delegate GetAddPersistentStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_Handler()
//         {
//             if (cb_addPersistentStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_ == null)
//                 cb_addPersistentStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(n_AddPersistentStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_));
//             return cb_addPersistentStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_;
//         }

//         static IntPtr n_AddPersistentStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = (global::Com.Mapbox.Maps.ICustomLayerHost)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.ICustomLayerHost>(native_p1, JniHandleOwnership.DoNotTransfer);
//             var p2 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.LayerPosition>(native_p2, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.AddPersistentStyleCustomLayer(p0, p1, p2));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_addPersistentStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected AddPersistentStyleCustomLayer(string p0, global::Com.Mapbox.Maps.ICustomLayerHost p1, global::Com.Mapbox.Maps.LayerPosition p2)
//         {
//             if (id_addPersistentStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_ == IntPtr.Zero)
//                 id_addPersistentStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_ = JNIEnv.GetMethodID(class_ref, "addPersistentStyleCustomLayer", "(Ljava/lang/String;Lcom/mapbox/maps/CustomLayerHost;Lcom/mapbox/maps/LayerPosition;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[3];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             __args[2] = new JValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addPersistentStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_addPersistentStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_;
// #pragma warning disable 0169
//         static Delegate GetAddPersistentStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_Handler()
//         {
//             if (cb_addPersistentStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_ == null)
//                 cb_addPersistentStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_AddPersistentStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_));
//             return cb_addPersistentStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_;
//         }

//         static IntPtr n_AddPersistentStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.LayerPosition>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.AddPersistentStyleLayer(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_addPersistentStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected AddPersistentStyleLayer(global::Com.Mapbox.Bindgen.Value p0, global::Com.Mapbox.Maps.LayerPosition p1)
//         {
//             if (id_addPersistentStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_ == IntPtr.Zero)
//                 id_addPersistentStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_ = JNIEnv.GetMethodID(class_ref, "addPersistentStyleLayer", "(Lcom/mapbox/bindgen/Value;Lcom/mapbox/maps/LayerPosition;)Lcom/mapbox/bindgen/Expected;");
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addPersistentStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_, __args), JniHandleOwnership.TransferLocalRef);
//             return __ret;
//         }

//         static Delegate cb_addStyleCustomGeometrySource_Ljava_lang_String_Lcom_mapbox_maps_CustomGeometrySourceOptions_;
// #pragma warning disable 0169
//         static Delegate GetAddStyleCustomGeometrySource_Ljava_lang_String_Lcom_mapbox_maps_CustomGeometrySourceOptions_Handler()
//         {
//             if (cb_addStyleCustomGeometrySource_Ljava_lang_String_Lcom_mapbox_maps_CustomGeometrySourceOptions_ == null)
//                 cb_addStyleCustomGeometrySource_Ljava_lang_String_Lcom_mapbox_maps_CustomGeometrySourceOptions_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_AddStyleCustomGeometrySource_Ljava_lang_String_Lcom_mapbox_maps_CustomGeometrySourceOptions_));
//             return cb_addStyleCustomGeometrySource_Ljava_lang_String_Lcom_mapbox_maps_CustomGeometrySourceOptions_;
//         }

//         static IntPtr n_AddStyleCustomGeometrySource_Ljava_lang_String_Lcom_mapbox_maps_CustomGeometrySourceOptions_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.CustomGeometrySourceOptions>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.AddStyleCustomGeometrySource(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_addStyleCustomGeometrySource_Ljava_lang_String_Lcom_mapbox_maps_CustomGeometrySourceOptions_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected AddStyleCustomGeometrySource(string p0, global::Com.Mapbox.Maps.CustomGeometrySourceOptions p1)
//         {
//             if (id_addStyleCustomGeometrySource_Ljava_lang_String_Lcom_mapbox_maps_CustomGeometrySourceOptions_ == IntPtr.Zero)
//                 id_addStyleCustomGeometrySource_Ljava_lang_String_Lcom_mapbox_maps_CustomGeometrySourceOptions_ = JNIEnv.GetMethodID(class_ref, "addStyleCustomGeometrySource", "(Ljava/lang/String;Lcom/mapbox/maps/CustomGeometrySourceOptions;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addStyleCustomGeometrySource_Ljava_lang_String_Lcom_mapbox_maps_CustomGeometrySourceOptions_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_addStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_;
// #pragma warning disable 0169
//         static Delegate GetAddStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_Handler()
//         {
//             if (cb_addStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_ == null)
//                 cb_addStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(n_AddStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_));
//             return cb_addStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_;
//         }

//         static IntPtr n_AddStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = (global::Com.Mapbox.Maps.ICustomLayerHost)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.ICustomLayerHost>(native_p1, JniHandleOwnership.DoNotTransfer);
//             var p2 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.LayerPosition>(native_p2, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.AddStyleCustomLayer(p0, p1, p2));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_addStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected AddStyleCustomLayer(string p0, global::Com.Mapbox.Maps.ICustomLayerHost p1, global::Com.Mapbox.Maps.LayerPosition p2)
//         {
//             if (id_addStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_ == IntPtr.Zero)
//                 id_addStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_ = JNIEnv.GetMethodID(class_ref, "addStyleCustomLayer", "(Ljava/lang/String;Lcom/mapbox/maps/CustomLayerHost;Lcom/mapbox/maps/LayerPosition;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[3];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             __args[2] = new JValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addStyleCustomLayer_Ljava_lang_String_Lcom_mapbox_maps_CustomLayerHost_Lcom_mapbox_maps_LayerPosition_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_addStyleImage_Ljava_lang_String_FLcom_mapbox_maps_Image_ZLSystem_Collections_Generic_IList_1_LSystem_Collections_Generic_IList_1_Lcom_mapbox_maps_ImageContent_;
// #pragma warning disable 0169
//         static Delegate GetAddStyleImage_Ljava_lang_String_FLcom_mapbox_maps_Image_ZLSystem_Collections_Generic_IList_1_LSystem_Collections_Generic_IList_1_Lcom_mapbox_maps_ImageContent_Handler()
//         {
//             if (cb_addStyleImage_Ljava_lang_String_FLcom_mapbox_maps_Image_ZLSystem_Collections_Generic_IList_1_LSystem_Collections_Generic_IList_1_Lcom_mapbox_maps_ImageContent_ == null)
//                 cb_addStyleImage_Ljava_lang_String_FLcom_mapbox_maps_Image_ZLSystem_Collections_Generic_IList_1_LSystem_Collections_Generic_IList_1_Lcom_mapbox_maps_ImageContent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFLZLLL_L(n_AddStyleImage_Ljava_lang_String_FLcom_mapbox_maps_Image_ZLSystem_Collections_Generic_IList_1_LSystem_Collections_Generic_IList_1_Lcom_mapbox_maps_ImageContent_));
//             return cb_addStyleImage_Ljava_lang_String_FLcom_mapbox_maps_Image_ZLSystem_Collections_Generic_IList_1_LSystem_Collections_Generic_IList_1_Lcom_mapbox_maps_ImageContent_;
//         }

//         static IntPtr n_AddStyleImage_Ljava_lang_String_FLcom_mapbox_maps_Image_ZLSystem_Collections_Generic_IList_1_LSystem_Collections_Generic_IList_1_Lcom_mapbox_maps_ImageContent_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, IntPtr native_p2, bool p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p2 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Image>(native_p2, JniHandleOwnership.DoNotTransfer);
//             var p4 = global::Android.Runtime.JavaList<Com.Mapbox.Maps.ImageStretches>.FromJniHandle(native_p4, JniHandleOwnership.DoNotTransfer);
//             var p5 = global::Android.Runtime.JavaList<Com.Mapbox.Maps.ImageStretches>.FromJniHandle(native_p5, JniHandleOwnership.DoNotTransfer);
//             var p6 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.ImageContent>(native_p6, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.AddStyleImage(p0, p1, p2, p3, p4, p5, p6));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_addStyleImage_Ljava_lang_String_FLcom_mapbox_maps_Image_ZLSystem_Collections_Generic_IList_1_LSystem_Collections_Generic_IList_1_Lcom_mapbox_maps_ImageContent_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected AddStyleImage(string p0, float p1, global::Com.Mapbox.Maps.Image p2, bool p3, global::System.Collections.Generic.IList<Com.Mapbox.Maps.ImageStretches> p4, global::System.Collections.Generic.IList<Com.Mapbox.Maps.ImageStretches> p5, global::Com.Mapbox.Maps.ImageContent p6)
//         {
//             if (id_addStyleImage_Ljava_lang_String_FLcom_mapbox_maps_Image_ZLSystem_Collections_Generic_IList_1_LSystem_Collections_Generic_IList_1_Lcom_mapbox_maps_ImageContent_ == IntPtr.Zero)
//                 id_addStyleImage_Ljava_lang_String_FLcom_mapbox_maps_Image_ZLSystem_Collections_Generic_IList_1_LSystem_Collections_Generic_IList_1_Lcom_mapbox_maps_ImageContent_ = JNIEnv.GetMethodID(class_ref, "addStyleImage", "(Ljava/lang/String;FLcom/mapbox/maps/Image;ZLSystem/Collections/Generic/IList`1;LSystem/Collections/Generic/IList`1;Lcom/mapbox/maps/ImageContent;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[7];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue(p1);
//             __args[2] = new JValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
//             __args[3] = new JValue(p3);
//             __args[4] = new JValue((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p4).Handle);
//             __args[5] = new JValue((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p5).Handle);
//             __args[6] = new JValue((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p6).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addStyleImage_Ljava_lang_String_FLcom_mapbox_maps_Image_ZLSystem_Collections_Generic_IList_1_LSystem_Collections_Generic_IList_1_Lcom_mapbox_maps_ImageContent_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_addStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_;
// #pragma warning disable 0169
//         static Delegate GetAddStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_Handler()
//         {
//             if (cb_addStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_ == null)
//                 cb_addStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_AddStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_));
//             return cb_addStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_;
//         }

//         static IntPtr n_AddStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.LayerPosition>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.AddStyleLayer(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_addStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected AddStyleLayer(global::Com.Mapbox.Bindgen.Value p0, global::Com.Mapbox.Maps.LayerPosition p1)
//         {
//             if (id_addStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_ == IntPtr.Zero)
//                 id_addStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_ = JNIEnv.GetMethodID(class_ref, "addStyleLayer", "(Lcom/mapbox/bindgen/Value;Lcom/mapbox/maps/LayerPosition;)Lcom/mapbox/bindgen/Expected;");
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addStyleLayer_Lcom_mapbox_bindgen_Value_Lcom_mapbox_maps_LayerPosition_, __args), JniHandleOwnership.TransferLocalRef);
//             return __ret;
//         }

//         static Delegate cb_addStyleModel_Ljava_lang_String_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetAddStyleModel_Ljava_lang_String_Ljava_lang_String_Handler()
//         {
//             if (cb_addStyleModel_Ljava_lang_String_Ljava_lang_String_ == null)
//                 cb_addStyleModel_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_AddStyleModel_Ljava_lang_String_Ljava_lang_String_));
//             return cb_addStyleModel_Ljava_lang_String_Ljava_lang_String_;
//         }

//         static IntPtr n_AddStyleModel_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.AddStyleModel(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_addStyleModel_Ljava_lang_String_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected AddStyleModel(string p0, string p1)
//         {
//             if (id_addStyleModel_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
//                 id_addStyleModel_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "addStyleModel", "(Ljava/lang/String;Ljava/lang/String;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             IntPtr native_p1 = JNIEnv.NewString((string)p1);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue(native_p1);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addStyleModel_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             JNIEnv.DeleteLocalRef(native_p1);
//             return __ret;
//         }

//         static Delegate cb_addStyleSource_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetAddStyleSource_Ljava_lang_String_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_addStyleSource_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_addStyleSource_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_AddStyleSource_Ljava_lang_String_Lcom_mapbox_bindgen_Value_));
//             return cb_addStyleSource_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_AddStyleSource_Ljava_lang_String_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.AddStyleSource(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_addStyleSource_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected AddStyleSource(string p0, global::Com.Mapbox.Bindgen.Value p1)
//         {
//             if (id_addStyleSource_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_addStyleSource_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "addStyleSource", "(Ljava/lang/String;Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addStyleSource_Ljava_lang_String_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_getStyleAtmosphereProperty_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetGetStyleAtmosphereProperty_Ljava_lang_String_Handler()
//         {
//             if (cb_getStyleAtmosphereProperty_Ljava_lang_String_ == null)
//                 cb_getStyleAtmosphereProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_GetStyleAtmosphereProperty_Ljava_lang_String_));
//             return cb_getStyleAtmosphereProperty_Ljava_lang_String_;
//         }

//         static IntPtr n_GetStyleAtmosphereProperty_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetStyleAtmosphereProperty(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleAtmosphereProperty_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Maps.StylePropertyValue GetStyleAtmosphereProperty(string p0)
//         {
//             if (id_getStyleAtmosphereProperty_Ljava_lang_String_ == IntPtr.Zero)
//                 id_getStyleAtmosphereProperty_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getStyleAtmosphereProperty", "(Ljava/lang/String;)Lcom/mapbox/maps/StylePropertyValue;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.StylePropertyValue>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleAtmosphereProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_getStyleImage_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetGetStyleImage_Ljava_lang_String_Handler()
//         {
//             if (cb_getStyleImage_Ljava_lang_String_ == null)
//                 cb_getStyleImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_GetStyleImage_Ljava_lang_String_));
//             return cb_getStyleImage_Ljava_lang_String_;
//         }

//         static IntPtr n_GetStyleImage_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetStyleImage(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleImage_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Maps.Image GetStyleImage(string p0)
//         {
//             if (id_getStyleImage_Ljava_lang_String_ == IntPtr.Zero)
//                 id_getStyleImage_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getStyleImage", "(Ljava/lang/String;)Lcom/mapbox/maps/Image;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Image>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleImage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_getStyleLayerProperties_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetGetStyleLayerProperties_Ljava_lang_String_Handler()
//         {
//             if (cb_getStyleLayerProperties_Ljava_lang_String_ == null)
//                 cb_getStyleLayerProperties_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_GetStyleLayerProperties_Ljava_lang_String_));
//             return cb_getStyleLayerProperties_Ljava_lang_String_;
//         }

//         static IntPtr n_GetStyleLayerProperties_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetStyleLayerProperties(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleLayerProperties_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected GetStyleLayerProperties(string p0)
//         {
//             if (id_getStyleLayerProperties_Ljava_lang_String_ == IntPtr.Zero)
//                 id_getStyleLayerProperties_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getStyleLayerProperties", "(Ljava/lang/String;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleLayerProperties_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_getStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetGetStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Handler()
//         {
//             if (cb_getStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_ == null)
//                 cb_getStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_GetStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_));
//             return cb_getStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_;
//         }

//         static IntPtr n_GetStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetStyleLayerProperty(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Maps.StylePropertyValue GetStyleLayerProperty(string p0, string p1)
//         {
//             if (id_getStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
//                 id_getStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getStyleLayerProperty", "(Ljava/lang/String;Ljava/lang/String;)Lcom/mapbox/maps/StylePropertyValue;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             IntPtr native_p1 = JNIEnv.NewString((string)p1);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue(native_p1);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.StylePropertyValue>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             JNIEnv.DeleteLocalRef(native_p1);
//             return __ret;
//         }

//         static Delegate cb_getStyleLightProperty_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetGetStyleLightProperty_Ljava_lang_String_Handler()
//         {
//             if (cb_getStyleLightProperty_Ljava_lang_String_ == null)
//                 cb_getStyleLightProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_GetStyleLightProperty_Ljava_lang_String_));
//             return cb_getStyleLightProperty_Ljava_lang_String_;
//         }

//         static IntPtr n_GetStyleLightProperty_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetStyleLightProperty(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleLightProperty_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Maps.StylePropertyValue GetStyleLightProperty(string p0)
//         {
//             if (id_getStyleLightProperty_Ljava_lang_String_ == IntPtr.Zero)
//                 id_getStyleLightProperty_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getStyleLightProperty", "(Ljava/lang/String;)Lcom/mapbox/maps/StylePropertyValue;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.StylePropertyValue>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleLightProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_getStyleLightProperty_Ljava_lang_String_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetGetStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Handler()
//         {
//             if (cb_getStyleLightProperty_Ljava_lang_String_Ljava_lang_String_ == null)
//                 cb_getStyleLightProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_GetStyleLightProperty_Ljava_lang_String_Ljava_lang_String_));
//             return cb_getStyleLightProperty_Ljava_lang_String_Ljava_lang_String_;
//         }

//         static IntPtr n_GetStyleLightProperty_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetStyleLightProperty(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleLightProperty_Ljava_lang_String_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Maps.StylePropertyValue GetStyleLightProperty(string p0, string p1)
//         {
//             if (id_getStyleLightProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
//                 id_getStyleLightProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getStyleLightProperty", "(Ljava/lang/String;Ljava/lang/String;)Lcom/mapbox/maps/StylePropertyValue;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             IntPtr native_p1 = JNIEnv.NewString((string)p1);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue(native_p1);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.StylePropertyValue>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleLightProperty_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             JNIEnv.DeleteLocalRef(native_p1);
//             return __ret;
//         }

//         static Delegate cb_getStyleProjectionProperty_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetGetStyleProjectionProperty_Ljava_lang_String_Handler()
//         {
//             if (cb_getStyleProjectionProperty_Ljava_lang_String_ == null)
//                 cb_getStyleProjectionProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_GetStyleProjectionProperty_Ljava_lang_String_));
//             return cb_getStyleProjectionProperty_Ljava_lang_String_;
//         }

//         static IntPtr n_GetStyleProjectionProperty_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetStyleProjectionProperty(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleProjectionProperty_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Maps.StylePropertyValue GetStyleProjectionProperty(string p0)
//         {
//             if (id_getStyleProjectionProperty_Ljava_lang_String_ == IntPtr.Zero)
//                 id_getStyleProjectionProperty_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getStyleProjectionProperty", "(Ljava/lang/String;)Lcom/mapbox/maps/StylePropertyValue;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.StylePropertyValue>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleProjectionProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_getStyleSourceProperties_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetGetStyleSourceProperties_Ljava_lang_String_Handler()
//         {
//             if (cb_getStyleSourceProperties_Ljava_lang_String_ == null)
//                 cb_getStyleSourceProperties_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_GetStyleSourceProperties_Ljava_lang_String_));
//             return cb_getStyleSourceProperties_Ljava_lang_String_;
//         }

//         static IntPtr n_GetStyleSourceProperties_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetStyleSourceProperties(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleSourceProperties_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected GetStyleSourceProperties(string p0)
//         {
//             if (id_getStyleSourceProperties_Ljava_lang_String_ == IntPtr.Zero)
//                 id_getStyleSourceProperties_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getStyleSourceProperties", "(Ljava/lang/String;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleSourceProperties_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_getStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetGetStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Handler()
//         {
//             if (cb_getStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_ == null)
//                 cb_getStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_GetStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_));
//             return cb_getStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_;
//         }

//         static IntPtr n_GetStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetStyleSourceProperty(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Maps.StylePropertyValue GetStyleSourceProperty(string p0, string p1)
//         {
//             if (id_getStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
//                 id_getStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getStyleSourceProperty", "(Ljava/lang/String;Ljava/lang/String;)Lcom/mapbox/maps/StylePropertyValue;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             IntPtr native_p1 = JNIEnv.NewString((string)p1);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue(native_p1);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.StylePropertyValue>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             JNIEnv.DeleteLocalRef(native_p1);
//             return __ret;
//         }

//         static Delegate cb_getStyleTerrainProperty_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetGetStyleTerrainProperty_Ljava_lang_String_Handler()
//         {
//             if (cb_getStyleTerrainProperty_Ljava_lang_String_ == null)
//                 cb_getStyleTerrainProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_GetStyleTerrainProperty_Ljava_lang_String_));
//             return cb_getStyleTerrainProperty_Ljava_lang_String_;
//         }

//         static IntPtr n_GetStyleTerrainProperty_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetStyleTerrainProperty(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_getStyleTerrainProperty_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Maps.StylePropertyValue GetStyleTerrainProperty(string p0)
//         {
//             if (id_getStyleTerrainProperty_Ljava_lang_String_ == IntPtr.Zero)
//                 id_getStyleTerrainProperty_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getStyleTerrainProperty", "(Ljava/lang/String;)Lcom/mapbox/maps/StylePropertyValue;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.StylePropertyValue>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getStyleTerrainProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_hasStyleImage_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetHasStyleImage_Ljava_lang_String_Handler()
//         {
//             if (cb_hasStyleImage_Ljava_lang_String_ == null)
//                 cb_hasStyleImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(n_HasStyleImage_Ljava_lang_String_));
//             return cb_hasStyleImage_Ljava_lang_String_;
//         }

//         static bool n_HasStyleImage_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             bool __ret = __this.HasStyleImage(p0);
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_hasStyleImage_Ljava_lang_String_;
//         public unsafe bool HasStyleImage(string p0)
//         {
//             if (id_hasStyleImage_Ljava_lang_String_ == IntPtr.Zero)
//                 id_hasStyleImage_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "hasStyleImage", "(Ljava/lang/String;)Z");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_hasStyleImage_Ljava_lang_String_, __args);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_hasStyleModel_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetHasStyleModel_Ljava_lang_String_Handler()
//         {
//             if (cb_hasStyleModel_Ljava_lang_String_ == null)
//                 cb_hasStyleModel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(n_HasStyleModel_Ljava_lang_String_));
//             return cb_hasStyleModel_Ljava_lang_String_;
//         }

//         static bool n_HasStyleModel_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             bool __ret = __this.HasStyleModel(p0);
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_hasStyleModel_Ljava_lang_String_;
//         public unsafe bool HasStyleModel(string p0)
//         {
//             if (id_hasStyleModel_Ljava_lang_String_ == IntPtr.Zero)
//                 id_hasStyleModel_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "hasStyleModel", "(Ljava/lang/String;)Z");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_hasStyleModel_Ljava_lang_String_, __args);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_invalidateStyleCustomGeometrySourceRegion_Ljava_lang_String_Lcom_mapbox_maps_CoordinateBounds_;
// #pragma warning disable 0169
//         static Delegate GetInvalidateStyleCustomGeometrySourceRegion_Ljava_lang_String_Lcom_mapbox_maps_CoordinateBounds_Handler()
//         {
//             if (cb_invalidateStyleCustomGeometrySourceRegion_Ljava_lang_String_Lcom_mapbox_maps_CoordinateBounds_ == null)
//                 cb_invalidateStyleCustomGeometrySourceRegion_Ljava_lang_String_Lcom_mapbox_maps_CoordinateBounds_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_InvalidateStyleCustomGeometrySourceRegion_Ljava_lang_String_Lcom_mapbox_maps_CoordinateBounds_));
//             return cb_invalidateStyleCustomGeometrySourceRegion_Ljava_lang_String_Lcom_mapbox_maps_CoordinateBounds_;
//         }

//         static IntPtr n_InvalidateStyleCustomGeometrySourceRegion_Ljava_lang_String_Lcom_mapbox_maps_CoordinateBounds_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.CoordinateBounds>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.InvalidateStyleCustomGeometrySourceRegion(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_invalidateStyleCustomGeometrySourceRegion_Ljava_lang_String_Lcom_mapbox_maps_CoordinateBounds_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected InvalidateStyleCustomGeometrySourceRegion(string p0, global::Com.Mapbox.Maps.CoordinateBounds p1)
//         {
//             if (id_invalidateStyleCustomGeometrySourceRegion_Ljava_lang_String_Lcom_mapbox_maps_CoordinateBounds_ == IntPtr.Zero)
//                 id_invalidateStyleCustomGeometrySourceRegion_Ljava_lang_String_Lcom_mapbox_maps_CoordinateBounds_ = JNIEnv.GetMethodID(class_ref, "invalidateStyleCustomGeometrySourceRegion", "(Ljava/lang/String;Lcom/mapbox/maps/CoordinateBounds;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invalidateStyleCustomGeometrySourceRegion_Ljava_lang_String_Lcom_mapbox_maps_CoordinateBounds_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_invalidateStyleCustomGeometrySourceTile_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_;
// #pragma warning disable 0169
//         static Delegate GetInvalidateStyleCustomGeometrySourceTile_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_Handler()
//         {
//             if (cb_invalidateStyleCustomGeometrySourceTile_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_ == null)
//                 cb_invalidateStyleCustomGeometrySourceTile_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_InvalidateStyleCustomGeometrySourceTile_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_));
//             return cb_invalidateStyleCustomGeometrySourceTile_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_;
//         }

//         static IntPtr n_InvalidateStyleCustomGeometrySourceTile_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.CanonicalTileID>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.InvalidateStyleCustomGeometrySourceTile(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_invalidateStyleCustomGeometrySourceTile_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected InvalidateStyleCustomGeometrySourceTile(string p0, global::Com.Mapbox.Maps.CanonicalTileID p1)
//         {
//             if (id_invalidateStyleCustomGeometrySourceTile_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_ == IntPtr.Zero)
//                 id_invalidateStyleCustomGeometrySourceTile_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_ = JNIEnv.GetMethodID(class_ref, "invalidateStyleCustomGeometrySourceTile", "(Ljava/lang/String;Lcom/mapbox/maps/CanonicalTileID;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invalidateStyleCustomGeometrySourceTile_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_isStyleLayerPersistent_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetIsStyleLayerPersistent_Ljava_lang_String_Handler()
//         {
//             if (cb_isStyleLayerPersistent_Ljava_lang_String_ == null)
//                 cb_isStyleLayerPersistent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_IsStyleLayerPersistent_Ljava_lang_String_));
//             return cb_isStyleLayerPersistent_Ljava_lang_String_;
//         }

//         static IntPtr n_IsStyleLayerPersistent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.IsStyleLayerPersistent(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_isStyleLayerPersistent_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected IsStyleLayerPersistent(string p0)
//         {
//             if (id_isStyleLayerPersistent_Ljava_lang_String_ == IntPtr.Zero)
//                 id_isStyleLayerPersistent_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "isStyleLayerPersistent", "(Ljava/lang/String;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_isStyleLayerPersistent_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_moveStyleLayer_Ljava_lang_String_Lcom_mapbox_maps_LayerPosition_;
// #pragma warning disable 0169
//         static Delegate GetMoveStyleLayer_Ljava_lang_String_Lcom_mapbox_maps_LayerPosition_Handler()
//         {
//             if (cb_moveStyleLayer_Ljava_lang_String_Lcom_mapbox_maps_LayerPosition_ == null)
//                 cb_moveStyleLayer_Ljava_lang_String_Lcom_mapbox_maps_LayerPosition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_MoveStyleLayer_Ljava_lang_String_Lcom_mapbox_maps_LayerPosition_));
//             return cb_moveStyleLayer_Ljava_lang_String_Lcom_mapbox_maps_LayerPosition_;
//         }

//         static IntPtr n_MoveStyleLayer_Ljava_lang_String_Lcom_mapbox_maps_LayerPosition_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.LayerPosition>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.MoveStyleLayer(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_moveStyleLayer_Ljava_lang_String_Lcom_mapbox_maps_LayerPosition_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected MoveStyleLayer(string p0, global::Com.Mapbox.Maps.LayerPosition p1)
//         {
//             if (id_moveStyleLayer_Ljava_lang_String_Lcom_mapbox_maps_LayerPosition_ == IntPtr.Zero)
//                 id_moveStyleLayer_Ljava_lang_String_Lcom_mapbox_maps_LayerPosition_ = JNIEnv.GetMethodID(class_ref, "moveStyleLayer", "(Ljava/lang/String;Lcom/mapbox/maps/LayerPosition;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_moveStyleLayer_Ljava_lang_String_Lcom_mapbox_maps_LayerPosition_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_removeStyleImage_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetRemoveStyleImage_Ljava_lang_String_Handler()
//         {
//             if (cb_removeStyleImage_Ljava_lang_String_ == null)
//                 cb_removeStyleImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_RemoveStyleImage_Ljava_lang_String_));
//             return cb_removeStyleImage_Ljava_lang_String_;
//         }

//         static IntPtr n_RemoveStyleImage_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.RemoveStyleImage(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_removeStyleImage_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected RemoveStyleImage(string p0)
//         {
//             if (id_removeStyleImage_Ljava_lang_String_ == IntPtr.Zero)
//                 id_removeStyleImage_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "removeStyleImage", "(Ljava/lang/String;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_removeStyleImage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_removeStyleLayer_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetRemoveStyleLayer_Ljava_lang_String_Handler()
//         {
//             if (cb_removeStyleLayer_Ljava_lang_String_ == null)
//                 cb_removeStyleLayer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_RemoveStyleLayer_Ljava_lang_String_));
//             return cb_removeStyleLayer_Ljava_lang_String_;
//         }

//         static IntPtr n_RemoveStyleLayer_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.RemoveStyleLayer(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_removeStyleLayer_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected RemoveStyleLayer(string p0)
//         {
//             if (id_removeStyleLayer_Ljava_lang_String_ == IntPtr.Zero)
//                 id_removeStyleLayer_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "removeStyleLayer", "(Ljava/lang/String;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_removeStyleLayer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_removeStyleModel_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetRemoveStyleModel_Ljava_lang_String_Handler()
//         {
//             if (cb_removeStyleModel_Ljava_lang_String_ == null)
//                 cb_removeStyleModel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_RemoveStyleModel_Ljava_lang_String_));
//             return cb_removeStyleModel_Ljava_lang_String_;
//         }

//         static IntPtr n_RemoveStyleModel_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.RemoveStyleModel(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_removeStyleModel_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected RemoveStyleModel(string p0)
//         {
//             if (id_removeStyleModel_Ljava_lang_String_ == IntPtr.Zero)
//                 id_removeStyleModel_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "removeStyleModel", "(Ljava/lang/String;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_removeStyleModel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_removeStyleSource_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetRemoveStyleSource_Ljava_lang_String_Handler()
//         {
//             if (cb_removeStyleSource_Ljava_lang_String_ == null)
//                 cb_removeStyleSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_RemoveStyleSource_Ljava_lang_String_));
//             return cb_removeStyleSource_Ljava_lang_String_;
//         }

//         static IntPtr n_RemoveStyleSource_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.RemoveStyleSource(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_removeStyleSource_Ljava_lang_String_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected RemoveStyleSource(string p0)
//         {
//             if (id_removeStyleSource_Ljava_lang_String_ == IntPtr.Zero)
//                 id_removeStyleSource_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "removeStyleSource", "(Ljava/lang/String;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_removeStyleSource_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_setStyleAtmosphere_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleAtmosphere_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleAtmosphere_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleAtmosphere_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_SetStyleAtmosphere_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleAtmosphere_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleAtmosphere_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleAtmosphere(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleAtmosphere_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleAtmosphere(global::Com.Mapbox.Bindgen.Value p0)
//         {
//             if (id_setStyleAtmosphere_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleAtmosphere_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleAtmosphere", "(Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleAtmosphere_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             return __ret;
//         }

//         static Delegate cb_setStyleAtmosphereProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleAtmosphereProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleAtmosphereProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleAtmosphereProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_SetStyleAtmosphereProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleAtmosphereProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleAtmosphereProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleAtmosphereProperty(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleAtmosphereProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleAtmosphereProperty(string p0, global::Com.Mapbox.Bindgen.Value p1)
//         {
//             if (id_setStyleAtmosphereProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleAtmosphereProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleAtmosphereProperty", "(Ljava/lang/String;Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleAtmosphereProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_setStyleCustomGeometrySourceTileData_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_LSystem_Collections_Generic_IList_1_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleCustomGeometrySourceTileData_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_LSystem_Collections_Generic_IList_1_Handler()
//         {
//             if (cb_setStyleCustomGeometrySourceTileData_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_LSystem_Collections_Generic_IList_1_ == null)
//                 cb_setStyleCustomGeometrySourceTileData_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_LSystem_Collections_Generic_IList_1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(n_SetStyleCustomGeometrySourceTileData_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_LSystem_Collections_Generic_IList_1_));
//             return cb_setStyleCustomGeometrySourceTileData_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_LSystem_Collections_Generic_IList_1_;
//         }

//         static IntPtr n_SetStyleCustomGeometrySourceTileData_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_LSystem_Collections_Generic_IList_1_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.CanonicalTileID>(native_p1, JniHandleOwnership.DoNotTransfer);
//             var p2 = global::Android.Runtime.JavaList<Com.Mapbox.Geojson.Feature>.FromJniHandle(native_p2, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleCustomGeometrySourceTileData(p0, p1, p2));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleCustomGeometrySourceTileData_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_LSystem_Collections_Generic_IList_1_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleCustomGeometrySourceTileData(string p0, global::Com.Mapbox.Maps.CanonicalTileID p1, global::System.Collections.Generic.IList<Com.Mapbox.Geojson.Feature> p2)
//         {
//             if (id_setStyleCustomGeometrySourceTileData_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_LSystem_Collections_Generic_IList_1_ == IntPtr.Zero)
//                 id_setStyleCustomGeometrySourceTileData_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_LSystem_Collections_Generic_IList_1_ = JNIEnv.GetMethodID(class_ref, "setStyleCustomGeometrySourceTileData", "(Ljava/lang/String;Lcom/mapbox/maps/CanonicalTileID;LSystem/Collections/Generic/IList`1;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[3];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             __args[2] = new JValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleCustomGeometrySourceTileData_Ljava_lang_String_Lcom_mapbox_maps_CanonicalTileID_LSystem_Collections_Generic_IList_1_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_setStyleGeoJSONSourceData_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_;
// #pragma warning disable 0169
//         [global::System.Obsolete]
//         static Delegate GetSetStyleGeoJSONSourceData_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_Handler()
//         {
//             if (cb_setStyleGeoJSONSourceData_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_ == null)
//                 cb_setStyleGeoJSONSourceData_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_SetStyleGeoJSONSourceData_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_));
//             return cb_setStyleGeoJSONSourceData_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_;
//         }

//         [global::System.Obsolete]
//         static IntPtr n_SetStyleGeoJSONSourceData_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.GeoJSONSourceData>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleGeoJSONSourceData(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleGeoJSONSourceData_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleGeoJSONSourceData(string p0, global::Com.Mapbox.Maps.GeoJSONSourceData p1)
//         {
//             if (id_setStyleGeoJSONSourceData_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_ == IntPtr.Zero)
//                 id_setStyleGeoJSONSourceData_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_ = JNIEnv.GetMethodID(class_ref, "setStyleGeoJSONSourceData", "(Ljava/lang/String;Lcom/mapbox/maps/GeoJSONSourceData;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleGeoJSONSourceData_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_setStyleGeoJSONSourceData_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleGeoJSONSourceData_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_Handler()
//         {
//             if (cb_setStyleGeoJSONSourceData_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_ == null)
//                 cb_setStyleGeoJSONSourceData_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(n_SetStyleGeoJSONSourceData_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_));
//             return cb_setStyleGeoJSONSourceData_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_;
//         }

//         static IntPtr n_SetStyleGeoJSONSourceData_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
//             var p2 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.GeoJSONSourceData>(native_p2, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleGeoJSONSourceData(p0, p1, p2));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleGeoJSONSourceData_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleGeoJSONSourceData(string p0, string p1, global::Com.Mapbox.Maps.GeoJSONSourceData p2)
//         {
//             if (id_setStyleGeoJSONSourceData_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_ == IntPtr.Zero)
//                 id_setStyleGeoJSONSourceData_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_ = JNIEnv.GetMethodID(class_ref, "setStyleGeoJSONSourceData", "(Ljava/lang/String;Ljava/lang/String;Lcom/mapbox/maps/GeoJSONSourceData;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             IntPtr native_p1 = JNIEnv.NewString((string)p1);
//             JValue* __args = stackalloc JValue[3];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue(native_p1);
//             __args[2] = new JValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleGeoJSONSourceData_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_maps_GeoJSONSourceData_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             JNIEnv.DeleteLocalRef(native_p1);
//             return __ret;
//         }

//         static Delegate cb_setStyleLayerProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleLayerProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleLayerProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleLayerProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_SetStyleLayerProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleLayerProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleLayerProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleLayerProperties(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleLayerProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleLayerProperties(string p0, global::Com.Mapbox.Bindgen.Value p1)
//         {
//             if (id_setStyleLayerProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleLayerProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleLayerProperties", "(Ljava/lang/String;Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleLayerProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_setStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(n_SetStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
//             var p2 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p2, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleLayerProperty(p0, p1, p2));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleLayerProperty(string p0, string p1, global::Com.Mapbox.Bindgen.Value p2)
//         {
//             if (id_setStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleLayerProperty", "(Ljava/lang/String;Ljava/lang/String;Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             IntPtr native_p1 = JNIEnv.NewString((string)p1);
//             JValue* __args = stackalloc JValue[3];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue(native_p1);
//             __args[2] = new JValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleLayerProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             JNIEnv.DeleteLocalRef(native_p1);
//             return __ret;
//         }

//         static Delegate cb_setStyleLight_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleLight_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleLight_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleLight_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_SetStyleLight_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleLight_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleLight_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleLight(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleLight_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleLight(global::Com.Mapbox.Bindgen.Value p0)
//         {
//             if (id_setStyleLight_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleLight_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleLight", "(Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleLight_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             return __ret;
//         }

//         static Delegate cb_setStyleLightProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleLightProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleLightProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleLightProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_SetStyleLightProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleLightProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleLightProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleLightProperty(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleLightProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleLightProperty(string p0, global::Com.Mapbox.Bindgen.Value p1)
//         {
//             if (id_setStyleLightProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleLightProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleLightProperty", "(Ljava/lang/String;Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleLightProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_setStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(n_SetStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
//             var p2 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p2, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleLightProperty(p0, p1, p2));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleLightProperty(string p0, string p1, global::Com.Mapbox.Bindgen.Value p2)
//         {
//             if (id_setStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleLightProperty", "(Ljava/lang/String;Ljava/lang/String;Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             IntPtr native_p1 = JNIEnv.NewString((string)p1);
//             JValue* __args = stackalloc JValue[3];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue(native_p1);
//             __args[2] = new JValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleLightProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             JNIEnv.DeleteLocalRef(native_p1);
//             return __ret;
//         }

//         static Delegate cb_setStyleLights_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleLights_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleLights_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleLights_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_SetStyleLights_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleLights_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleLights_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleLights(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleLights_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleLights(global::Com.Mapbox.Bindgen.Value p0)
//         {
//             if (id_setStyleLights_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleLights_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleLights", "(Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleLights_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             return __ret;
//         }

//         static Delegate cb_setStyleProjection_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleProjection_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleProjection_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleProjection_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_SetStyleProjection_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleProjection_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleProjection_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleProjection(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleProjection_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleProjection(global::Com.Mapbox.Bindgen.Value p0)
//         {
//             if (id_setStyleProjection_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleProjection_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleProjection", "(Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleProjection_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             return __ret;
//         }

//         static Delegate cb_setStyleProjectionProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleProjectionProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleProjectionProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleProjectionProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_SetStyleProjectionProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleProjectionProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleProjectionProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleProjectionProperty(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleProjectionProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleProjectionProperty(string p0, global::Com.Mapbox.Bindgen.Value p1)
//         {
//             if (id_setStyleProjectionProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleProjectionProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleProjectionProperty", "(Ljava/lang/String;Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleProjectionProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_setStyleSourceProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleSourceProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleSourceProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleSourceProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_SetStyleSourceProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleSourceProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleSourceProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleSourceProperties(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleSourceProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleSourceProperties(string p0, global::Com.Mapbox.Bindgen.Value p1)
//         {
//             if (id_setStyleSourceProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleSourceProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleSourceProperties", "(Ljava/lang/String;Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleSourceProperties_Ljava_lang_String_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_setStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(n_SetStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
//             var p2 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p2, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleSourceProperty(p0, p1, p2));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleSourceProperty(string p0, string p1, global::Com.Mapbox.Bindgen.Value p2)
//         {
//             if (id_setStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleSourceProperty", "(Ljava/lang/String;Ljava/lang/String;Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             IntPtr native_p1 = JNIEnv.NewString((string)p1);
//             JValue* __args = stackalloc JValue[3];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue(native_p1);
//             __args[2] = new JValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleSourceProperty_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             JNIEnv.DeleteLocalRef(native_p1);
//             return __ret;
//         }

//         static Delegate cb_setStyleTerrain_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleTerrain_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleTerrain_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleTerrain_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_SetStyleTerrain_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleTerrain_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleTerrain_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p0, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleTerrain(p0));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleTerrain_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleTerrain(global::Com.Mapbox.Bindgen.Value p0)
//         {
//             if (id_setStyleTerrain_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleTerrain_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleTerrain", "(Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleTerrain_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             return __ret;
//         }

//         static Delegate cb_setStyleTerrainProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
// #pragma warning disable 0169
//         static Delegate GetSetStyleTerrainProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_Handler()
//         {
//             if (cb_setStyleTerrainProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == null)
//                 cb_setStyleTerrainProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_SetStyleTerrainProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_));
//             return cb_setStyleTerrainProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         }

//         static IntPtr n_SetStyleTerrainProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetStyleTerrainProperty(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_setStyleTerrainProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected SetStyleTerrainProperty(string p0, global::Com.Mapbox.Bindgen.Value p1)
//         {
//             if (id_setStyleTerrainProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ == IntPtr.Zero)
//                 id_setStyleTerrainProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_ = JNIEnv.GetMethodID(class_ref, "setStyleTerrainProperty", "(Ljava/lang/String;Lcom/mapbox/bindgen/Value;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setStyleTerrainProperty_Ljava_lang_String_Lcom_mapbox_bindgen_Value_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_styleLayerExists_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetStyleLayerExists_Ljava_lang_String_Handler()
//         {
//             if (cb_styleLayerExists_Ljava_lang_String_ == null)
//                 cb_styleLayerExists_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(n_StyleLayerExists_Ljava_lang_String_));
//             return cb_styleLayerExists_Ljava_lang_String_;
//         }

//         static bool n_StyleLayerExists_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             bool __ret = __this.StyleLayerExists(p0);
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_styleLayerExists_Ljava_lang_String_;
//         public unsafe bool StyleLayerExists(string p0)
//         {
//             if (id_styleLayerExists_Ljava_lang_String_ == IntPtr.Zero)
//                 id_styleLayerExists_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "styleLayerExists", "(Ljava/lang/String;)Z");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_styleLayerExists_Ljava_lang_String_, __args);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_styleSourceExists_Ljava_lang_String_;
// #pragma warning disable 0169
//         static Delegate GetStyleSourceExists_Ljava_lang_String_Handler()
//         {
//             if (cb_styleSourceExists_Ljava_lang_String_ == null)
//                 cb_styleSourceExists_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(n_StyleSourceExists_Ljava_lang_String_));
//             return cb_styleSourceExists_Ljava_lang_String_;
//         }

//         static bool n_StyleSourceExists_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             bool __ret = __this.StyleSourceExists(p0);
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_styleSourceExists_Ljava_lang_String_;
//         public unsafe bool StyleSourceExists(string p0)
//         {
//             if (id_styleSourceExists_Ljava_lang_String_ == IntPtr.Zero)
//                 id_styleSourceExists_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "styleSourceExists", "(Ljava/lang/String;)Z");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue(native_p0);
//             var __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_styleSourceExists_Ljava_lang_String_, __args);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_updateStyleImageSourceImage_Ljava_lang_String_Lcom_mapbox_maps_Image_;
// #pragma warning disable 0169
//         static Delegate GetUpdateStyleImageSourceImage_Ljava_lang_String_Lcom_mapbox_maps_Image_Handler()
//         {
//             if (cb_updateStyleImageSourceImage_Ljava_lang_String_Lcom_mapbox_maps_Image_ == null)
//                 cb_updateStyleImageSourceImage_Ljava_lang_String_Lcom_mapbox_maps_Image_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_UpdateStyleImageSourceImage_Ljava_lang_String_Lcom_mapbox_maps_Image_));
//             return cb_updateStyleImageSourceImage_Ljava_lang_String_Lcom_mapbox_maps_Image_;
//         }

//         static IntPtr n_UpdateStyleImageSourceImage_Ljava_lang_String_Lcom_mapbox_maps_Image_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Image>(native_p1, JniHandleOwnership.DoNotTransfer);
//             IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.UpdateStyleImageSourceImage(p0, p1));
//             return __ret;
//         }
// #pragma warning restore 0169

//         IntPtr id_updateStyleImageSourceImage_Ljava_lang_String_Lcom_mapbox_maps_Image_;
//         public unsafe global::Com.Mapbox.Bindgen.Expected UpdateStyleImageSourceImage(string p0, global::Com.Mapbox.Maps.Image p1)
//         {
//             if (id_updateStyleImageSourceImage_Ljava_lang_String_Lcom_mapbox_maps_Image_ == IntPtr.Zero)
//                 id_updateStyleImageSourceImage_Ljava_lang_String_Lcom_mapbox_maps_Image_ = JNIEnv.GetMethodID(class_ref, "updateStyleImageSourceImage", "(Ljava/lang/String;Lcom/mapbox/maps/Image;)Lcom/mapbox/bindgen/Expected;");
//             IntPtr native_p0 = JNIEnv.NewString((string)p0);
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue(native_p0);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             var __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Expected>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_updateStyleImageSourceImage_Ljava_lang_String_Lcom_mapbox_maps_Image_, __args), JniHandleOwnership.TransferLocalRef);
//             JNIEnv.DeleteLocalRef(native_p0);
//             return __ret;
//         }

//         static Delegate cb_subscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_;
// #pragma warning disable 0169
//         static Delegate GetSubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_Handler()
//         {
//             if (cb_subscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_ == null)
//                 cb_subscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(n_Subscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_));
//             return cb_subscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_;
//         }

//         static void n_Subscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = (global::Com.Mapbox.Maps.IObserver)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.IObserver>(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
//             __this.Subscribe(p0, p1);
//         }
// #pragma warning restore 0169

//         IntPtr id_subscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_;
//         public unsafe void Subscribe(global::Com.Mapbox.Maps.IObserver p0, global::System.Collections.Generic.IList<string> p1)
//         {
//             if (id_subscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_ == IntPtr.Zero)
//                 id_subscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_ = JNIEnv.GetMethodID(class_ref, "subscribe", "(Lcom/mapbox/maps/Observer;LSystem/Collections/Generic/IList`1;)V");
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_subscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_, __args);
//         }

//         static Delegate cb_unsubscribe_Lcom_mapbox_maps_Observer_;
// #pragma warning disable 0169
//         static Delegate GetUnsubscribe_Lcom_mapbox_maps_Observer_Handler()
//         {
//             if (cb_unsubscribe_Lcom_mapbox_maps_Observer_ == null)
//                 cb_unsubscribe_Lcom_mapbox_maps_Observer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(n_Unsubscribe_Lcom_mapbox_maps_Observer_));
//             return cb_unsubscribe_Lcom_mapbox_maps_Observer_;
//         }

//         static void n_Unsubscribe_Lcom_mapbox_maps_Observer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = (global::Com.Mapbox.Maps.IObserver)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.IObserver>(native_p0, JniHandleOwnership.DoNotTransfer);
//             __this.Unsubscribe(p0);
//         }
// #pragma warning restore 0169

//         IntPtr id_unsubscribe_Lcom_mapbox_maps_Observer_;
//         public unsafe void Unsubscribe(global::Com.Mapbox.Maps.IObserver p0)
//         {
//             if (id_unsubscribe_Lcom_mapbox_maps_Observer_ == IntPtr.Zero)
//                 id_unsubscribe_Lcom_mapbox_maps_Observer_ = JNIEnv.GetMethodID(class_ref, "unsubscribe", "(Lcom/mapbox/maps/Observer;)V");
//             JValue* __args = stackalloc JValue[1];
//             __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
//             JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_unsubscribe_Lcom_mapbox_maps_Observer_, __args);
//         }

//         static Delegate cb_unsubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_;
// #pragma warning disable 0169
//         static Delegate GetUnsubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_Handler()
//         {
//             if (cb_unsubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_ == null)
//                 cb_unsubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(n_Unsubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_));
//             return cb_unsubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_;
//         }

//         static void n_Unsubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//         {
//             var __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.Extension.Style.IStyleInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//             var p0 = (global::Com.Mapbox.Maps.IObserver)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Maps.IObserver>(native_p0, JniHandleOwnership.DoNotTransfer);
//             var p1 = global::Android.Runtime.JavaList<String>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
//             __this.Unsubscribe(p0, p1);
//         }
// #pragma warning restore 0169

//         IntPtr id_unsubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_;
//         public unsafe void Unsubscribe(global::Com.Mapbox.Maps.IObserver p0, global::System.Collections.Generic.IList<String> p1)
//         {
//             if (id_unsubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_ == IntPtr.Zero)
//                 id_unsubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_ = JNIEnv.GetMethodID(class_ref, "unsubscribe", "(Lcom/mapbox/maps/Observer;LSystem/Collections/Generic/IList`1;)V");
//             JValue* __args = stackalloc JValue[2];
//             __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
//             __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
//             JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_unsubscribe_Lcom_mapbox_maps_Observer_LSystem_Collections_Generic_IList_1_, __args);
//         }
//     }
// }

namespace Com.Mapbox.Maps.Plugins.Attributions.Generated
{
    partial class AttributionSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}

namespace Com.Mapbox.Maps.Plugins.Compass.Generated
{
    partial class CompassSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}

namespace Com.Mapbox.Maps.Plugins.Gestures.Generated
{
    partial class GesturesSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}

namespace Com.Mapbox.Maps.Plugins.Locationcomponent.Generated
{
    partial class LocationComponentSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}
namespace Com.Mapbox.Maps.Plugins.Logo.Generated
{
    partial class LogoSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}
namespace Com.Mapbox.Maps
{
    partial class ImageHolder
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}
namespace Com.Mapbox.Maps.Plugins
{
    partial class LocationPuck2D
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}
namespace Com.Mapbox.Maps.Plugins
{
    partial class LocationPuck3D
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}
namespace Com.Mapbox.Maps.Plugins.Scalebar.Generated
{
    partial class ScaleBarSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}