using System;
namespace Xamarin.Build.Download
{
	public static class ErrorCodes
	{
		public const string GradleBuildFailed = "GDL001";
		public const string ExtractionFailed = "GDL002";
		public const string DirectoryDeleteFailed = "GDL003";
		public const string DirectoryCreateFailed = "GDL004";
        public const string GradleAssetsFileMissing = "GDL005";
		public const string ExclusiveLockTimeout = "GDL006";
    }
}
