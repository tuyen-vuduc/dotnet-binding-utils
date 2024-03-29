using ObjCRuntime;

namespace Shake
{
	[Native]
	public enum LogLevel : ulong
	{
		Verbose,
		Debug,
		Info,
		Warn,
		Error
	}

	[Native]
	public enum SHKShowOption : ulong
	{
		Home = 1,
		New,
		NewChat
	}
}
