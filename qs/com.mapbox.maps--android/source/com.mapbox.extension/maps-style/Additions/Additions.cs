using Android.Runtime;

namespace Com.Mapbox.Maps.Extension.Style.Layers.Properties
{
    using System;
    using System.Collections.Generic;
    using Java.Interop;

    partial class PropertyValue
    {
        [Register("getValue", "()Lcom/mapbox/bindgen/Value;", "")]
        public unsafe global::Com.Mapbox.Bindgen.Value GetBindGenValue()
        {
            const string __id = "getValue.()Lcom/mapbox/bindgen/Value;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        [Register("getValue", "()Ljava/lang/Object;", "")]
        public unsafe global::Java.Lang.Object GetValue()
        {
            const string __id = "getValue.()Ljava/lang/Object;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
                return (global::Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }
}
namespace Com.Mapbox.Maps.Extension.Style
{
    using System.Collections.Generic;
    using System.Linq;
    using Com.Mapbox.Maps;
    using Kotlin;

    partial class StyleExtensionImpl : global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleExtension
    {
        public IStyleContract.IStyleAtmosphereExtension Atmosphere => GetAtmosphere();

        public IList<IStyleContract.IStyleImageExtension> Images => GetImages();

        public IList<Pair> Layers => GetLayers();

        public IStyleContract.IStyleProjectionExtension Projection => GetProjection();

        public IList<IStyleContract.IStyleSourceExtension> Sources => GetSources()
            .Cast<IStyleContract.IStyleSourceExtension>()
            .ToArray();

        public IStyleContract.IStyleTerrainExtension Terrain => GetTerrain();

        public global::System.Collections.Generic.IList<global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleModelExtension> Models => GetModels();

        public IStyleContract.IStyleLightExtension DynamicLight => GetDynamicLight();

        public IStyleContract.IStyleLightExtension FlatLight => GetFlatLight();

        public string Style => GetStyle();

        public TransitionOptions Transition => GetTransition();
    }
}

namespace Com.Mapbox.Maps.Extension.Style.Layers.Generated
{
    partial class BackgroundLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class ModelLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class HeatmapLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class CircleLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class FillExtrusionLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class HillshadeLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class FillLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class SkyLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class RasterLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class LineLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class LocationIndicatorLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class SymbolLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
}
namespace Com.Mapbox.Maps.Extension.Style.Layers
{
    partial class CustomLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
}