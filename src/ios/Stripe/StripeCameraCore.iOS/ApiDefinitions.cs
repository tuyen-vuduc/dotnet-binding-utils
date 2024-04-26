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

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double StripeCameraCoreVersionNumber;
		[Field ("StripeCameraCoreVersionNumber", "__Internal")]
		double StripeCameraCoreVersionNumber { get; }

		// extern const unsigned char[] StripeCameraCoreVersionString;
		[Field ("StripeCameraCoreVersionString", "__Internal")]
		byte[] StripeCameraCoreVersionString { get; }
	}
}
