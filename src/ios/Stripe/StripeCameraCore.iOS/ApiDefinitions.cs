using Foundation;
using ObjCRuntime;
using UIKit;

namespace StripeCameraCore
{
	// @interface CameraPreviewView : UIView
	[BaseType (typeof(UIView), Name = "_TtC16StripeCameraCore17CameraPreviewView")]
	interface CameraPreviewView
	{
		// @property (readonly, nonatomic, class) Class _Nonnull layerClass;
		[Static]
		[Export ("layerClass")]
		Class LayerClass { get; }
	}
}
