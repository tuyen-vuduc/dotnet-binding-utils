using System;
namespace Xamarin.Build.Download
{
	public static class ErrorCodes
	{
		public const string GradleBuildFailed = "XABG001";
		public const string ExtractionFailed = "XABG002";
		public const string DirectoryDeleteFailed = "XABG003";
		public const string DirectoryCreateFailed = "XABG004";
        public const string GradleAssetsFileMissing = "XABG005";
		public const string ExclusiveLockTimeout = "XABG006";
    }
}
