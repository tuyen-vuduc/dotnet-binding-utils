using System;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
namespace Com.Google.Android.Material.Textfield
{
    partial class MaterialAutoCompleteTextView
    {

        static Delegate? cb_setAdapter_Landroid_widget_ListAdapter_;
#pragma warning disable 0169
        static Delegate GetSetAdapter_Landroid_widget_ListAdapter_Handler()
        {
            if (cb_setAdapter_Landroid_widget_ListAdapter_ == null)
                cb_setAdapter_Landroid_widget_ListAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(n_SetAdapter_Landroid_widget_ListAdapter_));
            return cb_setAdapter_Landroid_widget_ListAdapter_;
        }

        static void n_SetAdapter_Landroid_widget_ListAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Material.Textfield.MaterialAutoCompleteTextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var adapter = global::Java.Lang.Object.GetObject<global::Android.Widget.IListAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
            __this.Adapter = (adapter);
        }
#pragma warning restore 0169

        public override unsafe global::Android.Widget.IListAdapter? Adapter
        {
            get => base.Adapter;
            // Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.material.textfield']/class[@name='MaterialAutoCompleteTextView']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='T']]"
            [Register("setAdapter", "(Landroid/widget/ListAdapter;)V", "GetSetAdapter_Landroid_widget_ListAdapter_Handler")]
            [global::Java.Interop.JavaTypeParameters(new string[] { "T extends android.widget.ListAdapter & android.widget.Filterable" })]
            set
            {
                const string __id = "setAdapter.(Landroid/widget/ListAdapter;)V";
                IntPtr native_adapter = JNIEnv.ToLocalJniHandle(value);
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue(native_adapter);
                    _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_adapter);
                    global::System.GC.KeepAlive(value);
                }
            }
        }
    }
}
namespace Com.Google.Android.Material.Snackbar
{
    partial class Snackbar
    {
        partial class SnackbarLayout
        {
            public override unsafe global::Android.Graphics.Drawables.Drawable? Background
            {
                get => base.Background;
                // Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.material.snackbar']/class[@name='Snackbar.SnackbarLayout']/method[@name='setBackground' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
                [Register("setBackground", "(Landroid/graphics/drawable/Drawable;)V", "")]
                set
                {
                    const string __id = "setBackground.(Landroid/graphics/drawable/Drawable;)V";
                    try
                    {
                        JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                        __args[0] = new JniArgumentValue((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object)value).Handle);
                        _members.InstanceMethods.InvokeAbstractVoidMethod(__id, this, __args);
                    }
                    finally
                    {
                        global::System.GC.KeepAlive(value);
                    }
                }
            }

            public override unsafe global::Android.Content.Res.ColorStateList? BackgroundTintList
            {
                get => base.BackgroundTintList;

                // Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.material.snackbar']/class[@name='Snackbar.SnackbarLayout']/method[@name='setBackgroundTintList' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
                [Register("setBackgroundTintList", "(Landroid/content/res/ColorStateList;)V", "")]
                set
                {
                    const string __id = "setBackgroundTintList.(Landroid/content/res/ColorStateList;)V";
                    try
                    {
                        JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                        __args[0] = new JniArgumentValue((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object)value).Handle);
                        _members.InstanceMethods.InvokeAbstractVoidMethod(__id, this, __args);
                    }
                    finally
                    {
                        global::System.GC.KeepAlive(value);
                    }
                }
            }
            public override unsafe global::Android.Graphics.PorterDuff.Mode? BackgroundTintMode
            {
                get => base.BackgroundTintMode;
                // Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.material.snackbar']/class[@name='Snackbar.SnackbarLayout']/method[@name='setBackgroundTintMode' and count(parameter)=1 and parameter[1][@type='android.graphics.PorterDuff.Mode']]"
                [Register("setBackgroundTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "")]
                set
                {
                    const string __id = "setBackgroundTintMode.(Landroid/graphics/PorterDuff$Mode;)V";
                    try
                    {
                        JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                        __args[0] = new JniArgumentValue((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object)value).Handle);
                        _members.InstanceMethods.InvokeAbstractVoidMethod(__id, this, __args);
                    }
                    finally
                    {
                        global::System.GC.KeepAlive(value);
                    }
                }
            }

            public override unsafe global::Android.Views.ViewGroup.LayoutParams? LayoutParameters
            {
                get => base.LayoutParameters;
                // Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.material.snackbar']/class[@name='Snackbar.SnackbarLayout']/method[@name='setLayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.LayoutParams']]"
                [Register("setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
                set
                {
                    const string __id = "setLayoutParams.(Landroid/view/ViewGroup$LayoutParams;)V";
                    try
                    {
                        JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                        __args[0] = new JniArgumentValue((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object)value).Handle);
                        _members.InstanceMethods.InvokeAbstractVoidMethod(__id, this, __args);
                    }
                    finally
                    {
                        global::System.GC.KeepAlive(value);
                    }
                }
            }
        }
    }
}
namespace Com.Google.Android.Material.Tabs
{
    partial class TabLayout
    {
        partial class ViewPagerOnTabSelectedListener
        {
            void IBaseOnTabSelectedListener.OnTabReselected(global::Java.Lang.Object? p0)
                => OnTabReselected(p0 as Tab);

            void IBaseOnTabSelectedListener.OnTabSelected(global::Java.Lang.Object? p0)
                => OnTabSelected(p0 as Tab);

            void IBaseOnTabSelectedListener.OnTabUnselected(global::Java.Lang.Object? p0)
                => OnTabUnselected(p0 as Tab);
        }
    }
}
namespace Com.Google.Android.Material.Animation
{
    partial class ChildrenAlphaProperty
    {
        public override global::Java.Lang.Object? Get(global::Java.Lang.Object? source)
            => this.Get(source as global::Android.Views.ViewGroup);
    }
    partial class DrawableAlphaProperty
    {
        public override global::Java.Lang.Object? Get(global::Java.Lang.Object? source)
                => this.Get(source as global::Android.Graphics.Drawables.Drawable);
    }
    partial class ImageMatrixProperty
    {
        public override global::Java.Lang.Object? Get(global::Java.Lang.Object? source)
                => this.Get(source as global::Android.Widget.ImageView);
    }
}
namespace Com.Google.Android.Material.Circularreveal
{
    partial interface ICircularRevealWidget
    {
        partial class CircularRevealProperty
        {
            public override global::Java.Lang.Object? Get(global::Java.Lang.Object? source)
                => this.Get(source as global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget);
        }
    }
    partial interface ICircularRevealWidget
    {
        partial class CircularRevealScrimColorProperty
        {
            public override global::Java.Lang.Object? Get(global::Java.Lang.Object? source)
                => this.Get(source as global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget);
        }
    }
}

namespace Com.Google.Android.Material.Animation
{
    partial class ArgbEvaluatorCompat
    {
        Java.Lang.Object? global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object? startValue, Java.Lang.Object? endValue)
            => Evaluate(fraction, startValue as Java.Lang.Integer, endValue as Java.Lang.Integer);
    }
}
namespace Com.Google.Android.Material.Animation
{
    partial class MatrixEvaluator
    {
        Java.Lang.Object? global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object? startValue, Java.Lang.Object? endValue)
    => this.Evaluate(fraction, startValue as global::Android.Graphics.Matrix, endValue as global::Android.Graphics.Matrix);
    }
}
namespace Com.Google.Android.Material.Circularreveal
{
    partial interface ICircularRevealWidget
    {
        partial class CircularRevealEvaluator
        {
            Java.Lang.Object? global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object? startValue, Java.Lang.Object? endValue)
                => this.Evaluate(fraction, startValue as global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo, endValue as global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo);
        }
    }
}
namespace Com.Google.Android.Material.Internal
{
    partial class RectEvaluator
    {
        Java.Lang.Object? global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object? startValue, Java.Lang.Object? endValue)
            => this.Evaluate(fraction, startValue as global::Android.Graphics.Rect, endValue as global::Android.Graphics.Rect);
    }
}

namespace Com.Google.Android.Material.Bottomappbar
{
    partial class BottomAppBar
    {
        global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.Behavior global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.IAttachedBehavior.GetBehavior()
            => GetBehavior();
    }
}
namespace Com.Google.Android.Material.Floatingactionbutton
{
    partial class ExtendedFloatingActionButton
    {
        global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.Behavior global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.IAttachedBehavior.GetBehavior()
            => Behavior;
    }
}
namespace Com.Google.Android.Material.Button
{
    partial class MaterialButton
    {
        partial class InspectionCompanion
        {
            void global::Android.Views.Inspectors.IInspectionCompanion.ReadProperties(global::Java.Lang.Object inspectable, global::Android.Views.Inspectors.IPropertyReader propertyReader)
                => ReadProperties(inspectable as MaterialButton, propertyReader);
        }
    }
}
namespace Com.Google.Android.Material.Circularreveal.Cardview
{
    partial class CircularRevealCardView
    {
        global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.GetRevealInfo()
          => RevealInfo;
        void Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.SetRevealInfo(global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? arg)
            => RevealInfo = arg;
    }
}
namespace Com.Google.Android.Material.Circularreveal
{
    partial class CircularRevealFrameLayout
    {
        global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.GetRevealInfo()
          => RevealInfo;
        void Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.SetRevealInfo(global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? arg)
            => RevealInfo = arg;
    }
    partial class CircularRevealGridLayout
    {
        global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.GetRevealInfo()
          => RevealInfo;
        void Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.SetRevealInfo(global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? arg)
            => RevealInfo = arg;
    }
    partial class CircularRevealLinearLayout
    {
        global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.GetRevealInfo()
          => RevealInfo;
        void Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.SetRevealInfo(global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? arg)
            => RevealInfo = arg;
    }
    partial class CircularRevealRelativeLayout
    {
        global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.GetRevealInfo()
          => RevealInfo;
        void Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.SetRevealInfo(global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? arg)
            => RevealInfo = arg;
    }
}
namespace Com.Google.Android.Material.Circularreveal.Coordinatorlayout
{
    partial class CircularRevealCoordinatorLayout
    {
        global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.GetRevealInfo()
          => RevealInfo;
        void Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.SetRevealInfo(global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? arg)
            => RevealInfo = arg;
    }
}
namespace Com.Google.Android.Material.Internal
{
    partial class NavigationMenuItemView
    {
        void global::AndroidX.AppCompat.View.Menu.IMenuViewItemView.SetEnabled(bool p0)
            => Enabled = p0;
    }
}
namespace Com.Google.Android.Material.Navigation
{
    partial class NavigationBarItemView
    {
        void global::AndroidX.AppCompat.View.Menu.IMenuViewItemView.SetEnabled(bool p0)
            => Enabled = p0;
    }
}
namespace Com.Google.Android.Material.Slider
{
    partial class RangeSlider
    {
        static Delegate? cb_setEnabled_Z;
#pragma warning disable 0169
        static Delegate GetSetEnabled_ZHandler()
        {
            if (cb_setEnabled_Z == null)
                cb_setEnabled_Z = JNINativeWrapper.CreateDelegate((_JniMarshal_PPZ_V)n_SetEnabled_Z);
            return cb_setEnabled_Z;
        }

        static void n_SetEnabled_Z(IntPtr jnienv, IntPtr native__this, bool p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Material.Slider.RangeSlider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            __this.Enabled = (p0);
        }
#pragma warning restore 0169

        public override unsafe bool Enabled
        {
            get => base.Enabled;

            // Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.material.slider']/class[@name='RangeSlider']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
            [Register("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
            set
            {
                const string __id = "setEnabled.(Z)V";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue(value);
                    _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
                }
                finally
                {
                }
            }
        }
    }

    partial class Slider
    {
        static Delegate? cb_setEnabled_Z;
#pragma warning disable 0169
        static Delegate GetSetEnabled_ZHandler()
        {
            if (cb_setEnabled_Z == null)
                cb_setEnabled_Z = JNINativeWrapper.CreateDelegate((_JniMarshal_PPZ_V)n_SetEnabled_Z);
            return cb_setEnabled_Z;
        }

        static void n_SetEnabled_Z(IntPtr jnienv, IntPtr native__this, bool p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Material.Slider.Slider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            __this.Enabled = (p0);
        }
#pragma warning restore 0169

        public override unsafe bool Enabled
        {
            get => base.Enabled;
            // Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.material.slider']/class[@name='Slider']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
            [Register("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
            set
            {
                const string __id = "setEnabled.(Z)V";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue(value);
                    _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
                }
                finally
                {
                }
            }
        }
    }
}

namespace Com.Google.Android.Material.Navigationrail
{
    partial class NavigationRailView
    {
        protected override global::Com.Google.Android.Material.Navigation.NavigationBarMenuView CreateNavigationBarMenuView(global::Android.Content.Context p0)
            => CreateNavigationBarMenuViewX(p0);
    }
}