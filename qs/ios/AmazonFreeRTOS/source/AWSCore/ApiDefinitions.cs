using System;
using AWSCore;
using CoreData;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using SystemConfiguration;
using UIKit;

namespace AWSCore
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double AWSCoreVersionNumber __attribute__((deprecated("Use AWSiOSSDKVersion instead.")));
		[Field ("AWSCoreVersionNumber", "__Internal")]
		double AWSCoreVersionNumber { get; }

		// extern const unsigned char[] AWSCoreVersionString __attribute__((deprecated("Use AWSiOSSDKVersion instead.")));
		[Field ("AWSCoreVersionString", "__Internal")]
		byte[] AWSCoreVersionString { get; }
	}

	// @interface AWSDDLog : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSDDLog
	{
		// @property (readonly, nonatomic, strong, class) AWSDDLog * _Nonnull sharedInstance;
		[Static]
		[Export ("sharedInstance", ArgumentSemantic.Strong)]
		AWSDDLog SharedInstance { get; }

		// @property (assign, nonatomic) AWSDDLogLevel logLevel;
		[Export ("logLevel", ArgumentSemantic.Assign)]
		AWSDDLogLevel LogLevel { get; set; }

		// @property (readonly, nonatomic, strong, class) dispatch_queue_t _Nonnull loggingQueue;
		[Static]
		[Export ("loggingQueue", ArgumentSemantic.Strong)]
		DispatchQueue LoggingQueue { get; }

		// +(void)log:(BOOL)asynchronous level:(AWSDDLogLevel)level flag:(AWSDDLogFlag)flag context:(NSInteger)context file:(const char * _Nonnull)file function:(const char * _Nonnull)function line:(NSUInteger)line tag:(id _Nullable)tag format:(NSString * _Nonnull)format, ... __attribute__((format(NSString, 9, 10)));
		[Static, Internal]
		[Export ("log:level:flag:context:file:function:line:tag:format:", IsVariadic = true)]
		unsafe void Log (bool asynchronous, AWSDDLogLevel level, AWSDDLogFlag flag, nint context, sbyte* file, sbyte* function, nuint line, [NullAllowed] NSObject tag, string format, IntPtr varArgs);

		// -(void)log:(BOOL)asynchronous level:(AWSDDLogLevel)level flag:(AWSDDLogFlag)flag context:(NSInteger)context file:(const char * _Nonnull)file function:(const char * _Nonnull)function line:(NSUInteger)line tag:(id _Nullable)tag format:(NSString * _Nonnull)format, ... __attribute__((format(NSString, 9, 10)));
		[Internal]
		[Export ("log:level:flag:context:file:function:line:tag:format:", IsVariadic = true)]
		unsafe void Log (bool asynchronous, AWSDDLogLevel level, AWSDDLogFlag flag, nint context, sbyte* file, sbyte* function, nuint line, [NullAllowed] NSObject tag, string format, IntPtr varArgs);

		// +(void)log:(BOOL)asynchronous level:(AWSDDLogLevel)level flag:(AWSDDLogFlag)flag context:(NSInteger)context file:(const char * _Nonnull)file function:(const char * _Nonnull)function line:(NSUInteger)line tag:(id _Nullable)tag format:(NSString * _Nonnull)format args:(va_list)argList __attribute__((swift_name("log(asynchronous:level:flag:context:file:function:line:tag:format:arguments:)")));
		[Static]
		[Export ("log:level:flag:context:file:function:line:tag:format:args:")]
		unsafe void Log (bool asynchronous, AWSDDLogLevel level, AWSDDLogFlag flag, nint context, sbyte* file, sbyte* function, nuint line, [NullAllowed] NSObject tag, string format, sbyte* argList);

		// -(void)log:(BOOL)asynchronous level:(AWSDDLogLevel)level flag:(AWSDDLogFlag)flag context:(NSInteger)context file:(const char * _Nonnull)file function:(const char * _Nonnull)function line:(NSUInteger)line tag:(id _Nullable)tag format:(NSString * _Nonnull)format args:(va_list)argList __attribute__((swift_name("log(asynchronous:level:flag:context:file:function:line:tag:format:arguments:)")));
		[Export ("log:level:flag:context:file:function:line:tag:format:args:")]
		unsafe void Log (bool asynchronous, AWSDDLogLevel level, AWSDDLogFlag flag, nint context, sbyte* file, sbyte* function, nuint line, [NullAllowed] NSObject tag, string format, sbyte* argList);

		// +(void)log:(BOOL)asynchronous message:(AWSDDLogMessage * _Nonnull)logMessage __attribute__((swift_name("log(asynchronous:message:)")));
		[Static]
		[Export ("log:message:")]
		void Log (bool asynchronous, AWSDDLogMessage logMessage);

		// -(void)log:(BOOL)asynchronous message:(AWSDDLogMessage * _Nonnull)logMessage __attribute__((swift_name("log(asynchronous:message:)")));
		[Export ("log:message:")]
		void Log (bool asynchronous, AWSDDLogMessage logMessage);

		// +(void)flushLog;
		[Static]
		[Export ("flushLog")]
		void FlushLog ();

		// -(void)flushLog;
		[Export ("flushLog")]
		void FlushLog ();

		// +(void)addLogger:(id<AWSDDLogger> _Nonnull)logger;
		[Static]
		[Export ("addLogger:")]
		void AddLogger (AWSDDLogger logger);

		// -(void)addLogger:(id<AWSDDLogger> _Nonnull)logger;
		[Export ("addLogger:")]
		void AddLogger (AWSDDLogger logger);

		// +(void)addLogger:(id<AWSDDLogger> _Nonnull)logger withLevel:(AWSDDLogLevel)level;
		[Static]
		[Export ("addLogger:withLevel:")]
		void AddLogger (AWSDDLogger logger, AWSDDLogLevel level);

		// -(void)addLogger:(id<AWSDDLogger> _Nonnull)logger withLevel:(AWSDDLogLevel)level;
		[Export ("addLogger:withLevel:")]
		void AddLogger (AWSDDLogger logger, AWSDDLogLevel level);

		// +(void)removeLogger:(id<AWSDDLogger> _Nonnull)logger;
		[Static]
		[Export ("removeLogger:")]
		void RemoveLogger (AWSDDLogger logger);

		// -(void)removeLogger:(id<AWSDDLogger> _Nonnull)logger;
		[Export ("removeLogger:")]
		void RemoveLogger (AWSDDLogger logger);

		// +(void)removeAllLoggers;
		[Static]
		[Export ("removeAllLoggers")]
		void RemoveAllLoggers ();

		// -(void)removeAllLoggers;
		[Export ("removeAllLoggers")]
		void RemoveAllLoggers ();

		// @property (readonly, copy, nonatomic, class) NSArray<id<AWSDDLogger>> * _Nonnull allLoggers;
		[Static]
		[Export ("allLoggers", ArgumentSemantic.Copy)]
		AWSDDLogger[] AllLoggers { get; }

		// @property (readonly, copy, nonatomic) NSArray<id<AWSDDLogger>> * _Nonnull allLoggers;
		[Export ("allLoggers", ArgumentSemantic.Copy)]
		AWSDDLogger[] AllLoggers { get; }

		// @property (readonly, copy, nonatomic, class) NSArray<AWSDDLoggerInformation *> * _Nonnull allLoggersWithLevel;
		[Static]
		[Export ("allLoggersWithLevel", ArgumentSemantic.Copy)]
		AWSDDLoggerInformation[] AllLoggersWithLevel { get; }

		// @property (readonly, copy, nonatomic) NSArray<AWSDDLoggerInformation *> * _Nonnull allLoggersWithLevel;
		[Export ("allLoggersWithLevel", ArgumentSemantic.Copy)]
		AWSDDLoggerInformation[] AllLoggersWithLevel { get; }

		// @property (readonly, copy, nonatomic, class) NSArray<Class> * _Nonnull registeredClasses;
		[Static]
		[Export ("registeredClasses", ArgumentSemantic.Copy)]
		Class[] RegisteredClasses { get; }

		// @property (readonly, copy, nonatomic, class) NSArray<NSString *> * _Nonnull registeredClassNames;
		[Static]
		[Export ("registeredClassNames", ArgumentSemantic.Copy)]
		string[] RegisteredClassNames { get; }

		// +(AWSDDLogLevel)levelForClass:(Class _Nonnull)aClass;
		[Static]
		[Export ("levelForClass:")]
		AWSDDLogLevel LevelForClass (Class aClass);

		// +(AWSDDLogLevel)levelForClassWithName:(NSString * _Nonnull)aClassName;
		[Static]
		[Export ("levelForClassWithName:")]
		AWSDDLogLevel LevelForClassWithName (string aClassName);

		// +(void)setLevel:(AWSDDLogLevel)level forClass:(Class _Nonnull)aClass;
		[Static]
		[Export ("setLevel:forClass:")]
		void SetLevel (AWSDDLogLevel level, Class aClass);

		// +(void)setLevel:(AWSDDLogLevel)level forClassWithName:(NSString * _Nonnull)aClassName;
		[Static]
		[Export ("setLevel:forClassWithName:")]
		void SetLevel (AWSDDLogLevel level, string aClassName);
	}

	// @protocol AWSDDLogger <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface AWSDDLogger
	{
		// @required -(void)logMessage:(AWSDDLogMessage * _Nonnull)logMessage __attribute__((swift_name("log(message:)")));
		[Abstract]
		[Export ("logMessage:")]
		void LogMessage (AWSDDLogMessage logMessage);

		// @required @property (nonatomic, strong) id<AWSDDLogFormatter> _Nonnull logFormatter;
		[Abstract]
		[Export ("logFormatter", ArgumentSemantic.Strong)]
		AWSDDLogFormatter LogFormatter { get; set; }

		// @optional -(void)didAddLogger;
		[Export ("didAddLogger")]
		void DidAddLogger ();

		// @optional -(void)didAddLoggerInQueue:(dispatch_queue_t _Nonnull)queue;
		[Export ("didAddLoggerInQueue:")]
		void DidAddLoggerInQueue (DispatchQueue queue);

		// @optional -(void)willRemoveLogger;
		[Export ("willRemoveLogger")]
		void WillRemoveLogger ();

		// @optional -(void)flush;
		[Export ("flush")]
		void Flush ();

		// @optional @property (readonly, nonatomic, strong) dispatch_queue_t _Nonnull loggerQueue;
		[Export ("loggerQueue", ArgumentSemantic.Strong)]
		DispatchQueue LoggerQueue { get; }

		// @optional @property (readonly, nonatomic) NSString * _Nonnull loggerName;
		[Export ("loggerName")]
		string LoggerName { get; }
	}

	// @protocol AWSDDLogFormatter <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface AWSDDLogFormatter
	{
		// @required -(NSString * _Nullable)formatLogMessage:(AWSDDLogMessage * _Nonnull)logMessage __attribute__((swift_name("format(message:)")));
		[Abstract]
		[Export ("formatLogMessage:")]
		[return: NullAllowed]
		string FormatLogMessage (AWSDDLogMessage logMessage);

		// @optional -(void)didAddToLogger:(id<AWSDDLogger> _Nonnull)logger;
		[Export ("didAddToLogger:")]
		void DidAddToLogger (AWSDDLogger logger);

		// @optional -(void)didAddToLogger:(id<AWSDDLogger> _Nonnull)logger inQueue:(dispatch_queue_t _Nonnull)queue;
		[Export ("didAddToLogger:inQueue:")]
		void DidAddToLogger (AWSDDLogger logger, DispatchQueue queue);

		// @optional -(void)willRemoveFromLogger:(id<AWSDDLogger> _Nonnull)logger;
		[Export ("willRemoveFromLogger:")]
		void WillRemoveFromLogger (AWSDDLogger logger);
	}

	// @protocol AWSDDRegisteredDynamicLogging
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface AWSDDRegisteredDynamicLogging
	{
		// @required @property (readwrite, nonatomic, setter = ddSetLogLevel:, class) AWSDDLogLevel ddLogLevel;
		[Static, Abstract]
		[Export ("ddLogLevel", ArgumentSemantic.Assign)]
		AWSDDLogLevel DdLogLevel { get; [Bind ("ddSetLogLevel:")] set; }
	}

	// @interface AWSDDLogMessage : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface AWSDDLogMessage : INSCopying
	{
		// -(instancetype _Nonnull)initWithMessage:(NSString * _Nonnull)message level:(AWSDDLogLevel)level flag:(AWSDDLogFlag)flag context:(NSInteger)context file:(NSString * _Nonnull)file function:(NSString * _Nullable)function line:(NSUInteger)line tag:(id _Nullable)tag options:(AWSDDLogMessageOptions)options timestamp:(NSDate * _Nullable)timestamp __attribute__((objc_designated_initializer));
		[Export ("initWithMessage:level:flag:context:file:function:line:tag:options:timestamp:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string message, AWSDDLogLevel level, AWSDDLogFlag flag, nint context, string file, [NullAllowed] string function, nuint line, [NullAllowed] NSObject tag, AWSDDLogMessageOptions options, [NullAllowed] NSDate timestamp);

		// @property (readonly, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }

		// @property (readonly, nonatomic) AWSDDLogLevel level;
		[Export ("level")]
		AWSDDLogLevel Level { get; }

		// @property (readonly, nonatomic) AWSDDLogFlag flag;
		[Export ("flag")]
		AWSDDLogFlag Flag { get; }

		// @property (readonly, nonatomic) NSInteger context;
		[Export ("context")]
		nint Context { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull file;
		[Export ("file")]
		string File { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull fileName;
		[Export ("fileName")]
		string FileName { get; }

		// @property (readonly, nonatomic) NSString * _Nullable function;
		[NullAllowed, Export ("function")]
		string Function { get; }

		// @property (readonly, nonatomic) NSUInteger line;
		[Export ("line")]
		nuint Line { get; }

		// @property (readonly, nonatomic) id _Nullable tag;
		[NullAllowed, Export ("tag")]
		NSObject Tag { get; }

		// @property (readonly, nonatomic) AWSDDLogMessageOptions options;
		[Export ("options")]
		AWSDDLogMessageOptions Options { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull timestamp;
		[Export ("timestamp")]
		NSDate Timestamp { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull threadID;
		[Export ("threadID")]
		string ThreadID { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull threadName;
		[Export ("threadName")]
		string ThreadName { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull queueLabel;
		[Export ("queueLabel")]
		string QueueLabel { get; }
	}

	// @interface AWSDDAbstractLogger : NSObject <AWSDDLogger>
	[BaseType (typeof(NSObject))]
	interface AWSDDAbstractLogger : IAWSDDLogger
	{
		// @property (nonatomic, strong) id<AWSDDLogFormatter> _Nullable logFormatter;
		[NullAllowed, Export ("logFormatter", ArgumentSemantic.Strong)]
		AWSDDLogFormatter LogFormatter { get; set; }

		// @property (nonatomic, strong) dispatch_queue_t _Nonnull loggerQueue;
		[Export ("loggerQueue", ArgumentSemantic.Strong)]
		DispatchQueue LoggerQueue { get; set; }

		// @property (readonly, getter = isOnGlobalLoggingQueue, nonatomic) BOOL onGlobalLoggingQueue;
		[Export ("onGlobalLoggingQueue")]
		bool OnGlobalLoggingQueue { [Bind ("isOnGlobalLoggingQueue")] get; }

		// @property (readonly, getter = isOnInternalLoggerQueue, nonatomic) BOOL onInternalLoggerQueue;
		[Export ("onInternalLoggerQueue")]
		bool OnInternalLoggerQueue { [Bind ("isOnInternalLoggerQueue")] get; }
	}

	// @interface AWSDDLoggerInformation : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSDDLoggerInformation
	{
		// @property (readonly, nonatomic) id<AWSDDLogger> _Nonnull logger;
		[Export ("logger")]
		AWSDDLogger Logger { get; }

		// @property (readonly, nonatomic) AWSDDLogLevel level;
		[Export ("level")]
		AWSDDLogLevel Level { get; }

		// +(AWSDDLoggerInformation * _Nonnull)informationWithLogger:(id<AWSDDLogger> _Nonnull)logger andLevel:(AWSDDLogLevel)level;
		[Static]
		[Export ("informationWithLogger:andLevel:")]
		AWSDDLoggerInformation InformationWithLogger (AWSDDLogger logger, AWSDDLogLevel level);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const char *const kAWSDDASLKeyAWSDDLog;
		[Field ("kAWSDDASLKeyAWSDDLog", "__Internal")]
		unsafe sbyte* kAWSDDASLKeyAWSDDLog { get; }

		// extern const char *const kAWSDDASLAWSDDLogValue;
		[Field ("kAWSDDASLAWSDDLogValue", "__Internal")]
		unsafe sbyte* kAWSDDASLAWSDDLogValue { get; }
	}

	// @interface AWSDDASLLogger : AWSDDAbstractLogger <AWSDDLogger>
	[BaseType (typeof(AWSDDAbstractLogger))]
	interface AWSDDASLLogger : IAWSDDLogger
	{
		// @property (readonly, strong, class) AWSDDASLLogger * sharedInstance;
		[Static]
		[Export ("sharedInstance", ArgumentSemantic.Strong)]
		AWSDDASLLogger SharedInstance { get; }
	}

	// @interface AWSDDASLLogCapture : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSDDASLLogCapture
	{
		// +(void)start;
		[Static]
		[Export ("start")]
		void Start ();

		// +(void)stop;
		[Static]
		[Export ("stop")]
		void Stop ();

		// @property (class) AWSDDLogLevel captureLevel;
		[Static]
		[Export ("captureLevel", ArgumentSemantic.Assign)]
		AWSDDLogLevel CaptureLevel { get; set; }
	}

	// @interface AWSDDTTYLogger : AWSDDAbstractLogger <AWSDDLogger>
	[BaseType (typeof(AWSDDAbstractLogger))]
	interface AWSDDTTYLogger : IAWSDDLogger
	{
		// @property (readonly, strong, class) AWSDDTTYLogger * sharedInstance;
		[Static]
		[Export ("sharedInstance", ArgumentSemantic.Strong)]
		AWSDDTTYLogger SharedInstance { get; }

		// @property (assign, readwrite) BOOL colorsEnabled;
		[Export ("colorsEnabled")]
		bool ColorsEnabled { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL automaticallyAppendNewlineForCustomFormatters;
		[Export ("automaticallyAppendNewlineForCustomFormatters")]
		bool AutomaticallyAppendNewlineForCustomFormatters { get; set; }

		// -(void)setForegroundColor:(AWSDDColor *)txtColor backgroundColor:(AWSDDColor *)bgColor forFlag:(AWSDDLogFlag)mask;
		[Export ("setForegroundColor:backgroundColor:forFlag:")]
		void SetForegroundColor (UIColor txtColor, UIColor bgColor, AWSDDLogFlag mask);

		// -(void)setForegroundColor:(AWSDDColor *)txtColor backgroundColor:(AWSDDColor *)bgColor forFlag:(AWSDDLogFlag)mask context:(NSInteger)ctxt;
		[Export ("setForegroundColor:backgroundColor:forFlag:context:")]
		void SetForegroundColor (UIColor txtColor, UIColor bgColor, AWSDDLogFlag mask, nint ctxt);

		// -(void)setForegroundColor:(AWSDDColor *)txtColor backgroundColor:(AWSDDColor *)bgColor forTag:(id<NSCopying>)tag;
		[Export ("setForegroundColor:backgroundColor:forTag:")]
		void SetForegroundColor (UIColor txtColor, UIColor bgColor, NSCopying tag);

		// -(void)clearColorsForFlag:(AWSDDLogFlag)mask;
		[Export ("clearColorsForFlag:")]
		void ClearColorsForFlag (AWSDDLogFlag mask);

		// -(void)clearColorsForFlag:(AWSDDLogFlag)mask context:(NSInteger)context;
		[Export ("clearColorsForFlag:context:")]
		void ClearColorsForFlag (AWSDDLogFlag mask, nint context);

		// -(void)clearColorsForTag:(id<NSCopying>)tag;
		[Export ("clearColorsForTag:")]
		void ClearColorsForTag (NSCopying tag);

		// -(void)clearColorsForAllFlags;
		[Export ("clearColorsForAllFlags")]
		void ClearColorsForAllFlags ();

		// -(void)clearColorsForAllTags;
		[Export ("clearColorsForAllTags")]
		void ClearColorsForAllTags ();

		// -(void)clearAllColors;
		[Export ("clearAllColors")]
		void ClearAllColors ();
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const unsigned long long kAWSDDDefaultLogMaxFileSize;
		[Field ("kAWSDDDefaultLogMaxFileSize", "__Internal")]
		ulong kAWSDDDefaultLogMaxFileSize { get; }

		// extern const NSTimeInterval kAWSDDDefaultLogRollingFrequency;
		[Field ("kAWSDDDefaultLogRollingFrequency", "__Internal")]
		double kAWSDDDefaultLogRollingFrequency { get; }

		// extern const NSUInteger kAWSDDDefaultLogMaxNumLogFiles;
		[Field ("kAWSDDDefaultLogMaxNumLogFiles", "__Internal")]
		nuint kAWSDDDefaultLogMaxNumLogFiles { get; }

		// extern const unsigned long long kAWSDDDefaultLogFilesDiskQuota;
		[Field ("kAWSDDDefaultLogFilesDiskQuota", "__Internal")]
		ulong kAWSDDDefaultLogFilesDiskQuota { get; }
	}

	// @protocol AWSDDLogFileManager <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface AWSDDLogFileManager
	{
		// @required @property (assign, readwrite, atomic) NSUInteger maximumNumberOfLogFiles;
		[Abstract]
		[Export ("maximumNumberOfLogFiles")]
		nuint MaximumNumberOfLogFiles { get; set; }

		// @required @property (assign, readwrite, atomic) unsigned long long logFilesDiskQuota;
		[Abstract]
		[Export ("logFilesDiskQuota")]
		ulong LogFilesDiskQuota { get; set; }

		// @required @property (readonly, copy, nonatomic) NSString * logsDirectory;
		[Abstract]
		[Export ("logsDirectory")]
		string LogsDirectory { get; }

		// @required @property (readonly, nonatomic, strong) NSArray<NSString *> * unsortedLogFilePaths;
		[Abstract]
		[Export ("unsortedLogFilePaths", ArgumentSemantic.Strong)]
		string[] UnsortedLogFilePaths { get; }

		// @required @property (readonly, nonatomic, strong) NSArray<NSString *> * unsortedLogFileNames;
		[Abstract]
		[Export ("unsortedLogFileNames", ArgumentSemantic.Strong)]
		string[] UnsortedLogFileNames { get; }

		// @required @property (readonly, nonatomic, strong) NSArray<AWSDDLogFileInfo *> * unsortedLogFileInfos;
		[Abstract]
		[Export ("unsortedLogFileInfos", ArgumentSemantic.Strong)]
		AWSDDLogFileInfo[] UnsortedLogFileInfos { get; }

		// @required @property (readonly, nonatomic, strong) NSArray<NSString *> * sortedLogFilePaths;
		[Abstract]
		[Export ("sortedLogFilePaths", ArgumentSemantic.Strong)]
		string[] SortedLogFilePaths { get; }

		// @required @property (readonly, nonatomic, strong) NSArray<NSString *> * sortedLogFileNames;
		[Abstract]
		[Export ("sortedLogFileNames", ArgumentSemantic.Strong)]
		string[] SortedLogFileNames { get; }

		// @required @property (readonly, nonatomic, strong) NSArray<AWSDDLogFileInfo *> * sortedLogFileInfos;
		[Abstract]
		[Export ("sortedLogFileInfos", ArgumentSemantic.Strong)]
		AWSDDLogFileInfo[] SortedLogFileInfos { get; }

		// @required -(NSString *)createNewLogFile;
		[Abstract]
		[Export ("createNewLogFile")]
		[Verify (MethodToProperty)]
		string CreateNewLogFile { get; }

		// @optional -(void)didArchiveLogFile:(NSString *)logFilePath __attribute__((swift_name("didArchiveLogFile(atPath:)")));
		[Export ("didArchiveLogFile:")]
		void DidArchiveLogFile (string logFilePath);

		// @optional -(void)didRollAndArchiveLogFile:(NSString *)logFilePath __attribute__((swift_name("didRollAndArchiveLogFile(atPath:)")));
		[Export ("didRollAndArchiveLogFile:")]
		void DidRollAndArchiveLogFile (string logFilePath);
	}

	// @interface AWSDDLogFileManagerDefault : NSObject <AWSDDLogFileManager>
	[BaseType (typeof(NSObject))]
	interface AWSDDLogFileManagerDefault : IAWSDDLogFileManager
	{
		// -(instancetype)initWithLogsDirectory:(NSString *)logsDirectory __attribute__((objc_designated_initializer));
		[Export ("initWithLogsDirectory:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string logsDirectory);

		// -(instancetype)initWithLogsDirectory:(NSString *)logsDirectory defaultFileProtectionLevel:(NSString *)fileProtectionLevel;
		[Export ("initWithLogsDirectory:defaultFileProtectionLevel:")]
		NativeHandle Constructor (string logsDirectory, string fileProtectionLevel);

		// @property (readonly, copy) NSString * newLogFileName;
		[Export ("newLogFileName")]
		string NewLogFileName { get; }

		// -(BOOL)isLogFile:(NSString *)fileName __attribute__((swift_name("isLogFile(withName:)")));
		[Export ("isLogFile:")]
		bool IsLogFile (string fileName);
	}

	// @interface AWSDDLogFileFormatterDefault : NSObject <AWSDDLogFormatter>
	[BaseType (typeof(NSObject))]
	interface AWSDDLogFileFormatterDefault : IAWSDDLogFormatter
	{
		// -(instancetype)initWithDateFormatter:(NSDateFormatter *)dateFormatter __attribute__((objc_designated_initializer));
		[Export ("initWithDateFormatter:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSDateFormatter dateFormatter);
	}

	// @interface AWSDDFileLogger : AWSDDAbstractLogger <AWSDDLogger>
	[BaseType (typeof(AWSDDAbstractLogger))]
	interface AWSDDFileLogger : IAWSDDLogger
	{
		// -(instancetype)initWithLogFileManager:(id<AWSDDLogFileManager>)logFileManager __attribute__((objc_designated_initializer));
		[Export ("initWithLogFileManager:")]
		[DesignatedInitializer]
		NativeHandle Constructor (AWSDDLogFileManager logFileManager);

		// -(void)willLogMessage __attribute__((objc_requires_super));
		[Export ("willLogMessage")]
		[RequiresSuper]
		void WillLogMessage ();

		// -(void)didLogMessage __attribute__((objc_requires_super));
		[Export ("didLogMessage")]
		[RequiresSuper]
		void DidLogMessage ();

		// -(BOOL)shouldArchiveRecentLogFileInfo:(AWSDDLogFileInfo *)recentLogFileInfo;
		[Export ("shouldArchiveRecentLogFileInfo:")]
		bool ShouldArchiveRecentLogFileInfo (AWSDDLogFileInfo recentLogFileInfo);

		// @property (assign, readwrite) unsigned long long maximumFileSize;
		[Export ("maximumFileSize")]
		ulong MaximumFileSize { get; set; }

		// @property (assign, readwrite) NSTimeInterval rollingFrequency;
		[Export ("rollingFrequency")]
		double RollingFrequency { get; set; }

		// @property (assign, readwrite, atomic) BOOL doNotReuseLogFiles;
		[Export ("doNotReuseLogFiles")]
		bool DoNotReuseLogFiles { get; set; }

		// @property (readonly, nonatomic, strong) id<AWSDDLogFileManager> logFileManager;
		[Export ("logFileManager", ArgumentSemantic.Strong)]
		AWSDDLogFileManager LogFileManager { get; }

		// @property (assign, readwrite, nonatomic) BOOL automaticallyAppendNewlineForCustomFormatters;
		[Export ("automaticallyAppendNewlineForCustomFormatters")]
		bool AutomaticallyAppendNewlineForCustomFormatters { get; set; }

		// -(void)rollLogFileWithCompletionBlock:(void (^)(void))completionBlock __attribute__((swift_name("rollLogFile(withCompletion:)")));
		[Export ("rollLogFileWithCompletionBlock:")]
		void RollLogFileWithCompletionBlock (Action completionBlock);

		// -(void)rollLogFile __attribute__((deprecated("")));
		[Export ("rollLogFile")]
		void RollLogFile ();

		// @property (readonly, nonatomic, strong) AWSDDLogFileInfo * currentLogFileInfo;
		[Export ("currentLogFileInfo", ArgumentSemantic.Strong)]
		AWSDDLogFileInfo CurrentLogFileInfo { get; }
	}

	// @interface AWSDDLogFileInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface AWSDDLogFileInfo
	{
		// @property (readonly, nonatomic, strong) NSString * filePath;
		[Export ("filePath", ArgumentSemantic.Strong)]
		string FilePath { get; }

		// @property (readonly, nonatomic, strong) NSString * fileName;
		[Export ("fileName", ArgumentSemantic.Strong)]
		string FileName { get; }

		// @property (readonly, nonatomic, strong) NSDictionary<NSFileAttributeKey,id> * fileAttributes;
		[Export ("fileAttributes", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSObject> FileAttributes { get; }

		// @property (readonly, nonatomic, strong) NSDate * creationDate;
		[Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; }

		// @property (readonly, nonatomic, strong) NSDate * modificationDate;
		[Export ("modificationDate", ArgumentSemantic.Strong)]
		NSDate ModificationDate { get; }

		// @property (readonly, nonatomic) unsigned long long fileSize;
		[Export ("fileSize")]
		ulong FileSize { get; }

		// @property (readonly, nonatomic) NSTimeInterval age;
		[Export ("age")]
		double Age { get; }

		// @property (readwrite, nonatomic) BOOL isArchived;
		[Export ("isArchived")]
		bool IsArchived { get; set; }

		// +(instancetype)logFileWithPath:(NSString *)filePath __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Static]
		[Export ("logFileWithPath:")]
		AWSDDLogFileInfo LogFileWithPath (string filePath);

		// -(instancetype)initWithFilePath:(NSString *)filePath __attribute__((objc_designated_initializer));
		[Export ("initWithFilePath:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string filePath);

		// -(void)reset;
		[Export ("reset")]
		void Reset ();

		// -(void)renameFile:(NSString *)newFileName __attribute__((swift_name("renameFile(to:)")));
		[Export ("renameFile:")]
		void RenameFile (string newFileName);

		// -(BOOL)hasExtendedAttributeWithName:(NSString *)attrName;
		[Export ("hasExtendedAttributeWithName:")]
		bool HasExtendedAttributeWithName (string attrName);

		// -(void)addExtendedAttributeWithName:(NSString *)attrName;
		[Export ("addExtendedAttributeWithName:")]
		void AddExtendedAttributeWithName (string attrName);

		// -(void)removeExtendedAttributeWithName:(NSString *)attrName;
		[Export ("removeExtendedAttributeWithName:")]
		void RemoveExtendedAttributeWithName (string attrName);

		// -(NSComparisonResult)reverseCompareByCreationDate:(AWSDDLogFileInfo *)another;
		[Export ("reverseCompareByCreationDate:")]
		NSComparisonResult ReverseCompareByCreationDate (AWSDDLogFileInfo another);

		// -(NSComparisonResult)reverseCompareByModificationDate:(AWSDDLogFileInfo *)another;
		[Export ("reverseCompareByModificationDate:")]
		NSComparisonResult ReverseCompareByModificationDate (AWSDDLogFileInfo another);
	}

	// @interface AWSDDOSLogger : AWSDDAbstractLogger <AWSDDLogger>
	[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
	[BaseType (typeof(AWSDDAbstractLogger))]
	interface AWSDDOSLogger : IAWSDDLogger
	{
		// @property (readonly, strong, class) AWSDDOSLogger * sharedInstance;
		[Static]
		[Export ("sharedInstance", ArgumentSemantic.Strong)]
		AWSDDOSLogger SharedInstance { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double AWSMantleVersionNumber;
		[Field ("AWSMantleVersionNumber", "__Internal")]
		double AWSMantleVersionNumber { get; }

		// extern const unsigned char[] AWSMantleVersionString;
		[Field ("AWSMantleVersionString", "__Internal")]
		byte[] AWSMantleVersionString { get; }
	}

	// @protocol AWSMTLJSONSerializing
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface AWSMTLJSONSerializing
	{
		// @required +(NSDictionary *)JSONKeyPathsByPropertyKey;
		[Static, Abstract]
		[Export ("JSONKeyPathsByPropertyKey")]
		[Verify (MethodToProperty)]
		NSDictionary JSONKeyPathsByPropertyKey { get; }

		// @optional +(NSValueTransformer *)JSONTransformerForKey:(NSString *)key;
		[Static]
		[Export ("JSONTransformerForKey:")]
		NSValueTransformer JSONTransformerForKey (string key);

		// @optional +(Class)classForParsingJSONDictionary:(NSDictionary *)JSONDictionary;
		[Static]
		[Export ("classForParsingJSONDictionary:")]
		Class ClassForParsingJSONDictionary (NSDictionary JSONDictionary);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSMTLJSONAdapterErrorDomain;
		[Field ("AWSMTLJSONAdapterErrorDomain", "__Internal")]
		NSString AWSMTLJSONAdapterErrorDomain { get; }

		// extern const NSInteger AWSMTLJSONAdapterErrorNoClassFound;
		[Field ("AWSMTLJSONAdapterErrorNoClassFound", "__Internal")]
		nint AWSMTLJSONAdapterErrorNoClassFound { get; }

		// extern const NSInteger AWSMTLJSONAdapterErrorInvalidJSONDictionary;
		[Field ("AWSMTLJSONAdapterErrorInvalidJSONDictionary", "__Internal")]
		nint AWSMTLJSONAdapterErrorInvalidJSONDictionary { get; }

		// extern const NSInteger AWSMTLJSONAdapterErrorInvalidJSONMapping;
		[Field ("AWSMTLJSONAdapterErrorInvalidJSONMapping", "__Internal")]
		nint AWSMTLJSONAdapterErrorInvalidJSONMapping { get; }
	}

	// @interface AWSMTLJSONAdapter : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSMTLJSONAdapter
	{
		// @property (readonly, nonatomic, strong) AWSMTLModel<AWSMTLJSONSerializing> * model;
		[Export ("model", ArgumentSemantic.Strong)]
		AWSMTLJSONSerializing Model { get; }

		// +(id)modelOfClass:(Class)modelClass fromJSONDictionary:(NSDictionary *)JSONDictionary error:(NSError **)error;
		[Static]
		[Export ("modelOfClass:fromJSONDictionary:error:")]
		NSObject ModelOfClass (Class modelClass, NSDictionary JSONDictionary, out NSError error);

		// +(NSArray *)modelsOfClass:(Class)modelClass fromJSONArray:(NSArray *)JSONArray error:(NSError **)error;
		[Static]
		[Export ("modelsOfClass:fromJSONArray:error:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ModelsOfClass (Class modelClass, NSObject[] JSONArray, out NSError error);

		// +(NSDictionary *)JSONDictionaryFromModel:(AWSMTLModel<AWSMTLJSONSerializing> *)model;
		[Static]
		[Export ("JSONDictionaryFromModel:")]
		NSDictionary JSONDictionaryFromModel (AWSMTLJSONSerializing model);

		// +(NSArray *)JSONArrayFromModels:(NSArray *)models;
		[Static]
		[Export ("JSONArrayFromModels:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] JSONArrayFromModels (NSObject[] models);

		// -(id)initWithJSONDictionary:(NSDictionary *)JSONDictionary modelClass:(Class)modelClass error:(NSError **)error;
		[Export ("initWithJSONDictionary:modelClass:error:")]
		NativeHandle Constructor (NSDictionary JSONDictionary, Class modelClass, out NSError error);

		// -(id)initWithModel:(AWSMTLModel<AWSMTLJSONSerializing> *)model;
		[Export ("initWithModel:")]
		NativeHandle Constructor (AWSMTLJSONSerializing model);

		// -(NSDictionary *)JSONDictionary;
		[Export ("JSONDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary JSONDictionary { get; }

		// -(NSString *)JSONKeyPathForPropertyKey:(NSString *)key;
		[Export ("JSONKeyPathForPropertyKey:")]
		string JSONKeyPathForPropertyKey (string key);
	}

	// @interface Deprecated (AWSMTLJSONAdapter)
	[Category]
	[BaseType (typeof(AWSMTLJSONAdapter))]
	interface AWSMTLJSONAdapter_Deprecated
	{
		// +(id)modelOfClass:(Class)modelClass fromJSONDictionary:(NSDictionary *)JSONDictionary __attribute__((deprecated("Replaced by +modelOfClass:fromJSONDictionary:error:")));
		[Static]
		[Export ("modelOfClass:fromJSONDictionary:")]
		NSObject ModelOfClass (Class modelClass, NSDictionary JSONDictionary);

		// -(id)initWithJSONDictionary:(NSDictionary *)JSONDictionary modelClass:(Class)modelClass __attribute__((deprecated("Replaced by -initWithJSONDictionary:modelClass:error:")));
		[Export ("initWithJSONDictionary:modelClass:")]
		NativeHandle Constructor (NSDictionary JSONDictionary, Class modelClass);
	}

	// @protocol AWSMTLManagedObjectSerializing
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface AWSMTLManagedObjectSerializing
	{
		// @required +(NSString *)managedObjectEntityName;
		[Static, Abstract]
		[Export ("managedObjectEntityName")]
		[Verify (MethodToProperty)]
		string ManagedObjectEntityName { get; }

		// @required +(NSDictionary *)managedObjectKeysByPropertyKey;
		[Static, Abstract]
		[Export ("managedObjectKeysByPropertyKey")]
		[Verify (MethodToProperty)]
		NSDictionary ManagedObjectKeysByPropertyKey { get; }

		// @optional +(NSSet *)propertyKeysForManagedObjectUniquing;
		[Static]
		[Export ("propertyKeysForManagedObjectUniquing")]
		[Verify (MethodToProperty)]
		NSSet PropertyKeysForManagedObjectUniquing { get; }

		// @optional +(NSValueTransformer *)entityAttributeTransformerForKey:(NSString *)key;
		[Static]
		[Export ("entityAttributeTransformerForKey:")]
		NSValueTransformer EntityAttributeTransformerForKey (string key);

		// @optional +(NSDictionary *)relationshipModelClassesByPropertyKey;
		[Static]
		[Export ("relationshipModelClassesByPropertyKey")]
		[Verify (MethodToProperty)]
		NSDictionary RelationshipModelClassesByPropertyKey { get; }

		// @optional +(Class)classForDeserializingManagedObject:(NSManagedObject *)managedObject;
		[Static]
		[Export ("classForDeserializingManagedObject:")]
		Class ClassForDeserializingManagedObject (NSManagedObject managedObject);

		// @optional -(void)mergeValueForKey:(NSString *)key fromManagedObject:(NSManagedObject *)managedObject;
		[Export ("mergeValueForKey:fromManagedObject:")]
		void MergeValueForKey (string key, NSManagedObject managedObject);

		// @optional -(void)mergeValuesForKeysFromManagedObject:(NSManagedObject *)managedObject;
		[Export ("mergeValuesForKeysFromManagedObject:")]
		void MergeValuesForKeysFromManagedObject (NSManagedObject managedObject);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSMTLManagedObjectAdapterErrorDomain;
		[Field ("AWSMTLManagedObjectAdapterErrorDomain", "__Internal")]
		NSString AWSMTLManagedObjectAdapterErrorDomain { get; }

		// extern const NSInteger AWSMTLManagedObjectAdapterErrorNoClassFound;
		[Field ("AWSMTLManagedObjectAdapterErrorNoClassFound", "__Internal")]
		nint AWSMTLManagedObjectAdapterErrorNoClassFound { get; }

		// extern const NSInteger AWSMTLManagedObjectAdapterErrorInitializationFailed;
		[Field ("AWSMTLManagedObjectAdapterErrorInitializationFailed", "__Internal")]
		nint AWSMTLManagedObjectAdapterErrorInitializationFailed { get; }

		// extern const NSInteger AWSMTLManagedObjectAdapterErrorInvalidManagedObjectKey;
		[Field ("AWSMTLManagedObjectAdapterErrorInvalidManagedObjectKey", "__Internal")]
		nint AWSMTLManagedObjectAdapterErrorInvalidManagedObjectKey { get; }

		// extern const NSInteger AWSMTLManagedObjectAdapterErrorUnsupportedManagedObjectPropertyType;
		[Field ("AWSMTLManagedObjectAdapterErrorUnsupportedManagedObjectPropertyType", "__Internal")]
		nint AWSMTLManagedObjectAdapterErrorUnsupportedManagedObjectPropertyType { get; }

		// extern const NSInteger AWSMTLManagedObjectAdapterErrorUniqueFetchRequestFailed;
		[Field ("AWSMTLManagedObjectAdapterErrorUniqueFetchRequestFailed", "__Internal")]
		nint AWSMTLManagedObjectAdapterErrorUniqueFetchRequestFailed { get; }

		// extern const NSInteger AWSMTLManagedObjectAdapterErrorUnsupportedRelationshipClass;
		[Field ("AWSMTLManagedObjectAdapterErrorUnsupportedRelationshipClass", "__Internal")]
		nint AWSMTLManagedObjectAdapterErrorUnsupportedRelationshipClass { get; }

		// extern const NSInteger AWSMTLManagedObjectAdapterErrorInvalidManagedObjectMapping;
		[Field ("AWSMTLManagedObjectAdapterErrorInvalidManagedObjectMapping", "__Internal")]
		nint AWSMTLManagedObjectAdapterErrorInvalidManagedObjectMapping { get; }
	}

	// @interface AWSMTLManagedObjectAdapter : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSMTLManagedObjectAdapter
	{
		// +(id)modelOfClass:(Class)modelClass fromManagedObject:(NSManagedObject *)managedObject error:(NSError **)error;
		[Static]
		[Export ("modelOfClass:fromManagedObject:error:")]
		NSObject ModelOfClass (Class modelClass, NSManagedObject managedObject, out NSError error);

		// +(id)managedObjectFromModel:(AWSMTLModel<AWSMTLManagedObjectSerializing> *)model insertingIntoContext:(NSManagedObjectContext *)context error:(NSError **)error;
		[Static]
		[Export ("managedObjectFromModel:insertingIntoContext:error:")]
		NSObject ManagedObjectFromModel (AWSMTLManagedObjectSerializing model, NSManagedObjectContext context, out NSError error);
	}

	// @interface AWSMTLModel : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface AWSMTLModel : INSCopying
	{
		// +(instancetype)modelWithDictionary:(NSDictionary *)dictionaryValue error:(NSError **)error;
		[Static]
		[Export ("modelWithDictionary:error:")]
		AWSMTLModel ModelWithDictionary (NSDictionary dictionaryValue, out NSError error);

		// -(instancetype)initWithDictionary:(NSDictionary *)dictionaryValue error:(NSError **)error;
		[Export ("initWithDictionary:error:")]
		NativeHandle Constructor (NSDictionary dictionaryValue, out NSError error);

		// +(NSSet *)propertyKeys;
		[Static]
		[Export ("propertyKeys")]
		[Verify (MethodToProperty)]
		NSSet PropertyKeys { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * dictionaryValue;
		[Export ("dictionaryValue", ArgumentSemantic.Copy)]
		NSDictionary DictionaryValue { get; }

		// -(void)mergeValueForKey:(NSString *)key fromModel:(AWSMTLModel *)model;
		[Export ("mergeValueForKey:fromModel:")]
		void MergeValueForKey (string key, AWSMTLModel model);

		// -(void)mergeValuesForKeysFromModel:(AWSMTLModel *)model;
		[Export ("mergeValuesForKeysFromModel:")]
		void MergeValuesForKeysFromModel (AWSMTLModel model);

		// -(BOOL)isEqual:(id)object;
		[Export ("isEqual:")]
		bool IsEqual (NSObject @object);

		// -(NSString *)description;
		[Export ("description")]
		[Verify (MethodToProperty)]
		string Description { get; }
	}

	// @interface Validation (AWSMTLModel)
	[Category]
	[BaseType (typeof(AWSMTLModel))]
	interface AWSMTLModel_Validation
	{
		// -(BOOL)validate:(NSError **)error;
		[Export ("validate:")]
		bool Validate (out NSError error);
	}

	// @interface Unavailable (AWSMTLModel)
	[Category]
	[BaseType (typeof(AWSMTLModel))]
	interface AWSMTLModel_Unavailable
	{
		// +(instancetype)modelWithDictionary:(NSDictionary *)dictionaryValue __attribute__((deprecated("Replaced by +modelWithDictionary:error:")));
		[Static]
		[Export ("modelWithDictionary:")]
		AWSMTLModel ModelWithDictionary (NSDictionary dictionaryValue);

		// -(instancetype)initWithDictionary:(NSDictionary *)dictionaryValue __attribute__((deprecated("Replaced by -initWithDictionary:error:")));
		[Export ("initWithDictionary:")]
		NativeHandle Constructor (NSDictionary dictionaryValue);

		// +(instancetype)modelWithExternalRepresentation:(NSDictionary *)externalRepresentation __attribute__((deprecated("Replaced by -[MTLJSONAdapter initWithJSONDictionary:modelClass:]")));
		[Static]
		[Export ("modelWithExternalRepresentation:")]
		AWSMTLModel ModelWithExternalRepresentation (NSDictionary externalRepresentation);

		// -(instancetype)initWithExternalRepresentation:(NSDictionary *)externalRepresentation __attribute__((deprecated("Replaced by -[MTLJSONAdapter initWithJSONDictionary:modelClass:]")));
		[Export ("initWithExternalRepresentation:")]
		NativeHandle Constructor (NSDictionary externalRepresentation);

		// @property (readonly, copy, nonatomic) NSDictionary * externalRepresentation __attribute__((deprecated("Replaced by MTLJSONAdapter.JSONDictionary")));
		[Export ("externalRepresentation", ArgumentSemantic.Copy)]
		NSDictionary ExternalRepresentation { get; }

		// +(NSDictionary *)externalRepresentationKeyPathsByPropertyKey __attribute__((deprecated("Replaced by +JSONKeyPathsByPropertyKey in <MTLJSONSerializing>")));
		[Static]
		[Export ("externalRepresentationKeyPathsByPropertyKey")]
		[Verify (MethodToProperty)]
		NSDictionary ExternalRepresentationKeyPathsByPropertyKey { get; }

		// +(NSValueTransformer *)transformerForKey:(NSString *)key __attribute__((deprecated("Replaced by +JSONTransformerForKey: in <MTLJSONSerializing>")));
		[Static]
		[Export ("transformerForKey:")]
		NSValueTransformer TransformerForKey (string key);

		// +(NSDictionary *)migrateExternalRepresentation:(NSDictionary *)externalRepresentation fromVersion:(NSUInteger)fromVersion __attribute__((deprecated("Replaced by -decodeValueForKey:withCoder:modelVersion:")));
		[Static]
		[Export ("migrateExternalRepresentation:fromVersion:")]
		NSDictionary MigrateExternalRepresentation (NSDictionary externalRepresentation, nuint fromVersion);
	}

	// @interface NSCoding (AWSMTLModel) <NSCoding>
	[Category]
	[BaseType (typeof(AWSMTLModel))]
	interface AWSMTLModel_NSCoding : INSCoding
	{
		// -(id)initWithCoder:(NSCoder *)coder;
		[Export ("initWithCoder:")]
		NativeHandle Constructor (NSCoder coder);

		// -(void)encodeWithCoder:(NSCoder *)coder;
		[Export ("encodeWithCoder:")]
		void EncodeWithCoder (NSCoder coder);

		// +(NSDictionary *)encodingBehaviorsByPropertyKey;
		[Static]
		[Export ("encodingBehaviorsByPropertyKey")]
		[Verify (MethodToProperty)]
		NSDictionary EncodingBehaviorsByPropertyKey { get; }

		// +(NSDictionary *)allowedSecureCodingClassesByPropertyKey;
		[Static]
		[Export ("allowedSecureCodingClassesByPropertyKey")]
		[Verify (MethodToProperty)]
		NSDictionary AllowedSecureCodingClassesByPropertyKey { get; }

		// -(id)decodeValueForKey:(NSString *)key withCoder:(NSCoder *)coder modelVersion:(NSUInteger)modelVersion;
		[Export ("decodeValueForKey:withCoder:modelVersion:")]
		NSObject DecodeValueForKey (string key, NSCoder coder, nuint modelVersion);

		// +(NSUInteger)modelVersion;
		[Static]
		[Export ("modelVersion")]
		[Verify (MethodToProperty)]
		nuint ModelVersion { get; }
	}

	// @interface OldArchiveSupport (AWSMTLModel)
	[Category]
	[BaseType (typeof(AWSMTLModel))]
	interface AWSMTLModel_OldArchiveSupport
	{
		// +(NSDictionary *)dictionaryValueFromArchivedExternalRepresentation:(NSDictionary *)externalRepresentation version:(NSUInteger)fromVersion;
		[Static]
		[Export ("dictionaryValueFromArchivedExternalRepresentation:version:")]
		NSDictionary DictionaryValueFromArchivedExternalRepresentation (NSDictionary externalRepresentation, nuint fromVersion);
	}

	// typedef id (^AWSMTLValueTransformerBlock)(id);
	delegate NSObject AWSMTLValueTransformerBlock (NSObject arg0);

	// @interface AWSMTLValueTransformer : NSValueTransformer
	[BaseType (typeof(NSValueTransformer))]
	interface AWSMTLValueTransformer
	{
		// +(instancetype)transformerWithBlock:(AWSMTLValueTransformerBlock)transformationBlock;
		[Static]
		[Export ("transformerWithBlock:")]
		AWSMTLValueTransformer TransformerWithBlock (AWSMTLValueTransformerBlock transformationBlock);

		// +(instancetype)reversibleTransformerWithBlock:(AWSMTLValueTransformerBlock)transformationBlock;
		[Static]
		[Export ("reversibleTransformerWithBlock:")]
		AWSMTLValueTransformer ReversibleTransformerWithBlock (AWSMTLValueTransformerBlock transformationBlock);

		// +(instancetype)reversibleTransformerWithForwardBlock:(AWSMTLValueTransformerBlock)forwardBlock reverseBlock:(AWSMTLValueTransformerBlock)reverseBlock;
		[Static]
		[Export ("reversibleTransformerWithForwardBlock:reverseBlock:")]
		AWSMTLValueTransformer ReversibleTransformerWithForwardBlock (AWSMTLValueTransformerBlock forwardBlock, AWSMTLValueTransformerBlock reverseBlock);
	}

	// @interface AWSMTLManipulationAdditions (NSArray)
	[Category]
	[BaseType (typeof(NSArray))]
	interface NSArray_AWSMTLManipulationAdditions
	{
		// @property (readonly, nonatomic, strong) id awsmtl_firstObject;
		[Export ("awsmtl_firstObject", ArgumentSemantic.Strong)]
		NSObject Awsmtl_firstObject { get; }

		// -(NSArray *)awsmtl_arrayByRemovingObject:(id)object;
		[Export ("awsmtl_arrayByRemovingObject:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Awsmtl_arrayByRemovingObject (NSObject @object);

		// -(NSArray *)awsmtl_arrayByRemovingFirstObject;
		[Export ("awsmtl_arrayByRemovingFirstObject")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Awsmtl_arrayByRemovingFirstObject { get; }

		// -(NSArray *)awsmtl_arrayByRemovingLastObject;
		[Export ("awsmtl_arrayByRemovingLastObject")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Awsmtl_arrayByRemovingLastObject { get; }
	}

	// @interface AWSMTLManipulationAdditions (NSDictionary)
	[Category]
	[BaseType (typeof(NSDictionary))]
	interface NSDictionary_AWSMTLManipulationAdditions
	{
		// -(NSDictionary *)awsmtl_dictionaryByAddingEntriesFromDictionary:(NSDictionary *)dictionary;
		[Export ("awsmtl_dictionaryByAddingEntriesFromDictionary:")]
		NSDictionary Awsmtl_dictionaryByAddingEntriesFromDictionary (NSDictionary dictionary);

		// -(NSDictionary *)awsmtl_dictionaryByRemovingEntriesWithKeys:(NSSet *)keys;
		[Export ("awsmtl_dictionaryByRemovingEntriesWithKeys:")]
		NSDictionary Awsmtl_dictionaryByRemovingEntriesWithKeys (NSSet keys);
	}

	// @interface AWSMTLInversionAdditions (NSValueTransformer)
	[Category]
	[BaseType (typeof(NSValueTransformer))]
	interface NSValueTransformer_AWSMTLInversionAdditions
	{
		// -(NSValueTransformer *)awsmtl_invertedTransformer;
		[Export ("awsmtl_invertedTransformer")]
		[Verify (MethodToProperty)]
		NSValueTransformer Awsmtl_invertedTransformer { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSMTLURLValueTransformerName;
		[Field ("AWSMTLURLValueTransformerName", "__Internal")]
		NSString AWSMTLURLValueTransformerName { get; }

		// extern NSString *const AWSMTLBooleanValueTransformerName;
		[Field ("AWSMTLBooleanValueTransformerName", "__Internal")]
		NSString AWSMTLBooleanValueTransformerName { get; }
	}

	// @interface AWSMTLPredefinedTransformerAdditions (NSValueTransformer)
	[Category]
	[BaseType (typeof(NSValueTransformer))]
	interface NSValueTransformer_AWSMTLPredefinedTransformerAdditions
	{
		// +(NSValueTransformer *)awsmtl_JSONDictionaryTransformerWithModelClass:(Class)modelClass;
		[Static]
		[Export ("awsmtl_JSONDictionaryTransformerWithModelClass:")]
		NSValueTransformer Awsmtl_JSONDictionaryTransformerWithModelClass (Class modelClass);

		// +(NSValueTransformer *)awsmtl_JSONArrayTransformerWithModelClass:(Class)modelClass;
		[Static]
		[Export ("awsmtl_JSONArrayTransformerWithModelClass:")]
		NSValueTransformer Awsmtl_JSONArrayTransformerWithModelClass (Class modelClass);

		// +(NSValueTransformer *)awsmtl_valueMappingTransformerWithDictionary:(NSDictionary *)dictionary defaultValue:(id)defaultValue reverseDefaultValue:(id)reverseDefaultValue;
		[Static]
		[Export ("awsmtl_valueMappingTransformerWithDictionary:defaultValue:reverseDefaultValue:")]
		NSValueTransformer Awsmtl_valueMappingTransformerWithDictionary (NSDictionary dictionary, NSObject defaultValue, NSObject reverseDefaultValue);

		// +(NSValueTransformer *)awsmtl_valueMappingTransformerWithDictionary:(NSDictionary *)dictionary;
		[Static]
		[Export ("awsmtl_valueMappingTransformerWithDictionary:")]
		NSValueTransformer Awsmtl_valueMappingTransformerWithDictionary (NSDictionary dictionary);
	}

	// @interface UnavailableAWSMTLPredefinedTransformerAdditions (NSValueTransformer)
	[Category]
	[BaseType (typeof(NSValueTransformer))]
	interface NSValueTransformer_UnavailableAWSMTLPredefinedTransformerAdditions
	{
		// +(NSValueTransformer *)awsmtl_externalRepresentationTransformerWithModelClass:(Class)modelClass __attribute__((deprecated("Replaced by +mtl_JSONDictionaryTransformerWithModelClass:")));
		[Static]
		[Export ("awsmtl_externalRepresentationTransformerWithModelClass:")]
		NSValueTransformer Awsmtl_externalRepresentationTransformerWithModelClass (Class modelClass);

		// +(NSValueTransformer *)awsmtl_externalRepresentationArrayTransformerWithModelClass:(Class)modelClass __attribute__((deprecated("Replaced by +mtl_JSONArrayTransformerWithModelClass:")));
		[Static]
		[Export ("awsmtl_externalRepresentationArrayTransformerWithModelClass:")]
		NSValueTransformer Awsmtl_externalRepresentationArrayTransformerWithModelClass (Class modelClass);
	}

	// @interface AWSModel : AWSMTLModel <AWSMTLJSONSerializing, NSSecureCoding>
	[BaseType (typeof(AWSMTLModel))]
	interface AWSModel : IAWSMTLJSONSerializing, INSSecureCoding
	{
	}

	// @interface AWSModelUtility : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSModelUtility
	{
		// +(NSDictionary *)mapMTLDictionaryFromJSONArrayDictionary:(NSDictionary *)JSONArrayDictionary arrayElementType:(NSString *)arrayElementType withModelClass:(Class)modelClass;
		[Static]
		[Export ("mapMTLDictionaryFromJSONArrayDictionary:arrayElementType:withModelClass:")]
		NSDictionary MapMTLDictionaryFromJSONArrayDictionary (NSDictionary JSONArrayDictionary, string arrayElementType, Class modelClass);

		// +(NSDictionary *)JSONArrayDictionaryFromMapMTLDictionary:(NSDictionary *)mapMTLDictionary arrayElementType:(NSString *)arrayElementType;
		[Static]
		[Export ("JSONArrayDictionaryFromMapMTLDictionary:arrayElementType:")]
		NSDictionary JSONArrayDictionaryFromMapMTLDictionary (NSDictionary mapMTLDictionary, string arrayElementType);

		// +(NSArray *)mapMTLArrayFromJSONArray:(NSArray *)JSONArray withModelClass:(Class)modelClass;
		[Static]
		[Export ("mapMTLArrayFromJSONArray:withModelClass:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] MapMTLArrayFromJSONArray (NSObject[] JSONArray, Class modelClass);

		// +(NSArray *)JSONArrayFromMapMTLArray:(NSArray *)mapMTLArray;
		[Static]
		[Export ("JSONArrayFromMapMTLArray:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] JSONArrayFromMapMTLArray (NSObject[] mapMTLArray);

		// +(NSDictionary *)mapMTLDictionaryFromJSONDictionary:(NSDictionary *)JSONDictionary withModelClass:(Class)modelClass;
		[Static]
		[Export ("mapMTLDictionaryFromJSONDictionary:withModelClass:")]
		NSDictionary MapMTLDictionaryFromJSONDictionary (NSDictionary JSONDictionary, Class modelClass);

		// +(NSDictionary *)JSONDictionaryFromMapMTLDictionary:(NSDictionary *)mapMTLDictionary;
		[Static]
		[Export ("JSONDictionaryFromMapMTLDictionary:")]
		NSDictionary JSONDictionaryFromMapMTLDictionary (NSDictionary mapMTLDictionary);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSNetworkingErrorDomain;
		[Field ("AWSNetworkingErrorDomain", "__Internal")]
		NSString AWSNetworkingErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSResponseObjectErrorUserInfoKey;
		[Field ("AWSResponseObjectErrorUserInfoKey", "__Internal")]
		NSString AWSResponseObjectErrorUserInfoKey { get; }
	}

	// typedef void (^AWSNetworkingUploadProgressBlock)(int64_t, int64_t, int64_t);
	delegate void AWSNetworkingUploadProgressBlock (long arg0, long arg1, long arg2);

	// typedef void (^AWSNetworkingDownloadProgressBlock)(int64_t, int64_t, int64_t);
	delegate void AWSNetworkingDownloadProgressBlock (long arg0, long arg1, long arg2);

	// @interface AWSHTTPMethod (NSString)
	[Category]
	[BaseType (typeof(NSString))]
	interface NSString_AWSHTTPMethod
	{
		// +(instancetype)aws_stringWithHTTPMethod:(AWSHTTPMethod)HTTPMethod;
		[Static]
		[Export ("aws_stringWithHTTPMethod:")]
		NSString Aws_stringWithHTTPMethod (AWSHTTPMethod HTTPMethod);
	}

	// @interface AWSNetworking : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSNetworking
	{
		// -(instancetype)initWithConfiguration:(AWSNetworkingConfiguration *)configuration;
		[Export ("initWithConfiguration:")]
		NativeHandle Constructor (AWSNetworkingConfiguration configuration);

		// -(AWSTask *)sendRequest:(AWSNetworkingRequest *)request;
		[Export ("sendRequest:")]
		AWSTask SendRequest (AWSNetworkingRequest request);
	}

	// @protocol AWSURLRequestSerializer <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface AWSURLRequestSerializer
	{
		// @required -(AWSTask *)validateRequest:(NSURLRequest *)request;
		[Abstract]
		[Export ("validateRequest:")]
		AWSTask ValidateRequest (NSUrlRequest request);

		// @required -(AWSTask *)serializeRequest:(NSMutableURLRequest *)request headers:(NSDictionary *)headers parameters:(NSDictionary *)parameters;
		[Abstract]
		[Export ("serializeRequest:headers:parameters:")]
		AWSTask SerializeRequest (NSMutableUrlRequest request, NSDictionary headers, NSDictionary parameters);
	}

	// @protocol AWSNetworkingRequestInterceptor <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface AWSNetworkingRequestInterceptor
	{
		// @required -(AWSTask *)interceptRequest:(NSMutableURLRequest *)request;
		[Abstract]
		[Export ("interceptRequest:")]
		AWSTask InterceptRequest (NSMutableUrlRequest request);
	}

	// @protocol AWSNetworkingHTTPResponseInterceptor <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface AWSNetworkingHTTPResponseInterceptor
	{
		// @required -(AWSTask *)interceptResponse:(NSHTTPURLResponse *)response data:(id)data originalRequest:(NSURLRequest *)originalRequest currentRequest:(NSURLRequest *)currentRequest;
		[Abstract]
		[Export ("interceptResponse:data:originalRequest:currentRequest:")]
		AWSTask Data (NSHttpUrlResponse response, NSObject data, NSUrlRequest originalRequest, NSUrlRequest currentRequest);
	}

	// @protocol AWSHTTPURLResponseSerializer <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface AWSHTTPURLResponseSerializer
	{
		// @required -(BOOL)validateResponse:(NSHTTPURLResponse *)response fromRequest:(NSURLRequest *)request data:(id)data error:(NSError **)error;
		[Abstract]
		[Export ("validateResponse:fromRequest:data:error:")]
		bool ValidateResponse (NSHttpUrlResponse response, NSUrlRequest request, NSObject data, out NSError error);

		// @required -(id)responseObjectForResponse:(NSHTTPURLResponse *)response originalRequest:(NSURLRequest *)originalRequest currentRequest:(NSURLRequest *)currentRequest data:(id)data error:(NSError **)error;
		[Abstract]
		[Export ("responseObjectForResponse:originalRequest:currentRequest:data:error:")]
		NSObject ResponseObjectForResponse (NSHttpUrlResponse response, NSUrlRequest originalRequest, NSUrlRequest currentRequest, NSObject data, out NSError error);
	}

	// @protocol AWSURLRequestRetryHandler <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface AWSURLRequestRetryHandler
	{
		// @required @property (assign, nonatomic) uint32_t maxRetryCount;
		[Abstract]
		[Export ("maxRetryCount")]
		uint MaxRetryCount { get; set; }

		// @required -(AWSNetworkingRetryType)shouldRetry:(uint32_t)currentRetryCount originalRequest:(AWSNetworkingRequest *)originalRequest response:(NSHTTPURLResponse *)response data:(NSData *)data error:(NSError *)error;
		[Abstract]
		[Export ("shouldRetry:originalRequest:response:data:error:")]
		AWSNetworkingRetryType ShouldRetry (uint currentRetryCount, AWSNetworkingRequest originalRequest, NSHttpUrlResponse response, NSData data, NSError error);

		// @required -(NSTimeInterval)timeIntervalForRetry:(uint32_t)currentRetryCount response:(NSHTTPURLResponse *)response data:(NSData *)data error:(NSError *)error;
		[Abstract]
		[Export ("timeIntervalForRetry:response:data:error:")]
		double TimeIntervalForRetry (uint currentRetryCount, NSHttpUrlResponse response, NSData data, NSError error);

		// @optional -(NSDictionary *)resetParameters:(NSDictionary *)parameters;
		[Export ("resetParameters:")]
		NSDictionary ResetParameters (NSDictionary parameters);
	}

	// @interface AWSNetworkingConfiguration : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface AWSNetworkingConfiguration : INSCopying
	{
		// @property (readonly, nonatomic) NSURL * URL;
		[Export ("URL")]
		NSUrl URL { get; }

		// @property (nonatomic, strong) NSURL * baseURL;
		[Export ("baseURL", ArgumentSemantic.Strong)]
		NSUrl BaseURL { get; set; }

		// @property (nonatomic, strong) NSString * URLString;
		[Export ("URLString", ArgumentSemantic.Strong)]
		string URLString { get; set; }

		// @property (assign, nonatomic) AWSHTTPMethod HTTPMethod;
		[Export ("HTTPMethod", ArgumentSemantic.Assign)]
		AWSHTTPMethod HTTPMethod { get; set; }

		// @property (nonatomic, strong) NSDictionary * headers;
		[Export ("headers", ArgumentSemantic.Strong)]
		NSDictionary Headers { get; set; }

		// @property (assign, nonatomic) BOOL allowsCellularAccess;
		[Export ("allowsCellularAccess")]
		bool AllowsCellularAccess { get; set; }

		// @property (nonatomic, strong) NSString * sharedContainerIdentifier;
		[Export ("sharedContainerIdentifier", ArgumentSemantic.Strong)]
		string SharedContainerIdentifier { get; set; }

		// @property (nonatomic, strong) id<AWSURLRequestSerializer> requestSerializer;
		[Export ("requestSerializer", ArgumentSemantic.Strong)]
		AWSURLRequestSerializer RequestSerializer { get; set; }

		// @property (nonatomic, strong) NSArray<id<AWSNetworkingRequestInterceptor>> * requestInterceptors;
		[Export ("requestInterceptors", ArgumentSemantic.Strong)]
		AWSNetworkingRequestInterceptor[] RequestInterceptors { get; set; }

		// @property (nonatomic, strong) id<AWSHTTPURLResponseSerializer> responseSerializer;
		[Export ("responseSerializer", ArgumentSemantic.Strong)]
		AWSHTTPURLResponseSerializer ResponseSerializer { get; set; }

		// @property (nonatomic, strong) NSArray<id<AWSNetworkingHTTPResponseInterceptor>> * responseInterceptors;
		[Export ("responseInterceptors", ArgumentSemantic.Strong)]
		AWSNetworkingHTTPResponseInterceptor[] ResponseInterceptors { get; set; }

		// @property (nonatomic, strong) id<AWSURLRequestRetryHandler> retryHandler;
		[Export ("retryHandler", ArgumentSemantic.Strong)]
		AWSURLRequestRetryHandler RetryHandler { get; set; }

		// @property (assign, nonatomic) uint32_t maxRetryCount;
		[Export ("maxRetryCount")]
		uint MaxRetryCount { get; set; }

		// @property (assign, nonatomic) NSTimeInterval timeoutIntervalForRequest;
		[Export ("timeoutIntervalForRequest")]
		double TimeoutIntervalForRequest { get; set; }

		// @property (assign, nonatomic) NSTimeInterval timeoutIntervalForResource;
		[Export ("timeoutIntervalForResource")]
		double TimeoutIntervalForResource { get; set; }
	}

	// @interface AWSNetworkingRequest : AWSNetworkingConfiguration
	[BaseType (typeof(AWSNetworkingConfiguration))]
	interface AWSNetworkingRequest
	{
		// @property (nonatomic, strong) NSDictionary * parameters;
		[Export ("parameters", ArgumentSemantic.Strong)]
		NSDictionary Parameters { get; set; }

		// @property (nonatomic, strong) NSURL * uploadingFileURL;
		[Export ("uploadingFileURL", ArgumentSemantic.Strong)]
		NSUrl UploadingFileURL { get; set; }

		// @property (nonatomic, strong) NSURL * downloadingFileURL;
		[Export ("downloadingFileURL", ArgumentSemantic.Strong)]
		NSUrl DownloadingFileURL { get; set; }

		// @property (assign, nonatomic) BOOL shouldWriteDirectly;
		[Export ("shouldWriteDirectly")]
		bool ShouldWriteDirectly { get; set; }

		// @property (copy, nonatomic) AWSNetworkingUploadProgressBlock uploadProgress;
		[Export ("uploadProgress", ArgumentSemantic.Copy)]
		AWSNetworkingUploadProgressBlock UploadProgress { get; set; }

		// @property (copy, nonatomic) AWSNetworkingDownloadProgressBlock downloadProgress;
		[Export ("downloadProgress", ArgumentSemantic.Copy)]
		AWSNetworkingDownloadProgressBlock DownloadProgress { get; set; }

		// @property (readonly, nonatomic, strong) NSURLSessionTask * task;
		[Export ("task", ArgumentSemantic.Strong)]
		NSUrlSessionTask Task { get; }

		// @property (readonly, getter = isCancelled, assign, nonatomic) BOOL cancelled;
		[Export ("cancelled")]
		bool Cancelled { [Bind ("isCancelled")] get; }

		// -(void)assignProperties:(AWSNetworkingConfiguration *)configuration;
		[Export ("assignProperties:")]
		void AssignProperties (AWSNetworkingConfiguration configuration);

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// -(void)pause;
		[Export ("pause")]
		void Pause ();
	}

	// @interface AWSRequest : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSRequest
	{
		// @property (copy, nonatomic) AWSNetworkingUploadProgressBlock uploadProgress;
		[Export ("uploadProgress", ArgumentSemantic.Copy)]
		AWSNetworkingUploadProgressBlock UploadProgress { get; set; }

		// @property (copy, nonatomic) AWSNetworkingDownloadProgressBlock downloadProgress;
		[Export ("downloadProgress", ArgumentSemantic.Copy)]
		AWSNetworkingDownloadProgressBlock DownloadProgress { get; set; }

		// @property (readonly, getter = isCancelled, assign, nonatomic) BOOL cancelled;
		[Export ("cancelled")]
		bool Cancelled { [Bind ("isCancelled")] get; }

		// @property (nonatomic, strong) NSURL * downloadingFileURL;
		[Export ("downloadingFileURL", ArgumentSemantic.Strong)]
		NSUrl DownloadingFileURL { get; set; }

		// -(AWSTask *)cancel;
		[Export ("cancel")]
		[Verify (MethodToProperty)]
		AWSTask Cancel { get; }

		// -(AWSTask *)pause;
		[Export ("pause")]
		[Verify (MethodToProperty)]
		AWSTask Pause { get; }
	}

	// @interface AWSNetworkingRequestInterceptor : NSObject <AWSNetworkingRequestInterceptor>
	[BaseType (typeof(NSObject))]
	interface AWSNetworkingRequestInterceptor : IAWSNetworkingRequestInterceptor
	{
		// @property (readonly, nonatomic) NSString * userAgent;
		[Export ("userAgent")]
		string UserAgent { get; }

		// -(instancetype)initWithUserAgent:(NSString *)userAgent;
		[Export ("initWithUserAgent:")]
		NativeHandle Constructor (string userAgent);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSCognitoIdentityIdChangedNotification;
		[Field ("AWSCognitoIdentityIdChangedNotification", "__Internal")]
		NSString AWSCognitoIdentityIdChangedNotification { get; }

		// extern NSString *const _Nonnull AWSCognitoNotificationPreviousId;
		[Field ("AWSCognitoNotificationPreviousId", "__Internal")]
		NSString AWSCognitoNotificationPreviousId { get; }

		// extern NSString *const _Nonnull AWSCognitoNotificationNewId;
		[Field ("AWSCognitoNotificationNewId", "__Internal")]
		NSString AWSCognitoNotificationNewId { get; }

		// extern NSString *const _Nonnull AWSIdentityProviderApple;
		[Field ("AWSIdentityProviderApple", "__Internal")]
		NSString AWSIdentityProviderApple { get; }

		// extern NSString *const _Nonnull AWSIdentityProviderDigits;
		[Field ("AWSIdentityProviderDigits", "__Internal")]
		NSString AWSIdentityProviderDigits { get; }

		// extern NSString *const _Nonnull AWSIdentityProviderFacebook;
		[Field ("AWSIdentityProviderFacebook", "__Internal")]
		NSString AWSIdentityProviderFacebook { get; }

		// extern NSString *const _Nonnull AWSIdentityProviderGoogle;
		[Field ("AWSIdentityProviderGoogle", "__Internal")]
		NSString AWSIdentityProviderGoogle { get; }

		// extern NSString *const _Nonnull AWSIdentityProviderLoginWithAmazon;
		[Field ("AWSIdentityProviderLoginWithAmazon", "__Internal")]
		NSString AWSIdentityProviderLoginWithAmazon { get; }

		// extern NSString *const _Nonnull AWSIdentityProviderTwitter;
		[Field ("AWSIdentityProviderTwitter", "__Internal")]
		NSString AWSIdentityProviderTwitter { get; }

		// extern NSString *const _Nonnull AWSIdentityProviderAmazonCognitoIdentity;
		[Field ("AWSIdentityProviderAmazonCognitoIdentity", "__Internal")]
		NSString AWSIdentityProviderAmazonCognitoIdentity { get; }

		// extern NSString *const _Nonnull AWSCognitoCredentialsProviderHelperErrorDomain;
		[Field ("AWSCognitoCredentialsProviderHelperErrorDomain", "__Internal")]
		NSString AWSCognitoCredentialsProviderHelperErrorDomain { get; }
	}

	// @protocol AWSIdentityProvider <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface AWSIdentityProvider
	{
		// @required @property (readonly, nonatomic) NSString * _Nonnull identityProviderName;
		[Abstract]
		[Export ("identityProviderName")]
		string IdentityProviderName { get; }

		// @required -(AWSTask<NSString *> * _Nonnull)token;
		[Abstract]
		[Export ("token")]
		[Verify (MethodToProperty)]
		AWSTask<NSString> Token { get; }
	}

	// @protocol AWSIdentityProviderManager <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface AWSIdentityProviderManager
	{
		// @required -(AWSTask<NSDictionary<NSString *,NSString *> *> * _Nonnull)logins;
		[Abstract]
		[Export ("logins")]
		[Verify (MethodToProperty)]
		AWSTask<NSDictionary<NSString, NSString>> Logins { get; }

		// @optional @property (readonly, nonatomic) NSString * _Nonnull customRoleArn;
		[Export ("customRoleArn")]
		string CustomRoleArn { get; }
	}

	// @protocol AWSCognitoCredentialsProviderHelper <AWSIdentityProvider, AWSIdentityProviderManager>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface AWSCognitoCredentialsProviderHelper : IAWSIdentityProvider, IAWSIdentityProviderManager
	{
		// @required @property (readonly, nonatomic, strong) NSString * _Nonnull identityPoolId;
		[Abstract]
		[Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; }

		// @required @property (nonatomic, strong) NSString * _Nullable identityId;
		[Abstract]
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @required @property (readonly, nonatomic, strong) id<AWSIdentityProviderManager> _Nullable identityProviderManager;
		[Abstract]
		[NullAllowed, Export ("identityProviderManager", ArgumentSemantic.Strong)]
		AWSIdentityProviderManager IdentityProviderManager { get; }

		// @required -(AWSTask<NSString *> * _Nonnull)getIdentityId;
		[Abstract]
		[Export ("getIdentityId")]
		[Verify (MethodToProperty)]
		AWSTask<NSString> IdentityId { get; }

		// @required -(BOOL)isAuthenticated;
		[Abstract]
		[Export ("isAuthenticated")]
		[Verify (MethodToProperty)]
		bool IsAuthenticated { get; }

		// @required -(void)clear;
		[Abstract]
		[Export ("clear")]
		void Clear ();
	}

	// @interface AWSAbstractCognitoCredentialsProviderHelper : NSObject <AWSCognitoCredentialsProviderHelper>
	[BaseType (typeof(NSObject))]
	interface AWSAbstractCognitoCredentialsProviderHelper : IAWSCognitoCredentialsProviderHelper
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull identityPoolId;
		[Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; }

		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @property (readonly, nonatomic, strong) id<AWSIdentityProviderManager> _Nullable identityProviderManager;
		[NullAllowed, Export ("identityProviderManager", ArgumentSemantic.Strong)]
		AWSIdentityProviderManager IdentityProviderManager { get; }
	}

	// @interface AWSCognitoCredentialsProviderHelper : AWSAbstractCognitoCredentialsProviderHelper
	[BaseType (typeof(AWSAbstractCognitoCredentialsProviderHelper))]
	interface AWSCognitoCredentialsProviderHelper
	{
		// @property (assign, nonatomic) BOOL useEnhancedFlow;
		[Export ("useEnhancedFlow")]
		bool UseEnhancedFlow { get; set; }

		// -(instancetype _Nonnull)initWithRegionType:(AWSRegionType)regionType identityPoolId:(NSString * _Nonnull)identityPoolId useEnhancedFlow:(BOOL)useEnhancedFlow identityProviderManager:(id<AWSIdentityProviderManager> _Nullable)identityProviderManager;
		[Export ("initWithRegionType:identityPoolId:useEnhancedFlow:identityProviderManager:")]
		NativeHandle Constructor (AWSRegionType regionType, string identityPoolId, bool useEnhancedFlow, [NullAllowed] AWSIdentityProviderManager identityProviderManager);

		// -(instancetype _Nonnull)initWithRegionType:(AWSRegionType)regionType identityPoolId:(NSString * _Nonnull)identityPoolId useEnhancedFlow:(BOOL)useEnhancedFlow identityProviderManager:(id<AWSIdentityProviderManager> _Nullable)identityProviderManager identityPoolConfiguration:(AWSServiceConfiguration * _Nonnull)configuration;
		[Export ("initWithRegionType:identityPoolId:useEnhancedFlow:identityProviderManager:identityPoolConfiguration:")]
		NativeHandle Constructor (AWSRegionType regionType, string identityPoolId, bool useEnhancedFlow, [NullAllowed] AWSIdentityProviderManager identityProviderManager, AWSServiceConfiguration configuration);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSCognitoCredentialsProviderErrorDomain;
		[Field ("AWSCognitoCredentialsProviderErrorDomain", "__Internal")]
		NSString AWSCognitoCredentialsProviderErrorDomain { get; }
	}

	// @interface AWSCredentials : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface AWSCredentials : INSCopying
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull accessKey;
		[Export ("accessKey", ArgumentSemantic.Strong)]
		string AccessKey { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull secretKey;
		[Export ("secretKey", ArgumentSemantic.Strong)]
		string SecretKey { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable sessionKey;
		[NullAllowed, Export ("sessionKey", ArgumentSemantic.Strong)]
		string SessionKey { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable expiration;
		[NullAllowed, Export ("expiration", ArgumentSemantic.Strong)]
		NSDate Expiration { get; }

		// -(instancetype _Nonnull)initWithAccessKey:(NSString * _Nonnull)accessKey secretKey:(NSString * _Nonnull)secretKey sessionKey:(NSString * _Nullable)sessionKey expiration:(NSDate * _Nullable)expiration;
		[Export ("initWithAccessKey:secretKey:sessionKey:expiration:")]
		NativeHandle Constructor (string accessKey, string secretKey, [NullAllowed] string sessionKey, [NullAllowed] NSDate expiration);
	}

	// @protocol AWSCredentialsProvider <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface AWSCredentialsProvider
	{
		// @required -(AWSTask<AWSCredentials *> * _Nonnull)credentials;
		[Abstract]
		[Export ("credentials")]
		[Verify (MethodToProperty)]
		AWSTask<AWSCredentials> Credentials { get; }

		// @required -(void)invalidateCachedTemporaryCredentials;
		[Abstract]
		[Export ("invalidateCachedTemporaryCredentials")]
		void InvalidateCachedTemporaryCredentials ();
	}

	// @interface AWSStaticCredentialsProvider : NSObject <AWSCredentialsProvider>
	[BaseType (typeof(NSObject))]
	interface AWSStaticCredentialsProvider : IAWSCredentialsProvider
	{
		// -(instancetype _Nonnull)initWithAccessKey:(NSString * _Nonnull)accessKey secretKey:(NSString * _Nonnull)secretKey;
		[Export ("initWithAccessKey:secretKey:")]
		NativeHandle Constructor (string accessKey, string secretKey);
	}

	// @interface AWSBasicSessionCredentialsProvider : NSObject <AWSCredentialsProvider>
	[BaseType (typeof(NSObject))]
	interface AWSBasicSessionCredentialsProvider : IAWSCredentialsProvider
	{
		// -(instancetype _Nonnull)initWithAccessKey:(NSString * _Nonnull)accessKey secretKey:(NSString * _Nonnull)secretKey sessionToken:(NSString * _Nonnull)sessionToken;
		[Export ("initWithAccessKey:secretKey:sessionToken:")]
		NativeHandle Constructor (string accessKey, string secretKey, string sessionToken);
	}

	// @interface AWSAnonymousCredentialsProvider : NSObject <AWSCredentialsProvider>
	[BaseType (typeof(NSObject))]
	interface AWSAnonymousCredentialsProvider : IAWSCredentialsProvider
	{
	}

	// @interface AWSWebIdentityCredentialsProvider : NSObject <AWSCredentialsProvider>
	[BaseType (typeof(NSObject))]
	interface AWSWebIdentityCredentialsProvider : IAWSCredentialsProvider
	{
		// @property (nonatomic, strong) NSString * _Nonnull webIdentityToken;
		[Export ("webIdentityToken", ArgumentSemantic.Strong)]
		string WebIdentityToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull roleArn;
		[Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull roleSessionName;
		[Export ("roleSessionName", ArgumentSemantic.Strong)]
		string RoleSessionName { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull providerId;
		[Export ("providerId", ArgumentSemantic.Strong)]
		string ProviderId { get; set; }

		// -(instancetype _Nonnull)initWithRegionType:(AWSRegionType)regionType providerId:(NSString * _Nullable)providerId roleArn:(NSString * _Nonnull)roleArn roleSessionName:(NSString * _Nonnull)roleSessionName webIdentityToken:(NSString * _Nonnull)webIdentityToken;
		[Export ("initWithRegionType:providerId:roleArn:roleSessionName:webIdentityToken:")]
		NativeHandle Constructor (AWSRegionType regionType, [NullAllowed] string providerId, string roleArn, string roleSessionName, string webIdentityToken);
	}

	// @interface AWSCognitoCredentialsProvider : NSObject <AWSCredentialsProvider>
	[BaseType (typeof(NSObject))]
	interface AWSCognitoCredentialsProvider : IAWSCredentialsProvider
	{
		// @property (readonly, nonatomic, strong) id<AWSCognitoCredentialsProviderHelper> _Nonnull identityProvider;
		[Export ("identityProvider", ArgumentSemantic.Strong)]
		AWSCognitoCredentialsProviderHelper IdentityProvider { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull identityPoolId;
		[Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; }

		// -(instancetype _Nonnull)initWithRegionType:(AWSRegionType)regionType identityPoolId:(NSString * _Nonnull)identityPoolId;
		[Export ("initWithRegionType:identityPoolId:")]
		NativeHandle Constructor (AWSRegionType regionType, string identityPoolId);

		// -(instancetype _Nonnull)initWithRegionType:(AWSRegionType)regionType identityPoolId:(NSString * _Nonnull)identityPoolId identityPoolConfiguration:(AWSServiceConfiguration * _Nonnull)configuration;
		[Export ("initWithRegionType:identityPoolId:identityPoolConfiguration:")]
		NativeHandle Constructor (AWSRegionType regionType, string identityPoolId, AWSServiceConfiguration configuration);

		// -(instancetype _Nonnull)initWithRegionType:(AWSRegionType)regionType identityPoolId:(NSString * _Nonnull)identityPoolId identityProviderManager:(id<AWSIdentityProviderManager> _Nullable)identityProviderManager;
		[Export ("initWithRegionType:identityPoolId:identityProviderManager:")]
		NativeHandle Constructor (AWSRegionType regionType, string identityPoolId, [NullAllowed] AWSIdentityProviderManager identityProviderManager);

		// -(instancetype _Nonnull)initWithRegionType:(AWSRegionType)regionType identityProvider:(id<AWSCognitoCredentialsProviderHelper> _Nonnull)identityProvider;
		[Export ("initWithRegionType:identityProvider:")]
		NativeHandle Constructor (AWSRegionType regionType, AWSCognitoCredentialsProviderHelper identityProvider);

		// -(instancetype _Nonnull)initWithRegionType:(AWSRegionType)regionType unauthRoleArn:(NSString * _Nullable)unauthRoleArn authRoleArn:(NSString * _Nullable)authRoleArn identityProvider:(id<AWSCognitoCredentialsProviderHelper> _Nonnull)identityProvider;
		[Export ("initWithRegionType:unauthRoleArn:authRoleArn:identityProvider:")]
		NativeHandle Constructor (AWSRegionType regionType, [NullAllowed] string unauthRoleArn, [NullAllowed] string authRoleArn, AWSCognitoCredentialsProviderHelper identityProvider);

		// -(instancetype _Nonnull)initWithRegionType:(AWSRegionType)regionType identityPoolId:(NSString * _Nonnull)identityPoolId unauthRoleArn:(NSString * _Nullable)unauthRoleArn authRoleArn:(NSString * _Nullable)authRoleArn identityProviderManager:(id<AWSIdentityProviderManager> _Nullable)identityProviderManager;
		[Export ("initWithRegionType:identityPoolId:unauthRoleArn:authRoleArn:identityProviderManager:")]
		NativeHandle Constructor (AWSRegionType regionType, string identityPoolId, [NullAllowed] string unauthRoleArn, [NullAllowed] string authRoleArn, [NullAllowed] AWSIdentityProviderManager identityProviderManager);

		// -(AWSTask<NSString *> * _Nonnull)getIdentityId;
		[Export ("getIdentityId")]
		[Verify (MethodToProperty)]
		AWSTask<NSString> IdentityId { get; }

		// -(void)clearKeychain;
		[Export ("clearKeychain")]
		void ClearKeychain ();

		// -(void)clearCredentials;
		[Export ("clearCredentials")]
		void ClearCredentials ();

		// -(void)setIdentityProviderManagerOnce:(id<AWSIdentityProviderManager> _Nonnull)identityProviderManager;
		[Export ("setIdentityProviderManagerOnce:")]
		void SetIdentityProviderManagerOnce (AWSIdentityProviderManager identityProviderManager);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSiOSSDKVersion;
		[Field ("AWSiOSSDKVersion", "__Internal")]
		NSString AWSiOSSDKVersion { get; }

		// extern NSString *const AWSServiceErrorDomain;
		[Field ("AWSServiceErrorDomain", "__Internal")]
		NSString AWSServiceErrorDomain { get; }
	}

	// @interface AWSService : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSService
	{
		// +(NSDictionary<NSString *,NSNumber *> *)errorCodeDictionary;
		[Static]
		[Export ("errorCodeDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary<NSString, NSNumber> ErrorCodeDictionary { get; }
	}

	// @interface AWSServiceManager : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSServiceManager
	{
		// @property (copy, nonatomic) AWSServiceConfiguration * defaultServiceConfiguration;
		[Export ("defaultServiceConfiguration", ArgumentSemantic.Copy)]
		AWSServiceConfiguration DefaultServiceConfiguration { get; set; }

		// +(instancetype)defaultServiceManager;
		[Static]
		[Export ("defaultServiceManager")]
		AWSServiceManager DefaultServiceManager ();
	}

	// @interface AWSServiceConfiguration : AWSNetworkingConfiguration
	[BaseType (typeof(AWSNetworkingConfiguration))]
	interface AWSServiceConfiguration
	{
		// @property (readonly, assign, nonatomic) AWSRegionType regionType;
		[Export ("regionType", ArgumentSemantic.Assign)]
		AWSRegionType RegionType { get; }

		// @property (readonly, nonatomic, strong) id<AWSCredentialsProvider> credentialsProvider;
		[Export ("credentialsProvider", ArgumentSemantic.Strong)]
		AWSCredentialsProvider CredentialsProvider { get; }

		// @property (readonly, nonatomic, strong) AWSEndpoint * endpoint;
		[Export ("endpoint", ArgumentSemantic.Strong)]
		AWSEndpoint Endpoint { get; }

		// @property (readonly, nonatomic) NSString * userAgent;
		[Export ("userAgent")]
		string UserAgent { get; }

		// @property (readonly, nonatomic) BOOL localTestingEnabled;
		[Export ("localTestingEnabled")]
		bool LocalTestingEnabled { get; }

		// +(NSString *)baseUserAgent;
		[Static]
		[Export ("baseUserAgent")]
		[Verify (MethodToProperty)]
		string BaseUserAgent { get; }

		// +(void)addGlobalUserAgentProductToken:(NSString *)productToken;
		[Static]
		[Export ("addGlobalUserAgentProductToken:")]
		void AddGlobalUserAgentProductToken (string productToken);

		// -(instancetype)initWithRegion:(AWSRegionType)regionType credentialsProvider:(id<AWSCredentialsProvider>)credentialsProvider;
		[Export ("initWithRegion:credentialsProvider:")]
		NativeHandle Constructor (AWSRegionType regionType, AWSCredentialsProvider credentialsProvider);

		// -(instancetype)initWithRegion:(AWSRegionType)regionType serviceType:(AWSServiceType)serviceType credentialsProvider:(id<AWSCredentialsProvider>)credentialsProvider localTestingEnabled:(BOOL)localTestingEnabled;
		[Export ("initWithRegion:serviceType:credentialsProvider:localTestingEnabled:")]
		NativeHandle Constructor (AWSRegionType regionType, AWSServiceType serviceType, AWSCredentialsProvider credentialsProvider, bool localTestingEnabled);

		// -(instancetype)initWithRegion:(AWSRegionType)regionType endpoint:(AWSEndpoint *)endpoint credentialsProvider:(id<AWSCredentialsProvider>)credentialsProvider;
		[Export ("initWithRegion:endpoint:credentialsProvider:")]
		NativeHandle Constructor (AWSRegionType regionType, AWSEndpoint endpoint, AWSCredentialsProvider credentialsProvider);

		// -(instancetype)initWithRegion:(AWSRegionType)regionType endpoint:(AWSEndpoint *)endpoint credentialsProvider:(id<AWSCredentialsProvider>)credentialsProvider localTestingEnabled:(BOOL)localTestingEnabled;
		[Export ("initWithRegion:endpoint:credentialsProvider:localTestingEnabled:")]
		NativeHandle Constructor (AWSRegionType regionType, AWSEndpoint endpoint, AWSCredentialsProvider credentialsProvider, bool localTestingEnabled);

		// -(void)addUserAgentProductToken:(NSString *)productToken;
		[Export ("addUserAgentProductToken:")]
		void AddUserAgentProductToken (string productToken);
	}

	// @interface AWSEndpoint : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSEndpoint
	{
		// @property (readonly, nonatomic) AWSRegionType regionType;
		[Export ("regionType")]
		AWSRegionType RegionType { get; }

		// @property (readonly, nonatomic) NSString * regionName;
		[Export ("regionName")]
		string RegionName { get; }

		// @property (readonly, nonatomic) AWSServiceType serviceType;
		[Export ("serviceType")]
		AWSServiceType ServiceType { get; }

		// @property (readonly, nonatomic) NSString * serviceName;
		[Export ("serviceName")]
		string ServiceName { get; }

		// @property (readonly, nonatomic) NSString * signingName;
		[Export ("signingName")]
		string SigningName { get; }

		// @property (readonly, nonatomic) NSURL * URL;
		[Export ("URL")]
		NSUrl URL { get; }

		// @property (readonly, nonatomic) NSString * hostName;
		[Export ("hostName")]
		string HostName { get; }

		// @property (readonly, nonatomic) BOOL useUnsafeURL;
		[Export ("useUnsafeURL")]
		bool UseUnsafeURL { get; }

		// @property (readonly, nonatomic) NSNumber * portNumber;
		[Export ("portNumber")]
		NSNumber PortNumber { get; }

		// +(NSString *)regionNameFromType:(AWSRegionType)regionType;
		[Static]
		[Export ("regionNameFromType:")]
		string RegionNameFromType (AWSRegionType regionType);

		// -(instancetype)initWithRegion:(AWSRegionType)regionType service:(AWSServiceType)serviceType useUnsafeURL:(BOOL)useUnsafeURL;
		[Export ("initWithRegion:service:useUnsafeURL:")]
		NativeHandle Constructor (AWSRegionType regionType, AWSServiceType serviceType, bool useUnsafeURL);

		// -(instancetype)initWithRegion:(AWSRegionType)regionType service:(AWSServiceType)serviceType URL:(NSURL *)URL;
		[Export ("initWithRegion:service:URL:")]
		NativeHandle Constructor (AWSRegionType regionType, AWSServiceType serviceType, NSUrl URL);

		// -(instancetype)initWithRegion:(AWSRegionType)regionType serviceName:(NSString *)serviceName URL:(NSURL *)URL;
		[Export ("initWithRegion:serviceName:URL:")]
		NativeHandle Constructor (AWSRegionType regionType, string serviceName, NSUrl URL);

		// -(instancetype)initWithURL:(NSURL *)URL;
		[Export ("initWithURL:")]
		NativeHandle Constructor (NSUrl URL);

		// -(instancetype)initWithURLString:(NSString *)URLString;
		[Export ("initWithURLString:")]
		NativeHandle Constructor (string URLString);

		// -(instancetype)initLocalEndpointWithRegion:(AWSRegionType)regionType service:(AWSServiceType)serviceType useUnsafeURL:(BOOL)useUnsafeURL;
		[Export ("initLocalEndpointWithRegion:service:useUnsafeURL:")]
		NativeHandle Constructor (AWSRegionType regionType, AWSServiceType serviceType, bool useUnsafeURL);
	}

	// @interface AWSNetworkingHelpers : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSNetworkingHelpers
	{
		// +(NSArray<NSURLQueryItem *> * _Nonnull)queryItemsFromDictionary:(NSDictionary<NSString *,id> * _Nonnull)requestParameters;
		[Static]
		[Export ("queryItemsFromDictionary:")]
		NSUrlQueryItem[] QueryItemsFromDictionary (NSDictionary<NSString, NSObject> requestParameters);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSDateRFC822DateFormat1;
		[Field ("AWSDateRFC822DateFormat1", "__Internal")]
		NSString AWSDateRFC822DateFormat1 { get; }

		// extern NSString *const AWSDateISO8601DateFormat1;
		[Field ("AWSDateISO8601DateFormat1", "__Internal")]
		NSString AWSDateISO8601DateFormat1 { get; }

		// extern NSString *const AWSDateISO8601DateFormat2;
		[Field ("AWSDateISO8601DateFormat2", "__Internal")]
		NSString AWSDateISO8601DateFormat2 { get; }

		// extern NSString *const AWSDateISO8601DateFormat3;
		[Field ("AWSDateISO8601DateFormat3", "__Internal")]
		NSString AWSDateISO8601DateFormat3 { get; }

		// extern NSString *const AWSDateShortDateFormat1;
		[Field ("AWSDateShortDateFormat1", "__Internal")]
		NSString AWSDateShortDateFormat1 { get; }

		// extern NSString *const AWSDateShortDateFormat2;
		[Field ("AWSDateShortDateFormat2", "__Internal")]
		NSString AWSDateShortDateFormat2 { get; }
	}

	// @interface AWS (NSDate)
	[Category]
	[BaseType (typeof(NSDate))]
	interface NSDate_AWS
	{
		// +(NSDate *)aws_clockSkewFixedDate;
		[Static]
		[Export ("aws_clockSkewFixedDate")]
		[Verify (MethodToProperty)]
		NSDate Aws_clockSkewFixedDate { get; }

		// +(NSDate *)aws_dateFromString:(NSString *)string;
		[Static]
		[Export ("aws_dateFromString:")]
		NSDate Aws_dateFromString (string @string);

		// +(NSDate *)aws_dateFromString:(NSString *)string format:(NSString *)dateFormat;
		[Static]
		[Export ("aws_dateFromString:format:")]
		NSDate Aws_dateFromString (string @string, string dateFormat);

		// -(NSString *)aws_stringValue:(NSString *)dateFormat;
		[Export ("aws_stringValue:")]
		string Aws_stringValue (string dateFormat);

		// +(void)aws_setRuntimeClockSkew:(NSTimeInterval)clockskew;
		[Static]
		[Export ("aws_setRuntimeClockSkew:")]
		void Aws_setRuntimeClockSkew (double clockskew);

		// +(NSTimeInterval)aws_getRuntimeClockSkew;
		[Static]
		[Export ("aws_getRuntimeClockSkew")]
		[Verify (MethodToProperty)]
		double Aws_getRuntimeClockSkew { get; }
	}

	// @interface AWS (NSDictionary)
	[Category]
	[BaseType (typeof(NSDictionary))]
	interface NSDictionary_AWS
	{
		// -(NSDictionary *)aws_removeNullValues;
		[Export ("aws_removeNullValues")]
		[Verify (MethodToProperty)]
		NSDictionary Aws_removeNullValues { get; }

		// -(id)aws_objectForCaseInsensitiveKey:(id)aKey;
		[Export ("aws_objectForCaseInsensitiveKey:")]
		NSObject Aws_objectForCaseInsensitiveKey (NSObject aKey);
	}

	// @interface AWS (NSJSONSerialization)
	[Category]
	[BaseType (typeof(NSJsonSerialization))]
	interface NSJSONSerialization_AWS
	{
		// +(NSData *)aws_dataWithJSONObject:(id)obj options:(NSJSONWritingOptions)opt error:(NSError **)error;
		[Static]
		[Export ("aws_dataWithJSONObject:options:error:")]
		NSData Aws_dataWithJSONObject (NSObject obj, NSJSONWritingOptions opt, out NSError error);
	}

	// @interface AWS (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_AWS
	{
		// +(NSNumber *)aws_numberFromString:(NSString *)string;
		[Static]
		[Export ("aws_numberFromString:")]
		NSNumber Aws_numberFromString (string @string);
	}

	// @interface AWS (NSObject)
	[Category]
	[BaseType (typeof(NSObject))]
	interface NSObject_AWS
	{
		// -(NSDictionary *)aws_properties;
		[Export ("aws_properties")]
		[Verify (MethodToProperty)]
		NSDictionary Aws_properties { get; }

		// -(void)aws_copyPropertiesFromObject:(NSObject *)object;
		[Export ("aws_copyPropertiesFromObject:")]
		void Aws_copyPropertiesFromObject (NSObject @object);
	}

	// @interface AWS (NSString)
	[Category]
	[BaseType (typeof(NSString))]
	interface NSString_AWS
	{
		// +(NSString *)aws_base64md5FromData:(NSData *)data;
		[Static]
		[Export ("aws_base64md5FromData:")]
		string Aws_base64md5FromData (NSData data);

		// -(BOOL)aws_isBase64Data;
		[Export ("aws_isBase64Data")]
		[Verify (MethodToProperty)]
		bool Aws_isBase64Data { get; }

		// -(NSString *)aws_stringWithURLEncoding;
		[Export ("aws_stringWithURLEncoding")]
		[Verify (MethodToProperty)]
		string Aws_stringWithURLEncoding { get; }

		// -(NSString *)aws_stringWithURLEncodingPath;
		[Export ("aws_stringWithURLEncodingPath")]
		[Verify (MethodToProperty)]
		string Aws_stringWithURLEncodingPath { get; }

		// -(NSString *)aws_stringWithURLEncodingPathWithoutPriorDecoding;
		[Export ("aws_stringWithURLEncodingPathWithoutPriorDecoding")]
		[Verify (MethodToProperty)]
		string Aws_stringWithURLEncodingPathWithoutPriorDecoding { get; }

		// -(BOOL)aws_isVirtualHostedStyleCompliant;
		[Export ("aws_isVirtualHostedStyleCompliant")]
		[Verify (MethodToProperty)]
		bool Aws_isVirtualHostedStyleCompliant { get; }

		// -(AWSRegionType)aws_regionTypeValue;
		[Export ("aws_regionTypeValue")]
		[Verify (MethodToProperty)]
		AWSRegionType Aws_regionTypeValue { get; }
	}

	// @interface AWS (NSFileManager)
	[Category]
	[BaseType (typeof(NSFileManager))]
	interface NSFileManager_AWS
	{
		// -(BOOL)aws_atomicallyCopyItemAtURL:(NSURL *)sourceURL toURL:(NSURL *)destinationURL backupItemName:(NSString *)backupItemName error:(NSError **)outError;
		[Export ("aws_atomicallyCopyItemAtURL:toURL:backupItemName:error:")]
		bool Aws_atomicallyCopyItemAtURL (NSUrl sourceURL, NSUrl destinationURL, string backupItemName, out NSError outError);
	}

	// @interface AWSLogger : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSLogger
	{
		// @property (assign, atomic) AWSLogLevel logLevel;
		[Export ("logLevel", ArgumentSemantic.Assign)]
		AWSLogLevel LogLevel { get; set; }

		// +(instancetype)defaultLogger;
		[Static]
		[Export ("defaultLogger")]
		AWSLogger DefaultLogger ();

		// -(void)log:(AWSLogLevel)logLevel format:(NSString *)fmt, ... __attribute__((format(NSString, 2, 3)));
		[Internal]
		[Export ("log:format:", IsVariadic = true)]
		void Log (AWSLogLevel logLevel, string fmt, IntPtr varArgs);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSClientContextVersion;
		[Field ("AWSClientContextVersion", "__Internal")]
		NSString AWSClientContextVersion { get; }

		// extern NSString *const AWSClientContextHeader;
		[Field ("AWSClientContextHeader", "__Internal")]
		NSString AWSClientContextHeader { get; }

		// extern NSString *const AWSClientContextHeaderEncoding;
		[Field ("AWSClientContextHeaderEncoding", "__Internal")]
		NSString AWSClientContextHeaderEncoding { get; }
	}

	// @interface AWSClientContext : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSClientContext
	{
		// @property (readonly, nonatomic, strong) NSString * installationId;
		[Export ("installationId", ArgumentSemantic.Strong)]
		string InstallationId { get; }

		// @property (nonatomic, strong) NSString * appVersion;
		[Export ("appVersion", ArgumentSemantic.Strong)]
		string AppVersion { get; set; }

		// @property (nonatomic, strong) NSString * appBuild;
		[Export ("appBuild", ArgumentSemantic.Strong)]
		string AppBuild { get; set; }

		// @property (nonatomic, strong) NSString * appPackageName;
		[Export ("appPackageName", ArgumentSemantic.Strong)]
		string AppPackageName { get; set; }

		// @property (nonatomic, strong) NSString * appName;
		[Export ("appName", ArgumentSemantic.Strong)]
		string AppName { get; set; }

		// @property (nonatomic, strong) NSString * devicePlatformVersion;
		[Export ("devicePlatformVersion", ArgumentSemantic.Strong)]
		string DevicePlatformVersion { get; set; }

		// @property (nonatomic, strong) NSString * devicePlatform;
		[Export ("devicePlatform", ArgumentSemantic.Strong)]
		string DevicePlatform { get; set; }

		// @property (nonatomic, strong) NSString * deviceManufacturer;
		[Export ("deviceManufacturer", ArgumentSemantic.Strong)]
		string DeviceManufacturer { get; set; }

		// @property (nonatomic, strong) NSString * deviceModel;
		[Export ("deviceModel", ArgumentSemantic.Strong)]
		string DeviceModel { get; set; }

		// @property (nonatomic, strong) NSString * deviceModelVersion;
		[Export ("deviceModelVersion", ArgumentSemantic.Strong)]
		string DeviceModelVersion { get; set; }

		// @property (nonatomic, strong) NSString * deviceLocale;
		[Export ("deviceLocale", ArgumentSemantic.Strong)]
		string DeviceLocale { get; set; }

		// @property (nonatomic, strong) NSDictionary * customAttributes;
		[Export ("customAttributes", ArgumentSemantic.Strong)]
		NSDictionary CustomAttributes { get; set; }

		// @property (readonly, nonatomic, strong) NSDictionary * serviceDetails;
		[Export ("serviceDetails", ArgumentSemantic.Strong)]
		NSDictionary ServiceDetails { get; }

		// -(NSDictionary *)dictionaryRepresentation;
		[Export ("dictionaryRepresentation")]
		[Verify (MethodToProperty)]
		NSDictionary DictionaryRepresentation { get; }

		// -(NSString *)JSONString;
		[Export ("JSONString")]
		[Verify (MethodToProperty)]
		string JSONString { get; }

		// -(NSString *)base64EncodedJSONString;
		[Export ("base64EncodedJSONString")]
		[Verify (MethodToProperty)]
		string Base64EncodedJSONString { get; }

		// -(void)setDetails:(id)details forService:(NSString *)service;
		[Export ("setDetails:forService:")]
		void SetDetails (NSObject details, string service);
	}

	// audit-objc-generics: @interface AWSSynchronizedMutableDictionary<KeyType, ObjectType> : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSSynchronizedMutableDictionary
	{
		// @property (readonly, copy) NSArray<KeyType> * allKeys;
		[Export ("allKeys", ArgumentSemantic.Copy)]
		NSObject[] AllKeys { get; }

		// @property (readonly, copy) NSArray<ObjectType> * allValues;
		[Export ("allValues", ArgumentSemantic.Copy)]
		NSObject[] AllValues { get; }

		// @property (readonly, nonatomic, strong) NSUUID * instanceKey;
		[Export ("instanceKey", ArgumentSemantic.Strong)]
		NSUuid InstanceKey { get; }

		// -(instancetype)syncedDictionary;
		[Export ("syncedDictionary")]
		AWSSynchronizedMutableDictionary SyncedDictionary ();

		// -(id)objectForKey:(id)aKey;
		[Export ("objectForKey:")]
		NSObject ObjectForKey (NSObject aKey);

		// -(void)setObject:(id)anObject forKey:(id<NSCopying>)aKey;
		[Export ("setObject:forKey:")]
		void SetObject (NSObject anObject, NSCopying aKey);

		// -(void)removeObject:(id)object;
		[Export ("removeObject:")]
		void RemoveObject (NSObject @object);

		// -(void)removeObjectForKey:(id)aKey;
		[Export ("removeObjectForKey:")]
		void RemoveObjectForKey (NSObject aKey);

		// -(void)removeAllObjects;
		[Export ("removeAllObjects")]
		void RemoveAllObjects ();

		// -(void)mutateWithBlock:(void (^)(NSMutableDictionary *))block;
		[Export ("mutateWithBlock:")]
		void MutateWithBlock (Action<NSMutableDictionary> block);

		// +(void)mutateSyncedDictionaries:(NSArray<AWSSynchronizedMutableDictionary *> *)dictionaries withBlock:(void (^)(NSUUID *, NSMutableDictionary *))block;
		[Static]
		[Export ("mutateSyncedDictionaries:withBlock:")]
		void MutateSyncedDictionaries (AWSSynchronizedMutableDictionary[] dictionaries, Action<NSUUID, NSMutableDictionary> block);

		// -(BOOL)isEqualToAWSSynchronizedMutableDictionary:(AWSSynchronizedMutableDictionary *)other;
		[Export ("isEqualToAWSSynchronizedMutableDictionary:")]
		bool IsEqualToAWSSynchronizedMutableDictionary (AWSSynchronizedMutableDictionary other);
	}

	// @interface AWSXMLDictionaryParser : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface AWSXMLDictionaryParser : INSCopying
	{
		// +(AWSXMLDictionaryParser *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		AWSXMLDictionaryParser SharedInstance { get; }

		// @property (assign, nonatomic) BOOL collapseTextNodes;
		[Export ("collapseTextNodes")]
		bool CollapseTextNodes { get; set; }

		// @property (assign, nonatomic) BOOL stripEmptyNodes;
		[Export ("stripEmptyNodes")]
		bool StripEmptyNodes { get; set; }

		// @property (assign, nonatomic) BOOL trimWhiteSpace;
		[Export ("trimWhiteSpace")]
		bool TrimWhiteSpace { get; set; }

		// @property (assign, nonatomic) BOOL alwaysUseArrays;
		[Export ("alwaysUseArrays")]
		bool AlwaysUseArrays { get; set; }

		// @property (assign, nonatomic) BOOL preserveComments;
		[Export ("preserveComments")]
		bool PreserveComments { get; set; }

		// @property (assign, nonatomic) BOOL wrapRootNode;
		[Export ("wrapRootNode")]
		bool WrapRootNode { get; set; }

		// @property (assign, nonatomic) AWSXMLDictionaryAttributesMode attributesMode;
		[Export ("attributesMode", ArgumentSemantic.Assign)]
		AWSXMLDictionaryAttributesMode AttributesMode { get; set; }

		// @property (assign, nonatomic) AWSXMLDictionaryNodeNameMode nodeNameMode;
		[Export ("nodeNameMode", ArgumentSemantic.Assign)]
		AWSXMLDictionaryNodeNameMode NodeNameMode { get; set; }

		// -(NSDictionary *)dictionaryWithParser:(NSXMLParser *)parser;
		[Export ("dictionaryWithParser:")]
		NSDictionary DictionaryWithParser (NSXMLParser parser);

		// -(NSDictionary *)dictionaryWithData:(NSData *)data;
		[Export ("dictionaryWithData:")]
		NSDictionary DictionaryWithData (NSData data);

		// -(NSDictionary *)dictionaryWithString:(NSString *)string;
		[Export ("dictionaryWithString:")]
		NSDictionary DictionaryWithString (string @string);

		// -(NSDictionary *)dictionaryWithFile:(NSString *)path;
		[Export ("dictionaryWithFile:")]
		NSDictionary DictionaryWithFile (string path);
	}

	// @interface AWSXMLDictionary (NSDictionary)
	[Category]
	[BaseType (typeof(NSDictionary))]
	interface NSDictionary_AWSXMLDictionary
	{
		// +(NSDictionary *)awsxml_dictionaryWithXMLParser:(NSXMLParser *)parser;
		[Static]
		[Export ("awsxml_dictionaryWithXMLParser:")]
		NSDictionary Awsxml_dictionaryWithXMLParser (NSXMLParser parser);

		// +(NSDictionary *)awsxml_dictionaryWithXMLData:(NSData *)data;
		[Static]
		[Export ("awsxml_dictionaryWithXMLData:")]
		NSDictionary Awsxml_dictionaryWithXMLData (NSData data);

		// +(NSDictionary *)awsxml_dictionaryWithXMLString:(NSString *)string;
		[Static]
		[Export ("awsxml_dictionaryWithXMLString:")]
		NSDictionary Awsxml_dictionaryWithXMLString (string @string);

		// +(NSDictionary *)awsxml_dictionaryWithXMLFile:(NSString *)path;
		[Static]
		[Export ("awsxml_dictionaryWithXMLFile:")]
		NSDictionary Awsxml_dictionaryWithXMLFile (string path);

		// -(NSDictionary *)awsxml_attributes;
		[Export ("awsxml_attributes")]
		[Verify (MethodToProperty)]
		NSDictionary Awsxml_attributes { get; }

		// -(NSDictionary *)awsxml_childNodes;
		[Export ("awsxml_childNodes")]
		[Verify (MethodToProperty)]
		NSDictionary Awsxml_childNodes { get; }

		// -(NSArray *)awsxml_comments;
		[Export ("awsxml_comments")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Awsxml_comments { get; }

		// -(NSString *)awsxml_nodeName;
		[Export ("awsxml_nodeName")]
		[Verify (MethodToProperty)]
		string Awsxml_nodeName { get; }

		// -(NSString *)awsxml_innerText;
		[Export ("awsxml_innerText")]
		[Verify (MethodToProperty)]
		string Awsxml_innerText { get; }

		// -(NSString *)awsxml_innerXML;
		[Export ("awsxml_innerXML")]
		[Verify (MethodToProperty)]
		string Awsxml_innerXML { get; }

		// -(NSString *)awsxml_XMLString;
		[Export ("awsxml_XMLString")]
		[Verify (MethodToProperty)]
		string Awsxml_XMLString { get; }

		// -(NSArray *)awsxml_arrayValueForKeyPath:(NSString *)keyPath;
		[Export ("awsxml_arrayValueForKeyPath:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Awsxml_arrayValueForKeyPath (string keyPath);

		// -(NSString *)awsxml_stringValueForKeyPath:(NSString *)keyPath;
		[Export ("awsxml_stringValueForKeyPath:")]
		string Awsxml_stringValueForKeyPath (string keyPath);

		// -(NSDictionary *)awsxml_dictionaryValueForKeyPath:(NSString *)keyPath;
		[Export ("awsxml_dictionaryValueForKeyPath:")]
		NSDictionary Awsxml_dictionaryValueForKeyPath (string keyPath);
	}

	// @interface AWSXMLDictionary (NSString)
	[Category]
	[BaseType (typeof(NSString))]
	interface NSString_AWSXMLDictionary
	{
		// -(NSString *)awsxml_XMLEncodedString;
		[Export ("awsxml_XMLEncodedString")]
		[Verify (MethodToProperty)]
		string Awsxml_XMLEncodedString { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSXMLBuilderErrorDomain;
		[Field ("AWSXMLBuilderErrorDomain", "__Internal")]
		NSString AWSXMLBuilderErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSXMLParserErrorDomain;
		[Field ("AWSXMLParserErrorDomain", "__Internal")]
		NSString AWSXMLParserErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSQueryParamBuilderErrorDomain;
		[Field ("AWSQueryParamBuilderErrorDomain", "__Internal")]
		NSString AWSQueryParamBuilderErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSEC2ParamBuilderErrorDomain;
		[Field ("AWSEC2ParamBuilderErrorDomain", "__Internal")]
		NSString AWSEC2ParamBuilderErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSJSONBuilderErrorDomain;
		[Field ("AWSJSONBuilderErrorDomain", "__Internal")]
		NSString AWSJSONBuilderErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSJSONParserErrorDomain;
		[Field ("AWSJSONParserErrorDomain", "__Internal")]
		NSString AWSJSONParserErrorDomain { get; }
	}

	// @interface AWSJSONDictionary : NSDictionary
	[BaseType (typeof(NSDictionary))]
	interface AWSJSONDictionary
	{
		// -(instancetype)initWithDictionary:(NSDictionary *)otherDictionary JSONDefinitionRule:(NSDictionary *)rule;
		[Export ("initWithDictionary:JSONDefinitionRule:")]
		NativeHandle Constructor (NSDictionary otherDictionary, NSDictionary rule);

		// -(NSUInteger)count;
		[Export ("count")]
		[Verify (MethodToProperty)]
		nuint Count { get; }

		// -(id)objectForKey:(id)aKey;
		[Export ("objectForKey:")]
		NSObject ObjectForKey (NSObject aKey);
	}

	// @interface AWSXMLBuilder : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSXMLBuilder
	{
		// +(NSData *)xmlDataForDictionary:(NSDictionary *)params actionName:(NSString *)actionName serviceDefinitionRule:(NSDictionary *)serviceDefinitionRule error:(NSError **)error;
		[Static]
		[Export ("xmlDataForDictionary:actionName:serviceDefinitionRule:error:")]
		NSData XmlDataForDictionary (NSDictionary @params, string actionName, NSDictionary serviceDefinitionRule, out NSError error);

		// +(NSString *)xmlStringForDictionary:(NSDictionary *)params actionName:(NSString *)actionName serviceDefinitionRule:(NSDictionary *)serviceDefinitionRule error:(NSError **)error;
		[Static]
		[Export ("xmlStringForDictionary:actionName:serviceDefinitionRule:error:")]
		string XmlStringForDictionary (NSDictionary @params, string actionName, NSDictionary serviceDefinitionRule, out NSError error);
	}

	// @interface AWSXMLParser : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSXMLParser
	{
		// +(AWSXMLParser *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		AWSXMLParser SharedInstance { get; }

		// -(NSMutableDictionary *)dictionaryForXMLData:(NSData *)data actionName:(NSString *)actionName serviceDefinitionRule:(NSDictionary *)serviceDefinitionRule error:(NSError **)error;
		[Export ("dictionaryForXMLData:actionName:serviceDefinitionRule:error:")]
		NSMutableDictionary DictionaryForXMLData (NSData data, string actionName, NSDictionary serviceDefinitionRule, out NSError error);
	}

	// @interface AWSQueryParamBuilder : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSQueryParamBuilder
	{
		// +(NSDictionary *)buildFormattedParams:(NSDictionary *)params actionName:(NSString *)actionName serviceDefinitionRule:(NSDictionary *)serviceDefinitionRule error:(NSError **)error;
		[Static]
		[Export ("buildFormattedParams:actionName:serviceDefinitionRule:error:")]
		NSDictionary BuildFormattedParams (NSDictionary @params, string actionName, NSDictionary serviceDefinitionRule, out NSError error);
	}

	// @interface AWSEC2ParamBuilder : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSEC2ParamBuilder
	{
		// +(NSDictionary *)buildFormattedParams:(NSDictionary *)params actionName:(NSString *)actionName serviceDefinitionRule:(NSDictionary *)serviceDefinitionRule error:(NSError **)error;
		[Static]
		[Export ("buildFormattedParams:actionName:serviceDefinitionRule:error:")]
		NSDictionary BuildFormattedParams (NSDictionary @params, string actionName, NSDictionary serviceDefinitionRule, out NSError error);
	}

	// @interface AWSJSONBuilder : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSJSONBuilder
	{
		// +(NSData *)jsonDataForDictionary:(NSDictionary *)params actionName:(NSString *)actionName serviceDefinitionRule:(NSDictionary *)serviceDefinitionRule error:(NSError **)error;
		[Static]
		[Export ("jsonDataForDictionary:actionName:serviceDefinitionRule:error:")]
		NSData JsonDataForDictionary (NSDictionary @params, string actionName, NSDictionary serviceDefinitionRule, out NSError error);
	}

	// @interface AWSJSONParser : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSJSONParser
	{
		// +(NSDictionary *)dictionaryForJsonData:(NSData *)data response:(NSHTTPURLResponse *)response actionName:(NSString *)actionName serviceDefinitionRule:(NSDictionary *)serviceDefinitionRule error:(NSError **)error;
		[Static]
		[Export ("dictionaryForJsonData:response:actionName:serviceDefinitionRule:error:")]
		NSDictionary DictionaryForJsonData (NSData data, NSHttpUrlResponse response, string actionName, NSDictionary serviceDefinitionRule, out NSError error);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSTimestampSerializationErrorDomain;
		[Field ("AWSTimestampSerializationErrorDomain", "__Internal")]
		NSString AWSTimestampSerializationErrorDomain { get; }
	}

	// @interface AWSTimestampSerialization : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSTimestampSerialization
	{
		// +(NSString * _Nullable)serializeTimestamp:(NSDictionary * _Nonnull)rules value:(NSDate * _Nonnull)value error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("serializeTimestamp:value:error:")]
		[return: NullAllowed]
		string SerializeTimestamp (NSDictionary rules, NSDate value, [NullAllowed] out NSError error);

		// +(NSDate * _Nullable)parseTimestamp:(id _Nonnull)value;
		[Static]
		[Export ("parseTimestamp:")]
		[return: NullAllowed]
		NSDate ParseTimestamp (NSObject value);
	}

	// @interface AWSJSONTimestampSerialization : AWSTimestampSerialization
	[BaseType (typeof(AWSTimestampSerialization))]
	interface AWSJSONTimestampSerialization
	{
	}

	// @interface AWSXMLTimestampSerialization : AWSTimestampSerialization
	[BaseType (typeof(AWSTimestampSerialization))]
	interface AWSXMLTimestampSerialization
	{
	}

	// @interface AWSQueryTimestampSerialization : AWSTimestampSerialization
	[BaseType (typeof(AWSTimestampSerialization))]
	interface AWSQueryTimestampSerialization
	{
	}

	// @interface AWSEC2TimestampSerialization : AWSTimestampSerialization
	[BaseType (typeof(AWSTimestampSerialization))]
	interface AWSEC2TimestampSerialization
	{
	}

	// @interface AWSJSONRequestSerializer : NSObject <AWSURLRequestSerializer>
	[BaseType (typeof(NSObject))]
	interface AWSJSONRequestSerializer : IAWSURLRequestSerializer
	{
		// -(instancetype)initWithJSONDefinition:(NSDictionary *)JSONDefinition actionName:(NSString *)actionName;
		[Export ("initWithJSONDefinition:actionName:")]
		NativeHandle Constructor (NSDictionary JSONDefinition, string actionName);
	}

	// @interface AWSXMLRequestSerializer : NSObject <AWSURLRequestSerializer>
	[BaseType (typeof(NSObject))]
	interface AWSXMLRequestSerializer : IAWSURLRequestSerializer
	{
		// -(instancetype)initWithJSONDefinition:(NSDictionary *)JSONDefinition actionName:(NSString *)actionName;
		[Export ("initWithJSONDefinition:actionName:")]
		NativeHandle Constructor (NSDictionary JSONDefinition, string actionName);

		// +(BOOL)constructURIandHeadersAndBody:(NSMutableURLRequest *)request rules:(AWSJSONDictionary *)rules parameters:(NSDictionary *)params uriSchema:(NSString *)uriSchema hostPrefix:(NSString *)hostPrefix error:(NSError **)error;
		[Static]
		[Export ("constructURIandHeadersAndBody:rules:parameters:uriSchema:hostPrefix:error:")]
		bool ConstructURIandHeadersAndBody (NSMutableUrlRequest request, AWSJSONDictionary rules, NSDictionary @params, string uriSchema, string hostPrefix, out NSError error);
	}

	// @interface AWSQueryStringRequestSerializer : NSObject <AWSURLRequestSerializer>
	[BaseType (typeof(NSObject))]
	interface AWSQueryStringRequestSerializer : IAWSURLRequestSerializer
	{
		// -(instancetype)initWithJSONDefinition:(NSDictionary *)JSONDefinition actionName:(NSString *)actionName;
		[Export ("initWithJSONDefinition:actionName:")]
		NativeHandle Constructor (NSDictionary JSONDefinition, string actionName);

		// @property (nonatomic, strong) NSDictionary * additionalParameters;
		[Export ("additionalParameters", ArgumentSemantic.Strong)]
		NSDictionary AdditionalParameters { get; set; }
	}

	// @interface AWSJSONResponseSerializer : NSObject <AWSHTTPURLResponseSerializer>
	[BaseType (typeof(NSObject))]
	interface AWSJSONResponseSerializer : IAWSHTTPURLResponseSerializer
	{
		// @property (readonly, nonatomic, strong) NSDictionary * serviceDefinitionJSON;
		[Export ("serviceDefinitionJSON", ArgumentSemantic.Strong)]
		NSDictionary ServiceDefinitionJSON { get; }

		// @property (readonly, nonatomic, strong) NSString * actionName;
		[Export ("actionName", ArgumentSemantic.Strong)]
		string ActionName { get; }

		// @property (readonly, assign, nonatomic) Class outputClass;
		[Export ("outputClass", ArgumentSemantic.Assign)]
		Class OutputClass { get; }

		// -(instancetype)initWithJSONDefinition:(NSDictionary *)JSONDefinition actionName:(NSString *)actionName outputClass:(Class)outputClass;
		[Export ("initWithJSONDefinition:actionName:outputClass:")]
		NativeHandle Constructor (NSDictionary JSONDefinition, string actionName, Class outputClass);
	}

	// @interface AWSXMLResponseSerializer : NSObject <AWSHTTPURLResponseSerializer>
	[BaseType (typeof(NSObject))]
	interface AWSXMLResponseSerializer : IAWSHTTPURLResponseSerializer
	{
		// @property (assign, nonatomic) Class outputClass;
		[Export ("outputClass", ArgumentSemantic.Assign)]
		Class OutputClass { get; set; }

		// -(instancetype)initWithJSONDefinition:(NSDictionary *)JSONDefinition actionName:(NSString *)actionName outputClass:(Class)outputClass;
		[Export ("initWithJSONDefinition:actionName:outputClass:")]
		NativeHandle Constructor (NSDictionary JSONDefinition, string actionName, Class outputClass);

		// +(NSMutableDictionary *)parseResponse:(NSHTTPURLResponse *)response rules:(AWSJSONDictionary *)rules bodyDictionary:(NSMutableDictionary *)bodyDictionary error:(NSError **)error;
		[Static]
		[Export ("parseResponse:rules:bodyDictionary:error:")]
		NSMutableDictionary ParseResponse (NSHttpUrlResponse response, AWSJSONDictionary rules, NSMutableDictionary bodyDictionary, out NSError error);
	}

	// @interface AWSURLSessionManager : NSObject <NSURLSessionDelegate, NSURLSessionDataDelegate>
	[BaseType (typeof(NSObject))]
	interface AWSURLSessionManager : INSUrlSessionDelegate, INSUrlSessionDataDelegate
	{
		// @property (nonatomic, strong) AWSNetworkingConfiguration * configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		AWSNetworkingConfiguration Configuration { get; set; }

		// -(instancetype)initWithConfiguration:(AWSNetworkingConfiguration *)configuration;
		[Export ("initWithConfiguration:")]
		NativeHandle Constructor (AWSNetworkingConfiguration configuration);

		// -(AWSTask *)dataTaskWithRequest:(AWSNetworkingRequest *)request;
		[Export ("dataTaskWithRequest:")]
		AWSTask DataTaskWithRequest (AWSNetworkingRequest request);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSSignatureV4Algorithm;
		[Field ("AWSSignatureV4Algorithm", "__Internal")]
		NSString AWSSignatureV4Algorithm { get; }

		// extern NSString *const _Nonnull AWSSignatureV4Terminator;
		[Field ("AWSSignatureV4Terminator", "__Internal")]
		NSString AWSSignatureV4Terminator { get; }
	}

	// @interface AWSSignatureSignerUtility : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSSignatureSignerUtility
	{
		// +(NSData * _Nonnull)sha256HMacWithData:(NSData * _Nullable)data withKey:(NSData * _Nonnull)key;
		[Static]
		[Export ("sha256HMacWithData:withKey:")]
		NSData Sha256HMacWithData ([NullAllowed] NSData data, NSData key);

		// +(NSString * _Nonnull)hashString:(NSString * _Nullable)stringToHash;
		[Static]
		[Export ("hashString:")]
		string HashString ([NullAllowed] string stringToHash);

		// +(NSData * _Nonnull)hash:(NSData * _Nullable)dataToHash __attribute__((deprecated("Use hashData instead.")));
		[Static]
		[Export ("hash:")]
		NSData Hash ([NullAllowed] NSData dataToHash);

		// +(NSData * _Nullable)hashData:(NSData * _Nullable)dataToHash;
		[Static]
		[Export ("hashData:")]
		[return: NullAllowed]
		NSData HashData ([NullAllowed] NSData dataToHash);

		// +(NSString * _Nonnull)hexEncode:(NSString * _Nullable)string;
		[Static]
		[Export ("hexEncode:")]
		string HexEncode ([NullAllowed] string @string);

		// +(NSString * _Nullable)HMACSign:(NSData * _Nullable)data withKey:(NSString * _Nonnull)key usingAlgorithm:(uint32_t)algorithm;
		[Static]
		[Export ("HMACSign:withKey:usingAlgorithm:")]
		[return: NullAllowed]
		string HMACSign ([NullAllowed] NSData data, string key, uint algorithm);
	}

	// @interface AWSSignatureV4Signer : NSObject <AWSNetworkingRequestInterceptor>
	[BaseType (typeof(NSObject))]
	interface AWSSignatureV4Signer : IAWSNetworkingRequestInterceptor
	{
		// @property (readonly, nonatomic, strong) id<AWSCredentialsProvider> _Nonnull credentialsProvider;
		[Export ("credentialsProvider", ArgumentSemantic.Strong)]
		AWSCredentialsProvider CredentialsProvider { get; }

		// -(instancetype _Nonnull)initWithCredentialsProvider:(id<AWSCredentialsProvider> _Nonnull)credentialsProvider endpoint:(AWSEndpoint * _Nonnull)endpoint;
		[Export ("initWithCredentialsProvider:endpoint:")]
		NativeHandle Constructor (AWSCredentialsProvider credentialsProvider, AWSEndpoint endpoint);

		// +(AWSTask<NSURL *> * _Nonnull)generateQueryStringForSignatureV4WithCredentialProvider:(id<AWSCredentialsProvider> _Nonnull)credentialsProvider httpMethod:(AWSHTTPMethod)httpMethod expireDuration:(int32_t)expireDuration endpoint:(AWSEndpoint * _Nonnull)endpoint keyPath:(NSString * _Nullable)keyPath requestHeaders:(NSDictionary<NSString *,NSString *> * _Nullable)requestHeaders requestParameters:(NSDictionary<NSString *,id> * _Nullable)requestParameters signBody:(BOOL)signBody;
		[Static]
		[Export ("generateQueryStringForSignatureV4WithCredentialProvider:httpMethod:expireDuration:endpoint:keyPath:requestHeaders:requestParameters:signBody:")]
		AWSTask<NSURL> GenerateQueryStringForSignatureV4WithCredentialProvider (AWSCredentialsProvider credentialsProvider, AWSHTTPMethod httpMethod, int expireDuration, AWSEndpoint endpoint, [NullAllowed] string keyPath, [NullAllowed] NSDictionary<NSString, NSString> requestHeaders, [NullAllowed] NSDictionary<NSString, NSObject> requestParameters, bool signBody);

		// +(AWSTask<NSURL *> * _Nonnull)sigV4SignedURLWithRequest:(NSURLRequest * _Nonnull)request credentialProvider:(id<AWSCredentialsProvider> _Nonnull)credentialsProvider regionName:(NSString * _Nonnull)regionName serviceName:(NSString * _Nonnull)serviceName date:(NSDate * _Nonnull)date expireDuration:(int32_t)expireDuration signBody:(BOOL)signBody signSessionToken:(BOOL)signSessionToken;
		[Static]
		[Export ("sigV4SignedURLWithRequest:credentialProvider:regionName:serviceName:date:expireDuration:signBody:signSessionToken:")]
		AWSTask<NSURL> SigV4SignedURLWithRequest (NSUrlRequest request, AWSCredentialsProvider credentialsProvider, string regionName, string serviceName, NSDate date, int expireDuration, bool signBody, bool signSessionToken);

		// +(NSString * _Nonnull)getCanonicalizedRequest:(NSString * _Nonnull)method path:(NSString * _Nonnull)path query:(NSString * _Nullable)query headers:(NSDictionary * _Nullable)headers contentSha256:(NSString * _Nullable)contentSha256;
		[Static]
		[Export ("getCanonicalizedRequest:path:query:headers:contentSha256:")]
		string GetCanonicalizedRequest (string method, string path, [NullAllowed] string query, [NullAllowed] NSDictionary headers, [NullAllowed] string contentSha256);

		// +(NSData * _Nonnull)getV4DerivedKey:(NSString * _Nullable)secret date:(NSString * _Nullable)dateStamp region:(NSString * _Nullable)regionName service:(NSString * _Nullable)serviceName;
		[Static]
		[Export ("getV4DerivedKey:date:region:service:")]
		NSData GetV4DerivedKey ([NullAllowed] string secret, [NullAllowed] string dateStamp, [NullAllowed] string regionName, [NullAllowed] string serviceName);

		// +(NSString * _Nonnull)getSignedHeadersString:(NSDictionary * _Nullable)headers;
		[Static]
		[Export ("getSignedHeadersString:")]
		string GetSignedHeadersString ([NullAllowed] NSDictionary headers);
	}

	// @interface AWSSignatureV2Signer : NSObject <AWSNetworkingRequestInterceptor>
	[BaseType (typeof(NSObject))]
	interface AWSSignatureV2Signer : IAWSNetworkingRequestInterceptor
	{
		// @property (readonly, nonatomic, strong) id<AWSCredentialsProvider> _Nullable credentialsProvider;
		[NullAllowed, Export ("credentialsProvider", ArgumentSemantic.Strong)]
		AWSCredentialsProvider CredentialsProvider { get; }

		// +(instancetype _Nonnull)signerWithCredentialsProvider:(id<AWSCredentialsProvider> _Nonnull)credentialsProvider endpoint:(AWSEndpoint * _Nonnull)endpoint;
		[Static]
		[Export ("signerWithCredentialsProvider:endpoint:")]
		AWSSignatureV2Signer SignerWithCredentialsProvider (AWSCredentialsProvider credentialsProvider, AWSEndpoint endpoint);

		// -(instancetype _Nonnull)initWithCredentialsProvider:(id<AWSCredentialsProvider> _Nonnull)credentialsProvider endpoint:(AWSEndpoint * _Nonnull)endpoint;
		[Export ("initWithCredentialsProvider:endpoint:")]
		NativeHandle Constructor (AWSCredentialsProvider credentialsProvider, AWSEndpoint endpoint);
	}

	// @interface AWSS3ChunkedEncodingInputStream : NSInputStream <NSStreamDelegate>
	[BaseType (typeof(NSInputStream))]
	interface AWSS3ChunkedEncodingInputStream : INSStreamDelegate
	{
		// @property (assign, atomic) int64_t totalLengthOfChunkSignatureSent;
		[Export ("totalLengthOfChunkSignatureSent")]
		long TotalLengthOfChunkSignatureSent { get; set; }

		// -(instancetype _Nonnull)initWithInputStream:(NSInputStream * _Nonnull)stream date:(NSDate * _Nullable)date scope:(NSString * _Nullable)scope kSigning:(NSData * _Nullable)kSigning headerSignature:(NSString * _Nullable)headerSignature;
		[Export ("initWithInputStream:date:scope:kSigning:headerSignature:")]
		NativeHandle Constructor (NSInputStream stream, [NullAllowed] NSDate date, [NullAllowed] string scope, [NullAllowed] NSData kSigning, [NullAllowed] string headerSignature);

		// +(NSUInteger)computeContentLengthForChunkedData:(NSUInteger)dataLength;
		[Static]
		[Export ("computeContentLengthForChunkedData:")]
		nuint ComputeContentLengthForChunkedData (nuint dataLength);
	}

	// @interface AWSURLRequestRetryHandler : NSObject <AWSURLRequestRetryHandler>
	[BaseType (typeof(NSObject))]
	interface AWSURLRequestRetryHandler : IAWSURLRequestRetryHandler
	{
		// @property (assign, nonatomic) uint32_t maxRetryCount;
		[Export ("maxRetryCount")]
		uint MaxRetryCount { get; set; }

		// -(instancetype)initWithMaximumRetryCount:(uint32_t)maxRetryCount;
		[Export ("initWithMaximumRetryCount:")]
		NativeHandle Constructor (uint maxRetryCount);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AWSValidationErrorDomain;
		[Field ("AWSValidationErrorDomain", "__Internal")]
		NSString AWSValidationErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSInfoDefault;
		[Field ("AWSInfoDefault", "__Internal")]
		NSString AWSInfoDefault { get; }
	}

	// @interface AWSInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSInfo
	{
		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nonnull rootInfoDictionary;
		[Export ("rootInfoDictionary")]
		NSDictionary<NSString, NSObject> RootInfoDictionary { get; }

		// +(instancetype _Nonnull)defaultAWSInfo;
		[Static]
		[Export ("defaultAWSInfo")]
		AWSInfo DefaultAWSInfo ();

		// +(void)configureDefaultAWSInfo:(NSDictionary<NSString *,id> * _Nonnull)config;
		[Static]
		[Export ("configureDefaultAWSInfo:")]
		void ConfigureDefaultAWSInfo (NSDictionary<NSString, NSObject> config);

		// +(void)configureIdentityPoolService:(AWSServiceConfiguration * _Nullable)config;
		[Static]
		[Export ("configureIdentityPoolService:")]
		void ConfigureIdentityPoolService ([NullAllowed] AWSServiceConfiguration config);

		// -(AWSServiceInfo * _Nullable)serviceInfo:(NSString * _Nonnull)serviceName forKey:(NSString * _Nonnull)key;
		[Export ("serviceInfo:forKey:")]
		[return: NullAllowed]
		AWSServiceInfo ServiceInfo (string serviceName, string key);

		// -(AWSServiceInfo * _Nullable)defaultServiceInfo:(NSString * _Nonnull)serviceName;
		[Export ("defaultServiceInfo:")]
		[return: NullAllowed]
		AWSServiceInfo DefaultServiceInfo (string serviceName);
	}

	// @interface AWSServiceInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSServiceInfo
	{
		// @property (readonly, nonatomic) AWSCognitoCredentialsProvider * _Nonnull cognitoCredentialsProvider;
		[Export ("cognitoCredentialsProvider")]
		AWSCognitoCredentialsProvider CognitoCredentialsProvider { get; }

		// @property (readonly, nonatomic) AWSRegionType region;
		[Export ("region")]
		AWSRegionType Region { get; }

		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nonnull infoDictionary;
		[Export ("infoDictionary")]
		NSDictionary<NSString, NSObject> InfoDictionary { get; }
	}

	// @interface AWSNSCodingUtilities : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSNSCodingUtilities
	{
		// +(NSData * _Nullable)versionSafeArchivedDataWithRootObject:(id _Nonnull)obj requiringSecureCoding:(BOOL)requireSecureCoding error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("versionSafeArchivedDataWithRootObject:requiringSecureCoding:error:")]
		[return: NullAllowed]
		NSData VersionSafeArchivedDataWithRootObject (NSObject obj, bool requireSecureCoding, [NullAllowed] out NSError error);

		// +(id _Nullable)versionSafeUnarchivedObjectOfClass:(Class _Nonnull)cls fromData:(NSData * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("versionSafeUnarchivedObjectOfClass:fromData:error:")]
		[return: NullAllowed]
		NSObject VersionSafeUnarchivedObjectOfClass (Class cls, NSData data, [NullAllowed] out NSError error);

		// +(id _Nullable)versionSafeUnarchivedObjectOfClasses:(NSSet<Class> * _Nonnull)classes fromData:(NSData * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("versionSafeUnarchivedObjectOfClasses:fromData:error:")]
		[return: NullAllowed]
		NSObject VersionSafeUnarchivedObjectOfClasses (NSSet<Class> classes, NSData data, [NullAllowed] out NSError error);

		// +(NSMutableDictionary * _Nullable)versionSafeMutableDictionaryFromData:(NSData * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("versionSafeMutableDictionaryFromData:error:")]
		[return: NullAllowed]
		NSMutableDictionary VersionSafeMutableDictionaryFromData (NSData data, [NullAllowed] out NSError error);
	}

	// @interface AWSCancellationTokenRegistration : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSCancellationTokenRegistration
	{
		// -(void)dispose;
		[Export ("dispose")]
		void Dispose ();
	}

	// typedef void (^AWSCancellationBlock)();
	delegate void AWSCancellationBlock ();

	// @interface AWSCancellationToken : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSCancellationToken
	{
		// @property (readonly, getter = isCancellationRequested, assign, nonatomic) BOOL cancellationRequested;
		[Export ("cancellationRequested")]
		bool CancellationRequested { [Bind ("isCancellationRequested")] get; }

		// -(AWSCancellationTokenRegistration * _Nonnull)registerCancellationObserverWithBlock:(AWSCancellationBlock _Nonnull)block;
		[Export ("registerCancellationObserverWithBlock:")]
		AWSCancellationTokenRegistration RegisterCancellationObserverWithBlock (AWSCancellationBlock block);
	}

	// @interface AWSCancellationTokenSource : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSCancellationTokenSource
	{
		// +(instancetype _Nonnull)cancellationTokenSource;
		[Static]
		[Export ("cancellationTokenSource")]
		AWSCancellationTokenSource CancellationTokenSource ();

		// @property (readonly, nonatomic, strong) AWSCancellationToken * _Nonnull token;
		[Export ("token", ArgumentSemantic.Strong)]
		AWSCancellationToken Token { get; }

		// @property (readonly, getter = isCancellationRequested, assign, nonatomic) BOOL cancellationRequested;
		[Export ("cancellationRequested")]
		bool CancellationRequested { [Bind ("isCancellationRequested")] get; }

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// -(void)cancelAfterDelay:(int)millis;
		[Export ("cancelAfterDelay:")]
		void CancelAfterDelay (int millis);

		// -(void)dispose;
		[Export ("dispose")]
		void Dispose ();
	}

	// @interface AWSExecutor : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSExecutor
	{
		// +(instancetype _Nonnull)defaultExecutor;
		[Static]
		[Export ("defaultExecutor")]
		AWSExecutor DefaultExecutor ();

		// +(instancetype _Nonnull)immediateExecutor;
		[Static]
		[Export ("immediateExecutor")]
		AWSExecutor ImmediateExecutor ();

		// +(instancetype _Nonnull)mainThreadExecutor;
		[Static]
		[Export ("mainThreadExecutor")]
		AWSExecutor MainThreadExecutor ();

		// +(instancetype _Nonnull)executorWithBlock:(void (^ _Nonnull)(void (^ _Nonnull)(void)))block;
		[Static]
		[Export ("executorWithBlock:")]
		AWSExecutor ExecutorWithBlock (Action<Action> block);

		// +(instancetype _Nonnull)executorWithDispatchQueue:(dispatch_queue_t _Nonnull)queue;
		[Static]
		[Export ("executorWithDispatchQueue:")]
		AWSExecutor ExecutorWithDispatchQueue (DispatchQueue queue);

		// +(instancetype _Nonnull)executorWithOperationQueue:(NSOperationQueue * _Nonnull)queue;
		[Static]
		[Export ("executorWithOperationQueue:")]
		AWSExecutor ExecutorWithOperationQueue (NSOperationQueue queue);

		// -(void)execute:(void (^ _Nonnull)(void))block;
		[Export ("execute:")]
		void Execute (Action block);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSTaskErrorDomain;
		[Field ("AWSTaskErrorDomain", "__Internal")]
		NSString AWSTaskErrorDomain { get; }

		// extern const NSInteger kAWSMultipleErrorsError;
		[Field ("kAWSMultipleErrorsError", "__Internal")]
		nint kAWSMultipleErrorsError { get; }

		// extern NSString *const _Nonnull AWSTaskMultipleErrorsUserInfoKey;
		[Field ("AWSTaskMultipleErrorsUserInfoKey", "__Internal")]
		NSString AWSTaskMultipleErrorsUserInfoKey { get; }
	}

	// audit-objc-generics: @interface AWSTask<__covariant ResultType> : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSTask
	{
		// +(instancetype _Nonnull)taskWithResult:(ResultType _Nullable)result;
		[Static]
		[Export ("taskWithResult:")]
		AWSTask TaskWithResult ([NullAllowed] NSObject result);

		// +(instancetype _Nonnull)taskWithError:(NSError * _Nonnull)error;
		[Static]
		[Export ("taskWithError:")]
		AWSTask TaskWithError (NSError error);

		// +(instancetype _Nonnull)cancelledTask;
		[Static]
		[Export ("cancelledTask")]
		AWSTask CancelledTask ();

		// +(instancetype _Nonnull)taskForCompletionOfAllTasks:(NSArray<AWSTask *> * _Nullable)tasks;
		[Static]
		[Export ("taskForCompletionOfAllTasks:")]
		AWSTask TaskForCompletionOfAllTasks ([NullAllowed] AWSTask[] tasks);

		// +(instancetype _Nonnull)taskForCompletionOfAllTasksWithResults:(NSArray<AWSTask *> * _Nullable)tasks;
		[Static]
		[Export ("taskForCompletionOfAllTasksWithResults:")]
		AWSTask TaskForCompletionOfAllTasksWithResults ([NullAllowed] AWSTask[] tasks);

		// +(instancetype _Nonnull)taskForCompletionOfAnyTask:(NSArray<AWSTask *> * _Nullable)tasks;
		[Static]
		[Export ("taskForCompletionOfAnyTask:")]
		AWSTask TaskForCompletionOfAnyTask ([NullAllowed] AWSTask[] tasks);

		// +(AWSTask<AWSVoid> * _Nonnull)taskWithDelay:(int)millis;
		[Static]
		[Export ("taskWithDelay:")]
		AWSTask<_AWSVoid_Nonexistant> TaskWithDelay (int millis);

		// +(AWSTask<AWSVoid> * _Nonnull)taskWithDelay:(int)millis cancellationToken:(AWSCancellationToken * _Nullable)token;
		[Static]
		[Export ("taskWithDelay:cancellationToken:")]
		AWSTask<_AWSVoid_Nonexistant> TaskWithDelay (int millis, [NullAllowed] AWSCancellationToken token);

		// +(instancetype _Nonnull)taskFromExecutor:(AWSExecutor * _Nonnull)executor withBlock:(id  _Nonnull (^ _Nullable)(void))block;
		[Static]
		[Export ("taskFromExecutor:withBlock:")]
		AWSTask TaskFromExecutor (AWSExecutor executor, [NullAllowed] Func<NSObject> block);

		// @property (readonly, nonatomic, strong) ResultType _Nullable result;
		[NullAllowed, Export ("result", ArgumentSemantic.Strong)]
		NSObject Result { get; }

		// @property (readonly, nonatomic, strong) NSError * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Strong)]
		NSError Error { get; }

		// @property (readonly, getter = isCancelled, assign, nonatomic) BOOL cancelled;
		[Export ("cancelled")]
		bool Cancelled { [Bind ("isCancelled")] get; }

		// @property (readonly, getter = isFaulted, assign, nonatomic) BOOL faulted;
		[Export ("faulted")]
		bool Faulted { [Bind ("isFaulted")] get; }

		// @property (readonly, getter = isCompleted, assign, nonatomic) BOOL completed;
		[Export ("completed")]
		bool Completed { [Bind ("isCompleted")] get; }

		// -(AWSTask * _Nonnull)continueWithBlock:(AWSContinuationBlock _Nonnull)block __attribute__((swift_name("continueWith(block:)")));
		[Export ("continueWithBlock:")]
		AWSTask ContinueWithBlock (AWSContinuationBlock block);

		// -(AWSTask * _Nonnull)continueWithBlock:(AWSContinuationBlock _Nonnull)block cancellationToken:(AWSCancellationToken * _Nullable)cancellationToken __attribute__((swift_name("continueWith(block:cancellationToken:)")));
		[Export ("continueWithBlock:cancellationToken:")]
		AWSTask ContinueWithBlock (AWSContinuationBlock block, [NullAllowed] AWSCancellationToken cancellationToken);

		// -(AWSTask * _Nonnull)continueWithExecutor:(AWSExecutor * _Nonnull)executor withBlock:(AWSContinuationBlock _Nonnull)block __attribute__((swift_name("continueWith(executor:block:)")));
		[Export ("continueWithExecutor:withBlock:")]
		AWSTask ContinueWithExecutor (AWSExecutor executor, AWSContinuationBlock block);

		// -(AWSTask * _Nonnull)continueWithExecutor:(AWSExecutor * _Nonnull)executor block:(AWSContinuationBlock _Nonnull)block cancellationToken:(AWSCancellationToken * _Nullable)cancellationToken __attribute__((swift_name("continueWith(executor:block:cancellationToken:)")));
		[Export ("continueWithExecutor:block:cancellationToken:")]
		AWSTask ContinueWithExecutor (AWSExecutor executor, AWSContinuationBlock block, [NullAllowed] AWSCancellationToken cancellationToken);

		// -(AWSTask * _Nonnull)continueWithSuccessBlock:(AWSContinuationBlock _Nonnull)block __attribute__((swift_name("continueOnSuccessWith(block:)")));
		[Export ("continueWithSuccessBlock:")]
		AWSTask ContinueWithSuccessBlock (AWSContinuationBlock block);

		// -(AWSTask * _Nonnull)continueWithSuccessBlock:(AWSContinuationBlock _Nonnull)block cancellationToken:(AWSCancellationToken * _Nullable)cancellationToken __attribute__((swift_name("continueOnSuccessWith(block:cancellationToken:)")));
		[Export ("continueWithSuccessBlock:cancellationToken:")]
		AWSTask ContinueWithSuccessBlock (AWSContinuationBlock block, [NullAllowed] AWSCancellationToken cancellationToken);

		// -(AWSTask * _Nonnull)continueWithExecutor:(AWSExecutor * _Nonnull)executor withSuccessBlock:(AWSContinuationBlock _Nonnull)block __attribute__((swift_name("continueOnSuccessWith(executor:block:)")));
		[Export ("continueWithExecutor:withSuccessBlock:")]
		AWSTask ContinueWithExecutor (AWSExecutor executor, AWSContinuationBlock block);

		// -(AWSTask * _Nonnull)continueWithExecutor:(AWSExecutor * _Nonnull)executor successBlock:(AWSContinuationBlock _Nonnull)block cancellationToken:(AWSCancellationToken * _Nullable)cancellationToken __attribute__((swift_name("continueOnSuccessWith(executor:block:cancellationToken:)")));
		[Export ("continueWithExecutor:successBlock:cancellationToken:")]
		AWSTask ContinueWithExecutor (AWSExecutor executor, AWSContinuationBlock block, [NullAllowed] AWSCancellationToken cancellationToken);

		// -(void)waitUntilFinished;
		[Export ("waitUntilFinished")]
		void WaitUntilFinished ();
	}

	// typedef id _Nullable (^AWSContinuationBlock)(AWSTask<ResultType> * _Nonnull);
	delegate NSObject AWSContinuationBlock (AWSTask<NSObject> arg0);

	// audit-objc-generics: @interface AWSTaskCompletionSource<__covariant ResultType> : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSTaskCompletionSource
	{
		// +(instancetype _Nonnull)taskCompletionSource;
		[Static]
		[Export ("taskCompletionSource")]
		AWSTaskCompletionSource TaskCompletionSource ();

		// @property (readonly, nonatomic, strong) AWSTask<ResultType> * _Nonnull task;
		[Export ("task", ArgumentSemantic.Strong)]
		AWSTask<NSObject> Task { get; }

		// -(void)setResult:(ResultType _Nullable)result __attribute__((swift_name("set(result:)")));
		[Export ("setResult:")]
		void SetResult ([NullAllowed] NSObject result);

		// -(void)setError:(NSError * _Nonnull)error __attribute__((swift_name("set(error:)")));
		[Export ("setError:")]
		void SetError (NSError error);

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// -(BOOL)trySetResult:(ResultType _Nullable)result __attribute__((swift_name("trySet(result:)")));
		[Export ("trySetResult:")]
		bool TrySetResult ([NullAllowed] NSObject result);

		// -(BOOL)trySetError:(NSError * _Nonnull)error __attribute__((swift_name("trySet(error:)")));
		[Export ("trySetError:")]
		bool TrySetError (NSError error);

		// -(BOOL)trySetCancelled;
		[Export ("trySetCancelled")]
		[Verify (MethodToProperty)]
		bool TrySetCancelled { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSBoltsFrameworkVersionString;
		[Field ("AWSBoltsFrameworkVersionString", "__Internal")]
		NSString AWSBoltsFrameworkVersionString { get; }
	}

	// @interface AWSGZIP (NSData)
	[Category]
	[BaseType (typeof(NSData))]
	interface NSData_AWSGZIP
	{
		// -(NSData *)awsgzip_gzippedDataWithCompressionLevel:(float)level;
		[Export ("awsgzip_gzippedDataWithCompressionLevel:")]
		NSData Awsgzip_gzippedDataWithCompressionLevel (float level);

		// -(NSData *)awsgzip_gzippedData;
		[Export ("awsgzip_gzippedData")]
		[Verify (MethodToProperty)]
		NSData Awsgzip_gzippedData { get; }

		// -(NSData *)awsgzip_gunzippedData;
		[Export ("awsgzip_gunzippedData")]
		[Verify (MethodToProperty)]
		NSData Awsgzip_gunzippedData { get; }
	}

	// @interface AWSFMResultSet : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSFMResultSet
	{
		// @property (retain, atomic) NSString * query;
		[Export ("query", ArgumentSemantic.Retain)]
		string Query { get; set; }

		// @property (readonly) NSMutableDictionary * columnNameToIndexMap;
		[Export ("columnNameToIndexMap")]
		NSMutableDictionary ColumnNameToIndexMap { get; }

		// @property (retain, atomic) AWSFMStatement * statement;
		[Export ("statement", ArgumentSemantic.Retain)]
		AWSFMStatement Statement { get; set; }

		// +(instancetype)resultSetWithStatement:(AWSFMStatement *)statement usingParentDatabase:(AWSFMDatabase *)aDB;
		[Static]
		[Export ("resultSetWithStatement:usingParentDatabase:")]
		AWSFMResultSet ResultSetWithStatement (AWSFMStatement statement, AWSFMDatabase aDB);

		// -(void)close;
		[Export ("close")]
		void Close ();

		// -(void)setParentDB:(AWSFMDatabase *)newDb;
		[Export ("setParentDB:")]
		void SetParentDB (AWSFMDatabase newDb);

		// -(BOOL)next;
		[Export ("next")]
		[Verify (MethodToProperty)]
		bool Next { get; }

		// -(BOOL)nextWithError:(NSError **)outErr;
		[Export ("nextWithError:")]
		bool NextWithError (out NSError outErr);

		// -(BOOL)hasAnotherRow;
		[Export ("hasAnotherRow")]
		[Verify (MethodToProperty)]
		bool HasAnotherRow { get; }

		// -(int)columnCount;
		[Export ("columnCount")]
		[Verify (MethodToProperty)]
		int ColumnCount { get; }

		// -(int)columnIndexForName:(NSString *)columnName;
		[Export ("columnIndexForName:")]
		int ColumnIndexForName (string columnName);

		// -(NSString *)columnNameForIndex:(int)columnIdx;
		[Export ("columnNameForIndex:")]
		string ColumnNameForIndex (int columnIdx);

		// -(int)intForColumn:(NSString *)columnName;
		[Export ("intForColumn:")]
		int IntForColumn (string columnName);

		// -(int)intForColumnIndex:(int)columnIdx;
		[Export ("intForColumnIndex:")]
		int IntForColumnIndex (int columnIdx);

		// -(long)longForColumn:(NSString *)columnName;
		[Export ("longForColumn:")]
		nint LongForColumn (string columnName);

		// -(long)longForColumnIndex:(int)columnIdx;
		[Export ("longForColumnIndex:")]
		nint LongForColumnIndex (int columnIdx);

		// -(long long)longLongIntForColumn:(NSString *)columnName;
		[Export ("longLongIntForColumn:")]
		long LongLongIntForColumn (string columnName);

		// -(long long)longLongIntForColumnIndex:(int)columnIdx;
		[Export ("longLongIntForColumnIndex:")]
		long LongLongIntForColumnIndex (int columnIdx);

		// -(unsigned long long)unsignedLongLongIntForColumn:(NSString *)columnName;
		[Export ("unsignedLongLongIntForColumn:")]
		ulong UnsignedLongLongIntForColumn (string columnName);

		// -(unsigned long long)unsignedLongLongIntForColumnIndex:(int)columnIdx;
		[Export ("unsignedLongLongIntForColumnIndex:")]
		ulong UnsignedLongLongIntForColumnIndex (int columnIdx);

		// -(BOOL)boolForColumn:(NSString *)columnName;
		[Export ("boolForColumn:")]
		bool BoolForColumn (string columnName);

		// -(BOOL)boolForColumnIndex:(int)columnIdx;
		[Export ("boolForColumnIndex:")]
		bool BoolForColumnIndex (int columnIdx);

		// -(double)doubleForColumn:(NSString *)columnName;
		[Export ("doubleForColumn:")]
		double DoubleForColumn (string columnName);

		// -(double)doubleForColumnIndex:(int)columnIdx;
		[Export ("doubleForColumnIndex:")]
		double DoubleForColumnIndex (int columnIdx);

		// -(NSString *)stringForColumn:(NSString *)columnName;
		[Export ("stringForColumn:")]
		string StringForColumn (string columnName);

		// -(NSString *)stringForColumnIndex:(int)columnIdx;
		[Export ("stringForColumnIndex:")]
		string StringForColumnIndex (int columnIdx);

		// -(NSDate *)dateForColumn:(NSString *)columnName;
		[Export ("dateForColumn:")]
		NSDate DateForColumn (string columnName);

		// -(NSDate *)dateForColumnIndex:(int)columnIdx;
		[Export ("dateForColumnIndex:")]
		NSDate DateForColumnIndex (int columnIdx);

		// -(NSData *)dataForColumn:(NSString *)columnName;
		[Export ("dataForColumn:")]
		NSData DataForColumn (string columnName);

		// -(NSData *)dataForColumnIndex:(int)columnIdx;
		[Export ("dataForColumnIndex:")]
		NSData DataForColumnIndex (int columnIdx);

		// -(const unsigned char *)UTF8StringForColumnName:(NSString *)columnName;
		[Export ("UTF8StringForColumnName:")]
		unsafe byte* UTF8StringForColumnName (string columnName);

		// -(const unsigned char *)UTF8StringForColumnIndex:(int)columnIdx;
		[Export ("UTF8StringForColumnIndex:")]
		unsafe byte* UTF8StringForColumnIndex (int columnIdx);

		// -(id)objectForColumnName:(NSString *)columnName;
		[Export ("objectForColumnName:")]
		NSObject ObjectForColumnName (string columnName);

		// -(id)objectForColumnIndex:(int)columnIdx;
		[Export ("objectForColumnIndex:")]
		NSObject ObjectForColumnIndex (int columnIdx);

		// -(id)objectForKeyedSubscript:(NSString *)columnName;
		[Export ("objectForKeyedSubscript:")]
		NSObject ObjectForKeyedSubscript (string columnName);

		// -(id)objectAtIndexedSubscript:(int)columnIdx;
		[Export ("objectAtIndexedSubscript:")]
		NSObject ObjectAtIndexedSubscript (int columnIdx);

		// -(NSData *)dataNoCopyForColumn:(NSString *)columnName __attribute__((ns_returns_not_retained));
		[Export ("dataNoCopyForColumn:")]
		NSData DataNoCopyForColumn (string columnName);

		// -(NSData *)dataNoCopyForColumnIndex:(int)columnIdx __attribute__((ns_returns_not_retained));
		[Export ("dataNoCopyForColumnIndex:")]
		NSData DataNoCopyForColumnIndex (int columnIdx);

		// -(BOOL)columnIndexIsNull:(int)columnIdx;
		[Export ("columnIndexIsNull:")]
		bool ColumnIndexIsNull (int columnIdx);

		// -(BOOL)columnIsNull:(NSString *)columnName;
		[Export ("columnIsNull:")]
		bool ColumnIsNull (string columnName);

		// -(NSDictionary *)resultDictionary;
		[Export ("resultDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary ResultDictionary { get; }

		// -(NSDictionary *)resultDict __attribute__((deprecated("")));
		[Export ("resultDict")]
		[Verify (MethodToProperty)]
		NSDictionary ResultDict { get; }

		// -(void)kvcMagic:(id)object;
		[Export ("kvcMagic:")]
		void KvcMagic (NSObject @object);
	}

	// @interface AWSFMDatabasePool : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSFMDatabasePool
	{
		// @property (retain, atomic) NSString * path;
		[Export ("path", ArgumentSemantic.Retain)]
		string Path { get; set; }

		[Wrap ("WeakDelegate")]
		NSObject Delegate { get; set; }

		// @property (assign, atomic) id delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, atomic) NSUInteger maximumNumberOfDatabasesToCreate;
		[Export ("maximumNumberOfDatabasesToCreate")]
		nuint MaximumNumberOfDatabasesToCreate { get; set; }

		// @property (readonly, atomic) int openFlags;
		[Export ("openFlags")]
		int OpenFlags { get; }

		// +(instancetype)databasePoolWithPath:(NSString *)aPath;
		[Static]
		[Export ("databasePoolWithPath:")]
		AWSFMDatabasePool DatabasePoolWithPath (string aPath);

		// +(instancetype)databasePoolWithPath:(NSString *)aPath flags:(int)openFlags;
		[Static]
		[Export ("databasePoolWithPath:flags:")]
		AWSFMDatabasePool DatabasePoolWithPath (string aPath, int openFlags);

		// -(instancetype)initWithPath:(NSString *)aPath;
		[Export ("initWithPath:")]
		NativeHandle Constructor (string aPath);

		// -(instancetype)initWithPath:(NSString *)aPath flags:(int)openFlags;
		[Export ("initWithPath:flags:")]
		NativeHandle Constructor (string aPath, int openFlags);

		// -(NSUInteger)countOfCheckedInDatabases;
		[Export ("countOfCheckedInDatabases")]
		[Verify (MethodToProperty)]
		nuint CountOfCheckedInDatabases { get; }

		// -(NSUInteger)countOfCheckedOutDatabases;
		[Export ("countOfCheckedOutDatabases")]
		[Verify (MethodToProperty)]
		nuint CountOfCheckedOutDatabases { get; }

		// -(NSUInteger)countOfOpenDatabases;
		[Export ("countOfOpenDatabases")]
		[Verify (MethodToProperty)]
		nuint CountOfOpenDatabases { get; }

		// -(void)releaseAllDatabases;
		[Export ("releaseAllDatabases")]
		void ReleaseAllDatabases ();

		// -(void)inDatabase:(void (^)(AWSFMDatabase *))block;
		[Export ("inDatabase:")]
		void InDatabase (Action<AWSFMDatabase> block);

		// -(void)inTransaction:(void (^)(AWSFMDatabase *, BOOL *))block;
		[Export ("inTransaction:")]
		unsafe void InTransaction (Action<AWSFMDatabase, bool*> block);

		// -(void)inDeferredTransaction:(void (^)(AWSFMDatabase *, BOOL *))block;
		[Export ("inDeferredTransaction:")]
		unsafe void InDeferredTransaction (Action<AWSFMDatabase, bool*> block);

		// -(NSError *)inSavePoint:(void (^)(AWSFMDatabase *, BOOL *))block;
		[Export ("inSavePoint:")]
		unsafe NSError InSavePoint (Action<AWSFMDatabase, bool*> block);
	}

	// @interface AWSFMDatabasePoolDelegate (NSObject)
	[Category]
	[BaseType (typeof(NSObject))]
	interface NSObject_AWSFMDatabasePoolDelegate
	{
		// -(BOOL)databasePool:(AWSFMDatabasePool *)pool shouldAddDatabaseToPool:(AWSFMDatabase *)database;
		[Export ("databasePool:shouldAddDatabaseToPool:")]
		bool DatabasePool (AWSFMDatabasePool pool, AWSFMDatabase database);

		// -(void)databasePool:(AWSFMDatabasePool *)pool didAddDatabase:(AWSFMDatabase *)database;
		[Export ("databasePool:didAddDatabase:")]
		void DatabasePool (AWSFMDatabasePool pool, AWSFMDatabase database);
	}

	// typedef int (^AWSFMDBExecuteStatementsCallbackBlock)(NSDictionary *);
	delegate int AWSFMDBExecuteStatementsCallbackBlock (NSDictionary arg0);

	// @interface AWSFMDatabase : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSFMDatabase
	{
		// @property (assign, atomic) BOOL traceExecution;
		[Export ("traceExecution")]
		bool TraceExecution { get; set; }

		// @property (assign, atomic) BOOL checkedOut;
		[Export ("checkedOut")]
		bool CheckedOut { get; set; }

		// @property (assign, atomic) BOOL crashOnErrors;
		[Export ("crashOnErrors")]
		bool CrashOnErrors { get; set; }

		// @property (assign, atomic) BOOL logsErrors;
		[Export ("logsErrors")]
		bool LogsErrors { get; set; }

		// @property (retain, atomic) NSMutableDictionary * cachedStatements;
		[Export ("cachedStatements", ArgumentSemantic.Retain)]
		NSMutableDictionary CachedStatements { get; set; }

		// +(instancetype)databaseWithPath:(NSString *)inPath;
		[Static]
		[Export ("databaseWithPath:")]
		AWSFMDatabase DatabaseWithPath (string inPath);

		// -(instancetype)initWithPath:(NSString *)inPath;
		[Export ("initWithPath:")]
		NativeHandle Constructor (string inPath);

		// -(BOOL)open;
		[Export ("open")]
		[Verify (MethodToProperty)]
		bool Open { get; }

		// -(BOOL)openWithFlags:(int)flags;
		[Export ("openWithFlags:")]
		bool OpenWithFlags (int flags);

		// -(BOOL)openWithFlags:(int)flags vfs:(NSString *)vfsName;
		[Export ("openWithFlags:vfs:")]
		bool OpenWithFlags (int flags, string vfsName);

		// -(BOOL)close;
		[Export ("close")]
		[Verify (MethodToProperty)]
		bool Close { get; }

		// -(BOOL)goodConnection;
		[Export ("goodConnection")]
		[Verify (MethodToProperty)]
		bool GoodConnection { get; }

		// -(BOOL)executeUpdate:(NSString *)sql withErrorAndBindings:(NSError **)outErr, ...;
		[Internal]
		[Export ("executeUpdate:withErrorAndBindings:", IsVariadic = true)]
		bool ExecuteUpdate (string sql, out NSError outErr, IntPtr varArgs);

		// -(BOOL)update:(NSString *)sql withErrorAndBindings:(NSError **)outErr, ... __attribute__((deprecated("")));
		[Internal]
		[Export ("update:withErrorAndBindings:", IsVariadic = true)]
		bool Update (string sql, out NSError outErr, IntPtr varArgs);

		// -(BOOL)executeUpdate:(NSString *)sql, ...;
		[Internal]
		[Export ("executeUpdate:", IsVariadic = true)]
		bool ExecuteUpdate (string sql, IntPtr varArgs);

		// -(BOOL)executeUpdateWithFormat:(NSString *)format, ... __attribute__((format(NSString, 1, 2)));
		[Internal]
		[Export ("executeUpdateWithFormat:", IsVariadic = true)]
		bool ExecuteUpdateWithFormat (string format, IntPtr varArgs);

		// -(BOOL)executeUpdate:(NSString *)sql withArgumentsInArray:(NSArray *)arguments;
		[Export ("executeUpdate:withArgumentsInArray:")]
		[Verify (StronglyTypedNSArray)]
		bool ExecuteUpdate (string sql, NSObject[] arguments);

		// -(BOOL)executeUpdate:(NSString *)sql withParameterDictionary:(NSDictionary *)arguments;
		[Export ("executeUpdate:withParameterDictionary:")]
		bool ExecuteUpdate (string sql, NSDictionary arguments);

		// -(BOOL)executeUpdate:(NSString *)sql withVAList:(va_list)args;
		[Export ("executeUpdate:withVAList:")]
		unsafe bool ExecuteUpdate (string sql, sbyte* args);

		// -(BOOL)executeStatements:(NSString *)sql;
		[Export ("executeStatements:")]
		bool ExecuteStatements (string sql);

		// -(BOOL)executeStatements:(NSString *)sql withResultBlock:(AWSFMDBExecuteStatementsCallbackBlock)block;
		[Export ("executeStatements:withResultBlock:")]
		bool ExecuteStatements (string sql, AWSFMDBExecuteStatementsCallbackBlock block);

		// -(long long)lastInsertRowId;
		[Export ("lastInsertRowId")]
		[Verify (MethodToProperty)]
		long LastInsertRowId { get; }

		// -(int)changes;
		[Export ("changes")]
		[Verify (MethodToProperty)]
		int Changes { get; }

		// -(AWSFMResultSet *)executeQuery:(NSString *)sql, ...;
		[Internal]
		[Export ("executeQuery:", IsVariadic = true)]
		AWSFMResultSet ExecuteQuery (string sql, IntPtr varArgs);

		// -(AWSFMResultSet *)executeQueryWithFormat:(NSString *)format, ... __attribute__((format(NSString, 1, 2)));
		[Internal]
		[Export ("executeQueryWithFormat:", IsVariadic = true)]
		AWSFMResultSet ExecuteQueryWithFormat (string format, IntPtr varArgs);

		// -(AWSFMResultSet *)executeQuery:(NSString *)sql withArgumentsInArray:(NSArray *)arguments;
		[Export ("executeQuery:withArgumentsInArray:")]
		[Verify (StronglyTypedNSArray)]
		AWSFMResultSet ExecuteQuery (string sql, NSObject[] arguments);

		// -(AWSFMResultSet *)executeQuery:(NSString *)sql withParameterDictionary:(NSDictionary *)arguments;
		[Export ("executeQuery:withParameterDictionary:")]
		AWSFMResultSet ExecuteQuery (string sql, NSDictionary arguments);

		// -(AWSFMResultSet *)executeQuery:(NSString *)sql withVAList:(va_list)args;
		[Export ("executeQuery:withVAList:")]
		unsafe AWSFMResultSet ExecuteQuery (string sql, sbyte* args);

		// -(BOOL)beginTransaction;
		[Export ("beginTransaction")]
		[Verify (MethodToProperty)]
		bool BeginTransaction { get; }

		// -(BOOL)beginDeferredTransaction;
		[Export ("beginDeferredTransaction")]
		[Verify (MethodToProperty)]
		bool BeginDeferredTransaction { get; }

		// -(BOOL)commit;
		[Export ("commit")]
		[Verify (MethodToProperty)]
		bool Commit { get; }

		// -(BOOL)rollback;
		[Export ("rollback")]
		[Verify (MethodToProperty)]
		bool Rollback { get; }

		// -(BOOL)inTransaction;
		[Export ("inTransaction")]
		[Verify (MethodToProperty)]
		bool InTransaction { get; }

		// -(void)clearCachedStatements;
		[Export ("clearCachedStatements")]
		void ClearCachedStatements ();

		// -(void)closeOpenResultSets;
		[Export ("closeOpenResultSets")]
		void CloseOpenResultSets ();

		// -(BOOL)hasOpenResultSets;
		[Export ("hasOpenResultSets")]
		[Verify (MethodToProperty)]
		bool HasOpenResultSets { get; }

		// -(BOOL)shouldCacheStatements;
		// -(void)setShouldCacheStatements:(BOOL)value;
		[Export ("shouldCacheStatements")]
		[Verify (MethodToProperty)]
		bool ShouldCacheStatements { get; set; }

		// -(BOOL)setKey:(NSString *)key;
		[Export ("setKey:")]
		bool SetKey (string key);

		// -(BOOL)rekey:(NSString *)key;
		[Export ("rekey:")]
		bool Rekey (string key);

		// -(BOOL)setKeyWithData:(NSData *)keyData;
		[Export ("setKeyWithData:")]
		bool SetKeyWithData (NSData keyData);

		// -(BOOL)rekeyWithData:(NSData *)keyData;
		[Export ("rekeyWithData:")]
		bool RekeyWithData (NSData keyData);

		// -(NSString *)databasePath;
		[Export ("databasePath")]
		string DatabasePath ();

		// -(void *)sqliteHandle;
		[Export ("sqliteHandle")]
		unsafe void* SqliteHandle ();

		// -(NSString *)lastErrorMessage;
		[Export ("lastErrorMessage")]
		string LastErrorMessage ();

		// -(int)lastErrorCode;
		[Export ("lastErrorCode")]
		int LastErrorCode ();

		// -(BOOL)hadError;
		[Export ("hadError")]
		bool HadError ();

		// -(NSError *)lastError;
		[Export ("lastError")]
		NSError LastError ();

		// -(void)setMaxBusyRetryTimeInterval:(NSTimeInterval)timeoutInSeconds;
		[Export ("setMaxBusyRetryTimeInterval:")]
		void SetMaxBusyRetryTimeInterval (double timeoutInSeconds);

		// -(NSTimeInterval)maxBusyRetryTimeInterval;
		[Export ("maxBusyRetryTimeInterval")]
		double MaxBusyRetryTimeInterval ();

		// -(BOOL)startSavePointWithName:(NSString *)name error:(NSError **)outErr;
		[Export ("startSavePointWithName:error:")]
		bool StartSavePointWithName (string name, out NSError outErr);

		// -(BOOL)releaseSavePointWithName:(NSString *)name error:(NSError **)outErr;
		[Export ("releaseSavePointWithName:error:")]
		bool ReleaseSavePointWithName (string name, out NSError outErr);

		// -(BOOL)rollbackToSavePointWithName:(NSString *)name error:(NSError **)outErr;
		[Export ("rollbackToSavePointWithName:error:")]
		bool RollbackToSavePointWithName (string name, out NSError outErr);

		// -(NSError *)inSavePoint:(void (^)(BOOL *))block;
		[Export ("inSavePoint:")]
		unsafe NSError InSavePoint (Action<bool*> block);

		// +(BOOL)isSQLiteThreadSafe;
		[Static]
		[Export ("isSQLiteThreadSafe")]
		bool IsSQLiteThreadSafe ();

		// +(NSString *)sqliteLibVersion;
		[Static]
		[Export ("sqliteLibVersion")]
		string SqliteLibVersion ();

		// +(NSString *)AWSFMDBUserVersion;
		[Static]
		[Export ("AWSFMDBUserVersion")]
		string AWSFMDBUserVersion ();

		// +(SInt32)AWSFMDBVersion;
		[Static]
		[Export ("AWSFMDBVersion")]
		int AWSFMDBVersion ();

		// -(void)makeFunctionNamed:(NSString *)name maximumArguments:(int)count withBlock:(void (^)(void *, int, void **))block;
		[Export ("makeFunctionNamed:maximumArguments:withBlock:")]
		unsafe void MakeFunctionNamed (string name, int count, Action<void*, int, void**> block);

		// +(NSDateFormatter *)storeableDateFormat:(NSString *)format;
		[Static]
		[Export ("storeableDateFormat:")]
		NSDateFormatter StoreableDateFormat (string format);

		// -(BOOL)hasDateFormatter;
		[Export ("hasDateFormatter")]
		bool HasDateFormatter ();

		// -(void)setDateFormat:(NSDateFormatter *)format;
		[Export ("setDateFormat:")]
		void SetDateFormat (NSDateFormatter format);

		// -(NSDate *)dateFromString:(NSString *)s;
		[Export ("dateFromString:")]
		NSDate DateFromString (string s);

		// -(NSString *)stringFromDate:(NSDate *)date;
		[Export ("stringFromDate:")]
		string StringFromDate (NSDate date);
	}

	// @interface AWSFMStatement : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSFMStatement
	{
		// @property (assign, atomic) long useCount;
		[Export ("useCount")]
		nint UseCount { get; set; }

		// @property (retain, atomic) NSString * query;
		[Export ("query", ArgumentSemantic.Retain)]
		string Query { get; set; }

		// @property (assign, atomic) void * statement;
		[Export ("statement", ArgumentSemantic.Assign)]
		unsafe void* Statement { get; set; }

		// @property (assign, atomic) BOOL inUse;
		[Export ("inUse")]
		bool InUse { get; set; }

		// -(void)close;
		[Export ("close")]
		void Close ();

		// -(void)reset;
		[Export ("reset")]
		void Reset ();
	}

	// @interface AWSFMDatabaseAdditions (AWSFMDatabase)
	[Category]
	[BaseType (typeof(AWSFMDatabase))]
	interface AWSFMDatabase_AWSFMDatabaseAdditions
	{
		// -(int)intForQuery:(NSString *)query, ...;
		[Internal]
		[Export ("intForQuery:", IsVariadic = true)]
		int IntForQuery (string query, IntPtr varArgs);

		// -(long)longForQuery:(NSString *)query, ...;
		[Internal]
		[Export ("longForQuery:", IsVariadic = true)]
		nint LongForQuery (string query, IntPtr varArgs);

		// -(BOOL)boolForQuery:(NSString *)query, ...;
		[Internal]
		[Export ("boolForQuery:", IsVariadic = true)]
		bool BoolForQuery (string query, IntPtr varArgs);

		// -(double)doubleForQuery:(NSString *)query, ...;
		[Internal]
		[Export ("doubleForQuery:", IsVariadic = true)]
		double DoubleForQuery (string query, IntPtr varArgs);

		// -(NSString *)stringForQuery:(NSString *)query, ...;
		[Internal]
		[Export ("stringForQuery:", IsVariadic = true)]
		string StringForQuery (string query, IntPtr varArgs);

		// -(NSData *)dataForQuery:(NSString *)query, ...;
		[Internal]
		[Export ("dataForQuery:", IsVariadic = true)]
		NSData DataForQuery (string query, IntPtr varArgs);

		// -(NSDate *)dateForQuery:(NSString *)query, ...;
		[Internal]
		[Export ("dateForQuery:", IsVariadic = true)]
		NSDate DateForQuery (string query, IntPtr varArgs);

		// -(BOOL)tableExists:(NSString *)tableName;
		[Export ("tableExists:")]
		bool TableExists (string tableName);

		// -(AWSFMResultSet *)getSchema;
		[Export ("getSchema")]
		[Verify (MethodToProperty)]
		AWSFMResultSet Schema { get; }

		// -(AWSFMResultSet *)getTableSchema:(NSString *)tableName;
		[Export ("getTableSchema:")]
		AWSFMResultSet GetTableSchema (string tableName);

		// -(BOOL)columnExists:(NSString *)columnName inTableWithName:(NSString *)tableName;
		[Export ("columnExists:inTableWithName:")]
		bool ColumnExists (string columnName, string tableName);

		// -(BOOL)columnExists:(NSString *)tableName columnName:(NSString *)columnName __attribute__((deprecated("")));
		[Export ("columnExists:columnName:")]
		bool ColumnExists (string tableName, string columnName);

		// -(BOOL)validateSQL:(NSString *)sql error:(NSError **)error;
		[Export ("validateSQL:error:")]
		bool ValidateSQL (string sql, out NSError error);

		// -(uint32_t)applicationID;
		// -(void)setApplicationID:(uint32_t)appID;
		[Export ("applicationID")]
		[Verify (MethodToProperty)]
		uint ApplicationID { get; set; }

		// -(uint32_t)userVersion;
		[Export ("userVersion")]
		uint UserVersion ();

		// -(void)setUserVersion:(uint32_t)version;
		[Export ("setUserVersion:")]
		void SetUserVersion (uint version);
	}

	// @interface AWSFMDatabaseQueue : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSFMDatabaseQueue
	{
		// @property (retain, atomic) NSString * path;
		[Export ("path", ArgumentSemantic.Retain)]
		string Path { get; set; }

		// @property (readonly, atomic) int openFlags;
		[Export ("openFlags")]
		int OpenFlags { get; }

		// +(instancetype)databaseQueueWithPath:(NSString *)aPath;
		[Static]
		[Export ("databaseQueueWithPath:")]
		AWSFMDatabaseQueue DatabaseQueueWithPath (string aPath);

		// +(instancetype)databaseQueueWithPath:(NSString *)aPath flags:(int)openFlags;
		[Static]
		[Export ("databaseQueueWithPath:flags:")]
		AWSFMDatabaseQueue DatabaseQueueWithPath (string aPath, int openFlags);

		// -(instancetype)initWithPath:(NSString *)aPath;
		[Export ("initWithPath:")]
		NativeHandle Constructor (string aPath);

		// -(instancetype)initWithPath:(NSString *)aPath flags:(int)openFlags;
		[Export ("initWithPath:flags:")]
		NativeHandle Constructor (string aPath, int openFlags);

		// -(instancetype)initWithPath:(NSString *)aPath flags:(int)openFlags vfs:(NSString *)vfsName;
		[Export ("initWithPath:flags:vfs:")]
		NativeHandle Constructor (string aPath, int openFlags, string vfsName);

		// +(Class)databaseClass;
		[Static]
		[Export ("databaseClass")]
		[Verify (MethodToProperty)]
		Class DatabaseClass { get; }

		// -(void)close;
		[Export ("close")]
		void Close ();

		// -(void)inDatabase:(void (^)(AWSFMDatabase *))block;
		[Export ("inDatabase:")]
		void InDatabase (Action<AWSFMDatabase> block);

		// -(void)inTransaction:(void (^)(AWSFMDatabase *, BOOL *))block;
		[Export ("inTransaction:")]
		unsafe void InTransaction (Action<AWSFMDatabase, bool*> block);

		// -(void)inDeferredTransaction:(void (^)(AWSFMDatabase *, BOOL *))block;
		[Export ("inDeferredTransaction:")]
		unsafe void InDeferredTransaction (Action<AWSFMDatabase, bool*> block);

		// -(NSError *)inSavePoint:(void (^)(AWSFMDatabase *, BOOL *))block;
		[Export ("inSavePoint:")]
		unsafe NSError InSavePoint (Action<AWSFMDatabase, bool*> block);
	}

	// @interface AWSHelpers (AWSFMDatabaseQueue)
	[Category]
	[BaseType (typeof(AWSFMDatabaseQueue))]
	interface AWSFMDatabaseQueue_AWSHelpers
	{
		// +(instancetype _Nonnull)serialDatabaseQueueWithPath:(NSString * _Nonnull)aPath;
		[Static]
		[Export ("serialDatabaseQueueWithPath:")]
		AWSFMDatabaseQueue SerialDatabaseQueueWithPath (string aPath);
	}

	// @interface AWSHelpers (AWSFMDatabasePool)
	[Category]
	[BaseType (typeof(AWSFMDatabasePool))]
	interface AWSFMDatabasePool_AWSHelpers
	{
		// +(instancetype _Nonnull)serialDatabasePoolWithPath:(NSString * _Nonnull)aPath;
		[Static]
		[Export ("serialDatabasePoolWithPath:")]
		AWSFMDatabasePool SerialDatabasePoolWithPath (string aPath);
	}

	// typedef void (^AWSKSReachabilityCallback)(AWSKSReachability *);
	delegate void AWSKSReachabilityCallback (AWSKSReachability arg0);

	// @interface AWSKSReachability : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSKSReachability
	{
		// +(AWSKSReachability *)reachabilityToHost:(NSString *)hostname;
		[Static]
		[Export ("reachabilityToHost:")]
		AWSKSReachability ReachabilityToHost (string hostname);

		// +(AWSKSReachability *)reachabilityToLocalNetwork;
		[Static]
		[Export ("reachabilityToLocalNetwork")]
		[Verify (MethodToProperty)]
		AWSKSReachability ReachabilityToLocalNetwork { get; }

		// +(AWSKSReachability *)reachabilityToInternet;
		[Static]
		[Export ("reachabilityToInternet")]
		[Verify (MethodToProperty)]
		AWSKSReachability ReachabilityToInternet { get; }

		// @property (readonly, retain, nonatomic) NSString * hostname;
		[Export ("hostname", ArgumentSemantic.Retain)]
		string Hostname { get; }

		// @property (readwrite, copy, atomic) AWSKSReachabilityCallback onInitializationComplete;
		[Export ("onInitializationComplete", ArgumentSemantic.Copy)]
		AWSKSReachabilityCallback OnInitializationComplete { get; set; }

		// @property (readwrite, copy, atomic) AWSKSReachabilityCallback onReachabilityChanged;
		[Export ("onReachabilityChanged", ArgumentSemantic.Copy)]
		AWSKSReachabilityCallback OnReachabilityChanged { get; set; }

		// @property (readwrite, retain, nonatomic) NSString * notificationName;
		[Export ("notificationName", ArgumentSemantic.Retain)]
		string NotificationName { get; set; }

		// @property (readonly, assign, nonatomic) SCNetworkReachabilityFlags flags;
		[Export ("flags", ArgumentSemantic.Assign)]
		SCNetworkReachabilityFlags Flags { get; }

		// @property (readonly, assign, nonatomic) BOOL reachable;
		[Export ("reachable")]
		bool Reachable { get; }

		// @property (readonly, assign, nonatomic) BOOL WWANOnly;
		[Export ("WWANOnly")]
		bool WWANOnly { get; }

		// @property (readonly, assign, atomic) BOOL initialized;
		[Export ("initialized")]
		bool Initialized { get; }
	}

	// @interface AWSKSReachableOperation : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSKSReachableOperation
	{
		// +(AWSKSReachableOperation *)operationWithHost:(NSString *)hostname allowWWAN:(BOOL)allowWWAN onReachabilityAchieved:(dispatch_block_t)onReachabilityAchieved;
		[Static]
		[Export ("operationWithHost:allowWWAN:onReachabilityAchieved:")]
		AWSKSReachableOperation OperationWithHost (string hostname, bool allowWWAN, dispatch_block_t onReachabilityAchieved);

		// +(AWSKSReachableOperation *)operationWithReachability:(AWSKSReachability *)reachability allowWWAN:(BOOL)allowWWAN onReachabilityAchieved:(dispatch_block_t)onReachabilityAchieved;
		[Static]
		[Export ("operationWithReachability:allowWWAN:onReachabilityAchieved:")]
		AWSKSReachableOperation OperationWithReachability (AWSKSReachability reachability, bool allowWWAN, dispatch_block_t onReachabilityAchieved);

		// -(id)initWithHost:(NSString *)hostname allowWWAN:(BOOL)allowWWAN onReachabilityAchieved:(dispatch_block_t)onReachabilityAchieved;
		[Export ("initWithHost:allowWWAN:onReachabilityAchieved:")]
		NativeHandle Constructor (string hostname, bool allowWWAN, dispatch_block_t onReachabilityAchieved);

		// -(id)initWithReachability:(AWSKSReachability *)reachability allowWWAN:(BOOL)allowWWAN onReachabilityAchieved:(dispatch_block_t)onReachabilityAchieved;
		[Export ("initWithReachability:allowWWAN:onReachabilityAchieved:")]
		NativeHandle Constructor (AWSKSReachability reachability, bool allowWWAN, dispatch_block_t onReachabilityAchieved);

		// @property (readonly, retain, nonatomic) AWSKSReachability * reachability;
		[Export ("reachability", ArgumentSemantic.Retain)]
		AWSKSReachability Reachability { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSUICKeyChainStoreErrorDomain;
		[Field ("AWSUICKeyChainStoreErrorDomain", "__Internal")]
		NSString AWSUICKeyChainStoreErrorDomain { get; }
	}

	// @interface AWSUICKeyChainStore : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSUICKeyChainStore
	{
		// @property (readonly, nonatomic) AWSUICKeyChainStoreItemClass itemClass;
		[Export ("itemClass")]
		AWSUICKeyChainStoreItemClass ItemClass { get; }

		// @property (readonly, nonatomic) NSString * _Nullable service;
		[NullAllowed, Export ("service")]
		string Service { get; }

		// @property (readonly, nonatomic) NSString * _Nullable accessGroup;
		[NullAllowed, Export ("accessGroup")]
		string AccessGroup { get; }

		// @property (readonly, nonatomic) NSURL * _Nullable server;
		[NullAllowed, Export ("server")]
		NSUrl Server { get; }

		// @property (readonly, nonatomic) AWSUICKeyChainStoreProtocolType protocolType;
		[Export ("protocolType")]
		AWSUICKeyChainStoreProtocolType ProtocolType { get; }

		// @property (readonly, nonatomic) AWSUICKeyChainStoreAuthenticationType authenticationType;
		[Export ("authenticationType")]
		AWSUICKeyChainStoreAuthenticationType AuthenticationType { get; }

		// @property (nonatomic) AWSUICKeyChainStoreAccessibility accessibility;
		[Export ("accessibility", ArgumentSemantic.Assign)]
		AWSUICKeyChainStoreAccessibility Accessibility { get; set; }

		// @property (readonly, nonatomic) AWSUICKeyChainStoreAuthenticationPolicy authenticationPolicy __attribute__((availability(ios, introduced=8.0)));
		[iOS (8, 0)]
		[Export ("authenticationPolicy")]
		AWSUICKeyChainStoreAuthenticationPolicy AuthenticationPolicy { get; }

		// @property (nonatomic) BOOL synchronizable;
		[Export ("synchronizable")]
		bool Synchronizable { get; set; }

		// @property (nonatomic) __OSX_AVAILABLE_STARTING(__MAC_NA, __IPHONE_8_0) NSString * authenticationPrompt __attribute__((availability(ios, introduced=8.0)));
		[iOS (8, 0)]
		[Export ("authenticationPrompt")]
		string AuthenticationPrompt { get; set; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nullable allKeys;
		[NullAllowed, Export ("allKeys")]
		string[] AllKeys { get; }

		// @property (readonly, nonatomic) NSArray * _Nullable allItems;
		[NullAllowed, Export ("allItems")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AllItems { get; }

		// +(NSString * _Nonnull)defaultService;
		// +(void)setDefaultService:(NSString * _Nonnull)defaultService;
		[Static]
		[Export ("defaultService")]
		[Verify (MethodToProperty)]
		string DefaultService { get; set; }

		// +(AWSUICKeyChainStore * _Nonnull)keyChainStore;
		[Static]
		[Export ("keyChainStore")]
		AWSUICKeyChainStore KeyChainStore ();

		// +(AWSUICKeyChainStore * _Nonnull)keyChainStoreWithService:(NSString * _Nullable)service;
		[Static]
		[Export ("keyChainStoreWithService:")]
		AWSUICKeyChainStore KeyChainStoreWithService ([NullAllowed] string service);

		// +(AWSUICKeyChainStore * _Nonnull)keyChainStoreWithService:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup;
		[Static]
		[Export ("keyChainStoreWithService:accessGroup:")]
		AWSUICKeyChainStore KeyChainStoreWithService ([NullAllowed] string service, [NullAllowed] string accessGroup);

		// +(AWSUICKeyChainStore * _Nonnull)keyChainStoreWithServer:(NSURL * _Nonnull)server protocolType:(AWSUICKeyChainStoreProtocolType)protocolType;
		[Static]
		[Export ("keyChainStoreWithServer:protocolType:")]
		AWSUICKeyChainStore KeyChainStoreWithServer (NSUrl server, AWSUICKeyChainStoreProtocolType protocolType);

		// +(AWSUICKeyChainStore * _Nonnull)keyChainStoreWithServer:(NSURL * _Nonnull)server protocolType:(AWSUICKeyChainStoreProtocolType)protocolType authenticationType:(AWSUICKeyChainStoreAuthenticationType)authenticationType;
		[Static]
		[Export ("keyChainStoreWithServer:protocolType:authenticationType:")]
		AWSUICKeyChainStore KeyChainStoreWithServer (NSUrl server, AWSUICKeyChainStoreProtocolType protocolType, AWSUICKeyChainStoreAuthenticationType authenticationType);

		// -(instancetype _Nonnull)initWithService:(NSString * _Nullable)service;
		[Export ("initWithService:")]
		NativeHandle Constructor ([NullAllowed] string service);

		// -(instancetype _Nonnull)initWithService:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup;
		[Export ("initWithService:accessGroup:")]
		NativeHandle Constructor ([NullAllowed] string service, [NullAllowed] string accessGroup);

		// -(instancetype _Nonnull)initWithServer:(NSURL * _Nonnull)server protocolType:(AWSUICKeyChainStoreProtocolType)protocolType;
		[Export ("initWithServer:protocolType:")]
		NativeHandle Constructor (NSUrl server, AWSUICKeyChainStoreProtocolType protocolType);

		// -(instancetype _Nonnull)initWithServer:(NSURL * _Nonnull)server protocolType:(AWSUICKeyChainStoreProtocolType)protocolType authenticationType:(AWSUICKeyChainStoreAuthenticationType)authenticationType;
		[Export ("initWithServer:protocolType:authenticationType:")]
		NativeHandle Constructor (NSUrl server, AWSUICKeyChainStoreProtocolType protocolType, AWSUICKeyChainStoreAuthenticationType authenticationType);

		// +(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("stringForKey:")]
		[return: NullAllowed]
		string StringForKey (string key);

		// +(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service;
		[Static]
		[Export ("stringForKey:service:")]
		[return: NullAllowed]
		string StringForKey (string key, [NullAllowed] string service);

		// +(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup;
		[Static]
		[Export ("stringForKey:service:accessGroup:")]
		[return: NullAllowed]
		string StringForKey (string key, [NullAllowed] string service, [NullAllowed] string accessGroup);

		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("setString:forKey:")]
		bool SetString ([NullAllowed] string value, string key);

		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service;
		[Static]
		[Export ("setString:forKey:service:")]
		bool SetString ([NullAllowed] string value, string key, [NullAllowed] string service);

		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup;
		[Static]
		[Export ("setString:forKey:service:accessGroup:")]
		bool SetString ([NullAllowed] string value, string key, [NullAllowed] string service, [NullAllowed] string accessGroup);

		// +(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("dataForKey:")]
		[return: NullAllowed]
		NSData DataForKey (string key);

		// +(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service;
		[Static]
		[Export ("dataForKey:service:")]
		[return: NullAllowed]
		NSData DataForKey (string key, [NullAllowed] string service);

		// +(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup;
		[Static]
		[Export ("dataForKey:service:accessGroup:")]
		[return: NullAllowed]
		NSData DataForKey (string key, [NullAllowed] string service, [NullAllowed] string accessGroup);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("setData:forKey:")]
		bool SetData ([NullAllowed] NSData data, string key);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service;
		[Static]
		[Export ("setData:forKey:service:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] string service);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup;
		[Static]
		[Export ("setData:forKey:service:accessGroup:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] string service, [NullAllowed] string accessGroup);

		// -(BOOL)contains:(NSString * _Nullable)key;
		[Export ("contains:")]
		bool Contains ([NullAllowed] string key);

		// -(BOOL)setString:(NSString * _Nullable)string forKey:(NSString * _Nullable)key;
		[Export ("setString:forKey:")]
		bool SetString ([NullAllowed] string @string, [NullAllowed] string key);

		// -(BOOL)setString:(NSString * _Nullable)string forKey:(NSString * _Nullable)key label:(NSString * _Nullable)label comment:(NSString * _Nullable)comment;
		[Export ("setString:forKey:label:comment:")]
		bool SetString ([NullAllowed] string @string, [NullAllowed] string key, [NullAllowed] string label, [NullAllowed] string comment);

		// -(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key;
		[Export ("stringForKey:")]
		[return: NullAllowed]
		string StringForKey (string key);

		// -(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key;
		[Export ("setData:forKey:")]
		bool SetData ([NullAllowed] NSData data, string key);

		// -(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key label:(NSString * _Nullable)label comment:(NSString * _Nullable)comment;
		[Export ("setData:forKey:label:comment:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] string label, [NullAllowed] string comment);

		// -(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key;
		[Export ("dataForKey:")]
		[return: NullAllowed]
		NSData DataForKey (string key);

		// +(BOOL)removeItemForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("removeItemForKey:")]
		bool RemoveItemForKey (string key);

		// +(BOOL)removeItemForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service;
		[Static]
		[Export ("removeItemForKey:service:")]
		bool RemoveItemForKey (string key, [NullAllowed] string service);

		// +(BOOL)removeItemForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup;
		[Static]
		[Export ("removeItemForKey:service:accessGroup:")]
		bool RemoveItemForKey (string key, [NullAllowed] string service, [NullAllowed] string accessGroup);

		// +(BOOL)removeAllItems;
		[Static]
		[Export ("removeAllItems")]
		bool RemoveAllItems ();

		// +(BOOL)removeAllItemsForService:(NSString * _Nullable)service;
		[Static]
		[Export ("removeAllItemsForService:")]
		bool RemoveAllItemsForService ([NullAllowed] string service);

		// +(BOOL)removeAllItemsForService:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup;
		[Static]
		[Export ("removeAllItemsForService:accessGroup:")]
		bool RemoveAllItemsForService ([NullAllowed] string service, [NullAllowed] string accessGroup);

		// -(BOOL)removeItemForKey:(NSString * _Nonnull)key;
		[Export ("removeItemForKey:")]
		bool RemoveItemForKey (string key);

		// -(BOOL)removeAllItems;
		[Export ("removeAllItems")]
		bool RemoveAllItems ();

		// -(NSString * _Nullable)objectForKeyedSubscript:(NSString<NSCopying> * _Nonnull)key;
		[Export ("objectForKeyedSubscript:")]
		[return: NullAllowed]
		string ObjectForKeyedSubscript (NSCopying key);

		// -(void)setObject:(NSString * _Nullable)obj forKeyedSubscript:(NSString<NSCopying> * _Nonnull)key;
		[Export ("setObject:forKeyedSubscript:")]
		void SetObject ([NullAllowed] string obj, NSCopying key);

		// +(NSArray<NSString *> * _Nullable)allKeysWithItemClass:(AWSUICKeyChainStoreItemClass)itemClass;
		[Static]
		[Export ("allKeysWithItemClass:")]
		[return: NullAllowed]
		string[] AllKeysWithItemClass (AWSUICKeyChainStoreItemClass itemClass);

		// +(NSArray * _Nullable)allItemsWithItemClass:(AWSUICKeyChainStoreItemClass)itemClass;
		[Static]
		[Export ("allItemsWithItemClass:")]
		[Verify (StronglyTypedNSArray)]
		[return: NullAllowed]
		NSObject[] AllItemsWithItemClass (AWSUICKeyChainStoreItemClass itemClass);

		// -(void)setAccessibility:(AWSUICKeyChainStoreAccessibility)accessibility authenticationPolicy:(AWSUICKeyChainStoreAuthenticationPolicy)authenticationPolicy __attribute__((availability(ios, introduced=8.0)));
		[iOS (8,0)]
		[Export ("setAccessibility:authenticationPolicy:")]
		void SetAccessibility (AWSUICKeyChainStoreAccessibility accessibility, AWSUICKeyChainStoreAuthenticationPolicy authenticationPolicy);

		// -(void)sharedPasswordWithCompletion:(void (^ _Nullable)(NSString * _Nullable, NSString * _Nullable, NSError * _Nullable))completion;
		[Export ("sharedPasswordWithCompletion:")]
		void SharedPasswordWithCompletion ([NullAllowed] Action<NSString, NSString, NSError> completion);

		// -(void)sharedPasswordForAccount:(NSString * _Nonnull)account completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export ("sharedPasswordForAccount:completion:")]
		void SharedPasswordForAccount (string account, [NullAllowed] Action<NSString, NSError> completion);

		// -(void)setSharedPassword:(NSString * _Nullable)password forAccount:(NSString * _Nonnull)account completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setSharedPassword:forAccount:completion:")]
		void SetSharedPassword ([NullAllowed] string password, string account, [NullAllowed] Action<NSError> completion);

		// -(void)removeSharedPasswordForAccount:(NSString * _Nonnull)account completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("removeSharedPasswordForAccount:completion:")]
		void RemoveSharedPasswordForAccount (string account, [NullAllowed] Action<NSError> completion);

		// +(void)requestSharedWebCredentialWithCompletion:(void (^ _Nullable)(NSArray<NSDictionary<NSString *,NSString *> *> * _Nonnull, NSError * _Nullable))completion;
		[Static]
		[Export ("requestSharedWebCredentialWithCompletion:")]
		void RequestSharedWebCredentialWithCompletion ([NullAllowed] Action<NSArray<NSDictionary<NSString, NSString>>, NSError> completion);

		// +(void)requestSharedWebCredentialForDomain:(NSString * _Nullable)domain account:(NSString * _Nullable)account completion:(void (^ _Nullable)(NSArray<NSDictionary<NSString *,NSString *> *> * _Nonnull, NSError * _Nullable))completion;
		[Static]
		[Export ("requestSharedWebCredentialForDomain:account:completion:")]
		void RequestSharedWebCredentialForDomain ([NullAllowed] string domain, [NullAllowed] string account, [NullAllowed] Action<NSArray<NSDictionary<NSString, NSString>>, NSError> completion);

		// +(NSString * _Nonnull)generatePassword;
		[Static]
		[Export ("generatePassword")]
		string GeneratePassword ();

		// -(void)migrateToCurrentAccessibility;
		[Export ("migrateToCurrentAccessibility")]
		void MigrateToCurrentAccessibility ();
	}

	// @interface ErrorHandling (AWSUICKeyChainStore)
	[Category]
	[BaseType (typeof(AWSUICKeyChainStore))]
	interface AWSUICKeyChainStore_ErrorHandling
	{
		// +(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("stringForKey:error:")]
		[return: NullAllowed]
		string StringForKey (string key, [NullAllowed] out NSError error);

		// +(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("stringForKey:service:error:")]
		[return: NullAllowed]
		string StringForKey (string key, [NullAllowed] string service, [NullAllowed] out NSError error);

		// +(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("stringForKey:service:accessGroup:error:")]
		[return: NullAllowed]
		string StringForKey (string key, [NullAllowed] string service, [NullAllowed] string accessGroup, [NullAllowed] out NSError error);

		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setString:forKey:error:")]
		bool SetString ([NullAllowed] string value, string key, [NullAllowed] out NSError error);

		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setString:forKey:service:error:")]
		bool SetString ([NullAllowed] string value, string key, [NullAllowed] string service, [NullAllowed] out NSError error);

		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setString:forKey:service:accessGroup:error:")]
		bool SetString ([NullAllowed] string value, string key, [NullAllowed] string service, [NullAllowed] string accessGroup, [NullAllowed] out NSError error);

		// +(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("dataForKey:error:")]
		[return: NullAllowed]
		NSData DataForKey (string key, [NullAllowed] out NSError error);

		// +(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("dataForKey:service:error:")]
		[return: NullAllowed]
		NSData DataForKey (string key, [NullAllowed] string service, [NullAllowed] out NSError error);

		// +(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("dataForKey:service:accessGroup:error:")]
		[return: NullAllowed]
		NSData DataForKey (string key, [NullAllowed] string service, [NullAllowed] string accessGroup, [NullAllowed] out NSError error);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setData:forKey:error:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] out NSError error);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setData:forKey:service:error:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] string service, [NullAllowed] out NSError error);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setData:forKey:service:accessGroup:error:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] string service, [NullAllowed] string accessGroup, [NullAllowed] out NSError error);

		// -(BOOL)setString:(NSString * _Nullable)string forKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("setString:forKey:error:")]
		bool SetString ([NullAllowed] string @string, string key, [NullAllowed] out NSError error);

		// -(BOOL)setString:(NSString * _Nullable)string forKey:(NSString * _Nonnull)key label:(NSString * _Nullable)label comment:(NSString * _Nullable)comment error:(NSError * _Nullable * _Nullable)error;
		[Export ("setString:forKey:label:comment:error:")]
		bool SetString ([NullAllowed] string @string, string key, [NullAllowed] string label, [NullAllowed] string comment, [NullAllowed] out NSError error);

		// -(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("setData:forKey:error:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] out NSError error);

		// -(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key label:(NSString * _Nullable)label comment:(NSString * _Nullable)comment error:(NSError * _Nullable * _Nullable)error;
		[Export ("setData:forKey:label:comment:error:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] string label, [NullAllowed] string comment, [NullAllowed] out NSError error);

		// -(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("stringForKey:error:")]
		[return: NullAllowed]
		string StringForKey (string key, [NullAllowed] out NSError error);

		// -(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("dataForKey:error:")]
		[return: NullAllowed]
		NSData DataForKey (string key, [NullAllowed] out NSError error);

		// +(BOOL)removeItemForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("removeItemForKey:error:")]
		bool RemoveItemForKey (string key, [NullAllowed] out NSError error);

		// +(BOOL)removeItemForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("removeItemForKey:service:error:")]
		bool RemoveItemForKey (string key, [NullAllowed] string service, [NullAllowed] out NSError error);

		// +(BOOL)removeItemForKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("removeItemForKey:service:accessGroup:error:")]
		bool RemoveItemForKey (string key, [NullAllowed] string service, [NullAllowed] string accessGroup, [NullAllowed] out NSError error);

		// +(BOOL)removeAllItemsWithError:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("removeAllItemsWithError:")]
		bool RemoveAllItemsWithError ([NullAllowed] out NSError error);

		// +(BOOL)removeAllItemsForService:(NSString * _Nullable)service error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("removeAllItemsForService:error:")]
		bool RemoveAllItemsForService ([NullAllowed] string service, [NullAllowed] out NSError error);

		// +(BOOL)removeAllItemsForService:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("removeAllItemsForService:accessGroup:error:")]
		bool RemoveAllItemsForService ([NullAllowed] string service, [NullAllowed] string accessGroup, [NullAllowed] out NSError error);

		// -(BOOL)removeItemForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("removeItemForKey:error:")]
		bool RemoveItemForKey (string key, [NullAllowed] out NSError error);

		// -(BOOL)removeAllItemsWithError:(NSError * _Nullable * _Nullable)error;
		[Export ("removeAllItemsWithError:")]
		bool RemoveAllItemsWithError ([NullAllowed] out NSError error);
	}

	// @interface ForwardCompatibility (AWSUICKeyChainStore)
	[Category]
	[BaseType (typeof(AWSUICKeyChainStore))]
	interface AWSUICKeyChainStore_ForwardCompatibility
	{
		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key genericAttribute:(id _Nullable)genericAttribute;
		[Static]
		[Export ("setString:forKey:genericAttribute:")]
		bool SetString ([NullAllowed] string value, string key, [NullAllowed] NSObject genericAttribute);

		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key genericAttribute:(id _Nullable)genericAttribute error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setString:forKey:genericAttribute:error:")]
		bool SetString ([NullAllowed] string value, string key, [NullAllowed] NSObject genericAttribute, [NullAllowed] out NSError error);

		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service genericAttribute:(id _Nullable)genericAttribute;
		[Static]
		[Export ("setString:forKey:service:genericAttribute:")]
		bool SetString ([NullAllowed] string value, string key, [NullAllowed] string service, [NullAllowed] NSObject genericAttribute);

		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service genericAttribute:(id _Nullable)genericAttribute error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setString:forKey:service:genericAttribute:error:")]
		bool SetString ([NullAllowed] string value, string key, [NullAllowed] string service, [NullAllowed] NSObject genericAttribute, [NullAllowed] out NSError error);

		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup genericAttribute:(id _Nullable)genericAttribute;
		[Static]
		[Export ("setString:forKey:service:accessGroup:genericAttribute:")]
		bool SetString ([NullAllowed] string value, string key, [NullAllowed] string service, [NullAllowed] string accessGroup, [NullAllowed] NSObject genericAttribute);

		// +(BOOL)setString:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup genericAttribute:(id _Nullable)genericAttribute error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setString:forKey:service:accessGroup:genericAttribute:error:")]
		bool SetString ([NullAllowed] string value, string key, [NullAllowed] string service, [NullAllowed] string accessGroup, [NullAllowed] NSObject genericAttribute, [NullAllowed] out NSError error);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key genericAttribute:(id _Nullable)genericAttribute;
		[Static]
		[Export ("setData:forKey:genericAttribute:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] NSObject genericAttribute);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key genericAttribute:(id _Nullable)genericAttribute error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setData:forKey:genericAttribute:error:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] NSObject genericAttribute, [NullAllowed] out NSError error);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service genericAttribute:(id _Nullable)genericAttribute;
		[Static]
		[Export ("setData:forKey:service:genericAttribute:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] string service, [NullAllowed] NSObject genericAttribute);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service genericAttribute:(id _Nullable)genericAttribute error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setData:forKey:service:genericAttribute:error:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] string service, [NullAllowed] NSObject genericAttribute, [NullAllowed] out NSError error);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup genericAttribute:(id _Nullable)genericAttribute;
		[Static]
		[Export ("setData:forKey:service:accessGroup:genericAttribute:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] string service, [NullAllowed] string accessGroup, [NullAllowed] NSObject genericAttribute);

		// +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key service:(NSString * _Nullable)service accessGroup:(NSString * _Nullable)accessGroup genericAttribute:(id _Nullable)genericAttribute error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("setData:forKey:service:accessGroup:genericAttribute:error:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] string service, [NullAllowed] string accessGroup, [NullAllowed] NSObject genericAttribute, [NullAllowed] out NSError error);

		// -(BOOL)setString:(NSString * _Nullable)string forKey:(NSString * _Nonnull)key genericAttribute:(id _Nullable)genericAttribute;
		[Export ("setString:forKey:genericAttribute:")]
		bool SetString ([NullAllowed] string @string, string key, [NullAllowed] NSObject genericAttribute);

		// -(BOOL)setString:(NSString * _Nullable)string forKey:(NSString * _Nonnull)key genericAttribute:(id _Nullable)genericAttribute error:(NSError * _Nullable * _Nullable)error;
		[Export ("setString:forKey:genericAttribute:error:")]
		bool SetString ([NullAllowed] string @string, string key, [NullAllowed] NSObject genericAttribute, [NullAllowed] out NSError error);

		// -(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key genericAttribute:(id _Nullable)genericAttribute;
		[Export ("setData:forKey:genericAttribute:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] NSObject genericAttribute);

		// -(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key genericAttribute:(id _Nullable)genericAttribute error:(NSError * _Nullable * _Nullable)error;
		[Export ("setData:forKey:genericAttribute:error:")]
		bool SetData ([NullAllowed] NSData data, string key, [NullAllowed] NSObject genericAttribute, [NullAllowed] out NSError error);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSSTSErrorDomain;
		[Field ("AWSSTSErrorDomain", "__Internal")]
		NSString AWSSTSErrorDomain { get; }
	}

	// @interface AWSSTSAssumeRoleRequest : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSSTSAssumeRoleRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable durationSeconds;
		[NullAllowed, Export ("durationSeconds", ArgumentSemantic.Strong)]
		NSNumber DurationSeconds { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable externalId;
		[NullAllowed, Export ("externalId", ArgumentSemantic.Strong)]
		string ExternalId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policy;
		[NullAllowed, Export ("policy", ArgumentSemantic.Strong)]
		string Policy { get; set; }

		// @property (nonatomic, strong) NSArray<AWSSTSPolicyDescriptorType *> * _Nullable policyArns;
		[NullAllowed, Export ("policyArns", ArgumentSemantic.Strong)]
		AWSSTSPolicyDescriptorType[] PolicyArns { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleSessionName;
		[NullAllowed, Export ("roleSessionName", ArgumentSemantic.Strong)]
		string RoleSessionName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable serialNumber;
		[NullAllowed, Export ("serialNumber", ArgumentSemantic.Strong)]
		string SerialNumber { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sourceIdentity;
		[NullAllowed, Export ("sourceIdentity", ArgumentSemantic.Strong)]
		string SourceIdentity { get; set; }

		// @property (nonatomic, strong) NSArray<AWSSTSTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSSTSTag[] Tags { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable tokenCode;
		[NullAllowed, Export ("tokenCode", ArgumentSemantic.Strong)]
		string TokenCode { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable transitiveTagKeys;
		[NullAllowed, Export ("transitiveTagKeys", ArgumentSemantic.Strong)]
		string[] TransitiveTagKeys { get; set; }
	}

	// @interface AWSSTSAssumeRoleResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSAssumeRoleResponse
	{
		// @property (nonatomic, strong) AWSSTSAssumedRoleUser * _Nullable assumedRoleUser;
		[NullAllowed, Export ("assumedRoleUser", ArgumentSemantic.Strong)]
		AWSSTSAssumedRoleUser AssumedRoleUser { get; set; }

		// @property (nonatomic, strong) AWSSTSCredentials * _Nullable credentials;
		[NullAllowed, Export ("credentials", ArgumentSemantic.Strong)]
		AWSSTSCredentials Credentials { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable packedPolicySize;
		[NullAllowed, Export ("packedPolicySize", ArgumentSemantic.Strong)]
		NSNumber PackedPolicySize { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sourceIdentity;
		[NullAllowed, Export ("sourceIdentity", ArgumentSemantic.Strong)]
		string SourceIdentity { get; set; }
	}

	// @interface AWSSTSAssumeRoleWithSAMLRequest : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSSTSAssumeRoleWithSAMLRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable durationSeconds;
		[NullAllowed, Export ("durationSeconds", ArgumentSemantic.Strong)]
		NSNumber DurationSeconds { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policy;
		[NullAllowed, Export ("policy", ArgumentSemantic.Strong)]
		string Policy { get; set; }

		// @property (nonatomic, strong) NSArray<AWSSTSPolicyDescriptorType *> * _Nullable policyArns;
		[NullAllowed, Export ("policyArns", ArgumentSemantic.Strong)]
		AWSSTSPolicyDescriptorType[] PolicyArns { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable principalArn;
		[NullAllowed, Export ("principalArn", ArgumentSemantic.Strong)]
		string PrincipalArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable SAMLAssertion;
		[NullAllowed, Export ("SAMLAssertion", ArgumentSemantic.Strong)]
		string SAMLAssertion { get; set; }
	}

	// @interface AWSSTSAssumeRoleWithSAMLResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSAssumeRoleWithSAMLResponse
	{
		// @property (nonatomic, strong) AWSSTSAssumedRoleUser * _Nullable assumedRoleUser;
		[NullAllowed, Export ("assumedRoleUser", ArgumentSemantic.Strong)]
		AWSSTSAssumedRoleUser AssumedRoleUser { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable audience;
		[NullAllowed, Export ("audience", ArgumentSemantic.Strong)]
		string Audience { get; set; }

		// @property (nonatomic, strong) AWSSTSCredentials * _Nullable credentials;
		[NullAllowed, Export ("credentials", ArgumentSemantic.Strong)]
		AWSSTSCredentials Credentials { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable issuer;
		[NullAllowed, Export ("issuer", ArgumentSemantic.Strong)]
		string Issuer { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nameQualifier;
		[NullAllowed, Export ("nameQualifier", ArgumentSemantic.Strong)]
		string NameQualifier { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable packedPolicySize;
		[NullAllowed, Export ("packedPolicySize", ArgumentSemantic.Strong)]
		NSNumber PackedPolicySize { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sourceIdentity;
		[NullAllowed, Export ("sourceIdentity", ArgumentSemantic.Strong)]
		string SourceIdentity { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable subject;
		[NullAllowed, Export ("subject", ArgumentSemantic.Strong)]
		string Subject { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable subjectType;
		[NullAllowed, Export ("subjectType", ArgumentSemantic.Strong)]
		string SubjectType { get; set; }
	}

	// @interface AWSSTSAssumeRoleWithWebIdentityRequest : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSSTSAssumeRoleWithWebIdentityRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable durationSeconds;
		[NullAllowed, Export ("durationSeconds", ArgumentSemantic.Strong)]
		NSNumber DurationSeconds { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policy;
		[NullAllowed, Export ("policy", ArgumentSemantic.Strong)]
		string Policy { get; set; }

		// @property (nonatomic, strong) NSArray<AWSSTSPolicyDescriptorType *> * _Nullable policyArns;
		[NullAllowed, Export ("policyArns", ArgumentSemantic.Strong)]
		AWSSTSPolicyDescriptorType[] PolicyArns { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable providerId;
		[NullAllowed, Export ("providerId", ArgumentSemantic.Strong)]
		string ProviderId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleSessionName;
		[NullAllowed, Export ("roleSessionName", ArgumentSemantic.Strong)]
		string RoleSessionName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable webIdentityToken;
		[NullAllowed, Export ("webIdentityToken", ArgumentSemantic.Strong)]
		string WebIdentityToken { get; set; }
	}

	// @interface AWSSTSAssumeRoleWithWebIdentityResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSAssumeRoleWithWebIdentityResponse
	{
		// @property (nonatomic, strong) AWSSTSAssumedRoleUser * _Nullable assumedRoleUser;
		[NullAllowed, Export ("assumedRoleUser", ArgumentSemantic.Strong)]
		AWSSTSAssumedRoleUser AssumedRoleUser { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable audience;
		[NullAllowed, Export ("audience", ArgumentSemantic.Strong)]
		string Audience { get; set; }

		// @property (nonatomic, strong) AWSSTSCredentials * _Nullable credentials;
		[NullAllowed, Export ("credentials", ArgumentSemantic.Strong)]
		AWSSTSCredentials Credentials { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable packedPolicySize;
		[NullAllowed, Export ("packedPolicySize", ArgumentSemantic.Strong)]
		NSNumber PackedPolicySize { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable provider;
		[NullAllowed, Export ("provider", ArgumentSemantic.Strong)]
		string Provider { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sourceIdentity;
		[NullAllowed, Export ("sourceIdentity", ArgumentSemantic.Strong)]
		string SourceIdentity { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable subjectFromWebIdentityToken;
		[NullAllowed, Export ("subjectFromWebIdentityToken", ArgumentSemantic.Strong)]
		string SubjectFromWebIdentityToken { get; set; }
	}

	// @interface AWSSTSAssumedRoleUser : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSAssumedRoleUser
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable assumedRoleId;
		[NullAllowed, Export ("assumedRoleId", ArgumentSemantic.Strong)]
		string AssumedRoleId { get; set; }
	}

	// @interface AWSSTSCredentials : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSCredentials
	{
		// @property (nonatomic, strong) NSString * _Nullable accessKeyId;
		[NullAllowed, Export ("accessKeyId", ArgumentSemantic.Strong)]
		string AccessKeyId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable expiration;
		[NullAllowed, Export ("expiration", ArgumentSemantic.Strong)]
		NSDate Expiration { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable secretAccessKey;
		[NullAllowed, Export ("secretAccessKey", ArgumentSemantic.Strong)]
		string SecretAccessKey { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sessionToken;
		[NullAllowed, Export ("sessionToken", ArgumentSemantic.Strong)]
		string SessionToken { get; set; }
	}

	// @interface AWSSTSDecodeAuthorizationMessageRequest : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSSTSDecodeAuthorizationMessageRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable encodedMessage;
		[NullAllowed, Export ("encodedMessage", ArgumentSemantic.Strong)]
		string EncodedMessage { get; set; }
	}

	// @interface AWSSTSDecodeAuthorizationMessageResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSDecodeAuthorizationMessageResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable decodedMessage;
		[NullAllowed, Export ("decodedMessage", ArgumentSemantic.Strong)]
		string DecodedMessage { get; set; }
	}

	// @interface AWSSTSFederatedUser : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSFederatedUser
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable federatedUserId;
		[NullAllowed, Export ("federatedUserId", ArgumentSemantic.Strong)]
		string FederatedUserId { get; set; }
	}

	// @interface AWSSTSGetAccessKeyInfoRequest : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSSTSGetAccessKeyInfoRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable accessKeyId;
		[NullAllowed, Export ("accessKeyId", ArgumentSemantic.Strong)]
		string AccessKeyId { get; set; }
	}

	// @interface AWSSTSGetAccessKeyInfoResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSGetAccessKeyInfoResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable account;
		[NullAllowed, Export ("account", ArgumentSemantic.Strong)]
		string Account { get; set; }
	}

	// @interface AWSSTSGetCallerIdentityRequest : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSSTSGetCallerIdentityRequest
	{
	}

	// @interface AWSSTSGetCallerIdentityResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSGetCallerIdentityResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable account;
		[NullAllowed, Export ("account", ArgumentSemantic.Strong)]
		string Account { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable userId;
		[NullAllowed, Export ("userId", ArgumentSemantic.Strong)]
		string UserId { get; set; }
	}

	// @interface AWSSTSGetFederationTokenRequest : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSSTSGetFederationTokenRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable durationSeconds;
		[NullAllowed, Export ("durationSeconds", ArgumentSemantic.Strong)]
		NSNumber DurationSeconds { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policy;
		[NullAllowed, Export ("policy", ArgumentSemantic.Strong)]
		string Policy { get; set; }

		// @property (nonatomic, strong) NSArray<AWSSTSPolicyDescriptorType *> * _Nullable policyArns;
		[NullAllowed, Export ("policyArns", ArgumentSemantic.Strong)]
		AWSSTSPolicyDescriptorType[] PolicyArns { get; set; }

		// @property (nonatomic, strong) NSArray<AWSSTSTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSSTSTag[] Tags { get; set; }
	}

	// @interface AWSSTSGetFederationTokenResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSGetFederationTokenResponse
	{
		// @property (nonatomic, strong) AWSSTSCredentials * _Nullable credentials;
		[NullAllowed, Export ("credentials", ArgumentSemantic.Strong)]
		AWSSTSCredentials Credentials { get; set; }

		// @property (nonatomic, strong) AWSSTSFederatedUser * _Nullable federatedUser;
		[NullAllowed, Export ("federatedUser", ArgumentSemantic.Strong)]
		AWSSTSFederatedUser FederatedUser { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable packedPolicySize;
		[NullAllowed, Export ("packedPolicySize", ArgumentSemantic.Strong)]
		NSNumber PackedPolicySize { get; set; }
	}

	// @interface AWSSTSGetSessionTokenRequest : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSSTSGetSessionTokenRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable durationSeconds;
		[NullAllowed, Export ("durationSeconds", ArgumentSemantic.Strong)]
		NSNumber DurationSeconds { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable serialNumber;
		[NullAllowed, Export ("serialNumber", ArgumentSemantic.Strong)]
		string SerialNumber { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable tokenCode;
		[NullAllowed, Export ("tokenCode", ArgumentSemantic.Strong)]
		string TokenCode { get; set; }
	}

	// @interface AWSSTSGetSessionTokenResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSGetSessionTokenResponse
	{
		// @property (nonatomic, strong) AWSSTSCredentials * _Nullable credentials;
		[NullAllowed, Export ("credentials", ArgumentSemantic.Strong)]
		AWSSTSCredentials Credentials { get; set; }
	}

	// @interface AWSSTSPolicyDescriptorType : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSPolicyDescriptorType
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }
	}

	// @interface AWSSTSTag : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSSTSTag
	{
		// @property (nonatomic, strong) NSString * _Nullable key;
		[NullAllowed, Export ("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		string Value { get; set; }
	}

	// @interface AWSSTSResources : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSSTSResources
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		AWSSTSResources SharedInstance ();

		// -(NSDictionary *)JSONObject;
		[Export ("JSONObject")]
		[Verify (MethodToProperty)]
		NSDictionary JSONObject { get; }
	}

	// @interface AWSSTS : AWSService
	[BaseType (typeof(AWSService))]
	interface AWSSTS
	{
		// @property (readonly, nonatomic, strong) AWSServiceConfiguration * _Nonnull configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		AWSServiceConfiguration Configuration { get; }

		// +(instancetype _Nonnull)defaultSTS;
		[Static]
		[Export ("defaultSTS")]
		AWSSTS DefaultSTS ();

		// +(void)registerSTSWithConfiguration:(AWSServiceConfiguration * _Nonnull)configuration forKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("registerSTSWithConfiguration:forKey:")]
		void RegisterSTSWithConfiguration (AWSServiceConfiguration configuration, string key);

		// +(instancetype _Nonnull)STSForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("STSForKey:")]
		AWSSTS STSForKey (string key);

		// +(void)removeSTSForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("removeSTSForKey:")]
		void RemoveSTSForKey (string key);

		// -(AWSTask<AWSSTSAssumeRoleResponse *> * _Nonnull)assumeRole:(AWSSTSAssumeRoleRequest * _Nonnull)request;
		[Export ("assumeRole:")]
		AWSTask<AWSSTSAssumeRoleResponse> AssumeRole (AWSSTSAssumeRoleRequest request);

		// -(void)assumeRole:(AWSSTSAssumeRoleRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSSTSAssumeRoleResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("assumeRole:completionHandler:")]
		void AssumeRole (AWSSTSAssumeRoleRequest request, [NullAllowed] Action<AWSSTSAssumeRoleResponse, NSError> completionHandler);

		// -(AWSTask<AWSSTSAssumeRoleWithSAMLResponse *> * _Nonnull)assumeRoleWithSAML:(AWSSTSAssumeRoleWithSAMLRequest * _Nonnull)request;
		[Export ("assumeRoleWithSAML:")]
		AWSTask<AWSSTSAssumeRoleWithSAMLResponse> AssumeRoleWithSAML (AWSSTSAssumeRoleWithSAMLRequest request);

		// -(void)assumeRoleWithSAML:(AWSSTSAssumeRoleWithSAMLRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSSTSAssumeRoleWithSAMLResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("assumeRoleWithSAML:completionHandler:")]
		void AssumeRoleWithSAML (AWSSTSAssumeRoleWithSAMLRequest request, [NullAllowed] Action<AWSSTSAssumeRoleWithSAMLResponse, NSError> completionHandler);

		// -(AWSTask<AWSSTSAssumeRoleWithWebIdentityResponse *> * _Nonnull)assumeRoleWithWebIdentity:(AWSSTSAssumeRoleWithWebIdentityRequest * _Nonnull)request;
		[Export ("assumeRoleWithWebIdentity:")]
		AWSTask<AWSSTSAssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentity (AWSSTSAssumeRoleWithWebIdentityRequest request);

		// -(void)assumeRoleWithWebIdentity:(AWSSTSAssumeRoleWithWebIdentityRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSSTSAssumeRoleWithWebIdentityResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("assumeRoleWithWebIdentity:completionHandler:")]
		void AssumeRoleWithWebIdentity (AWSSTSAssumeRoleWithWebIdentityRequest request, [NullAllowed] Action<AWSSTSAssumeRoleWithWebIdentityResponse, NSError> completionHandler);

		// -(AWSTask<AWSSTSDecodeAuthorizationMessageResponse *> * _Nonnull)decodeAuthorizationMessage:(AWSSTSDecodeAuthorizationMessageRequest * _Nonnull)request;
		[Export ("decodeAuthorizationMessage:")]
		AWSTask<AWSSTSDecodeAuthorizationMessageResponse> DecodeAuthorizationMessage (AWSSTSDecodeAuthorizationMessageRequest request);

		// -(void)decodeAuthorizationMessage:(AWSSTSDecodeAuthorizationMessageRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSSTSDecodeAuthorizationMessageResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("decodeAuthorizationMessage:completionHandler:")]
		void DecodeAuthorizationMessage (AWSSTSDecodeAuthorizationMessageRequest request, [NullAllowed] Action<AWSSTSDecodeAuthorizationMessageResponse, NSError> completionHandler);

		// -(AWSTask<AWSSTSGetAccessKeyInfoResponse *> * _Nonnull)getAccessKeyInfo:(AWSSTSGetAccessKeyInfoRequest * _Nonnull)request;
		[Export ("getAccessKeyInfo:")]
		AWSTask<AWSSTSGetAccessKeyInfoResponse> GetAccessKeyInfo (AWSSTSGetAccessKeyInfoRequest request);

		// -(void)getAccessKeyInfo:(AWSSTSGetAccessKeyInfoRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSSTSGetAccessKeyInfoResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getAccessKeyInfo:completionHandler:")]
		void GetAccessKeyInfo (AWSSTSGetAccessKeyInfoRequest request, [NullAllowed] Action<AWSSTSGetAccessKeyInfoResponse, NSError> completionHandler);

		// -(AWSTask<AWSSTSGetCallerIdentityResponse *> * _Nonnull)getCallerIdentity:(AWSSTSGetCallerIdentityRequest * _Nonnull)request;
		[Export ("getCallerIdentity:")]
		AWSTask<AWSSTSGetCallerIdentityResponse> GetCallerIdentity (AWSSTSGetCallerIdentityRequest request);

		// -(void)getCallerIdentity:(AWSSTSGetCallerIdentityRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSSTSGetCallerIdentityResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getCallerIdentity:completionHandler:")]
		void GetCallerIdentity (AWSSTSGetCallerIdentityRequest request, [NullAllowed] Action<AWSSTSGetCallerIdentityResponse, NSError> completionHandler);

		// -(AWSTask<AWSSTSGetFederationTokenResponse *> * _Nonnull)getFederationToken:(AWSSTSGetFederationTokenRequest * _Nonnull)request;
		[Export ("getFederationToken:")]
		AWSTask<AWSSTSGetFederationTokenResponse> GetFederationToken (AWSSTSGetFederationTokenRequest request);

		// -(void)getFederationToken:(AWSSTSGetFederationTokenRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSSTSGetFederationTokenResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getFederationToken:completionHandler:")]
		void GetFederationToken (AWSSTSGetFederationTokenRequest request, [NullAllowed] Action<AWSSTSGetFederationTokenResponse, NSError> completionHandler);

		// -(AWSTask<AWSSTSGetSessionTokenResponse *> * _Nonnull)getSessionToken:(AWSSTSGetSessionTokenRequest * _Nonnull)request;
		[Export ("getSessionToken:")]
		AWSTask<AWSSTSGetSessionTokenResponse> GetSessionToken (AWSSTSGetSessionTokenRequest request);

		// -(void)getSessionToken:(AWSSTSGetSessionTokenRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSSTSGetSessionTokenResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getSessionToken:completionHandler:")]
		void GetSessionToken (AWSSTSGetSessionTokenRequest request, [NullAllowed] Action<AWSSTSGetSessionTokenResponse, NSError> completionHandler);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSCognitoIdentityErrorDomain;
		[Field ("AWSCognitoIdentityErrorDomain", "__Internal")]
		NSString AWSCognitoIdentityErrorDomain { get; }
	}

	// @interface AWSCognitoIdentityCognitoIdentityProvider : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityCognitoIdentityProvider
	{
		// @property (nonatomic, strong) NSString * _Nullable clientId;
		[NullAllowed, Export ("clientId", ArgumentSemantic.Strong)]
		string ClientId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable providerName;
		[NullAllowed, Export ("providerName", ArgumentSemantic.Strong)]
		string ProviderName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable serverSideTokenCheck;
		[NullAllowed, Export ("serverSideTokenCheck", ArgumentSemantic.Strong)]
		NSNumber ServerSideTokenCheck { get; set; }
	}

	// @interface AWSCognitoIdentityCreateIdentityPoolInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityCreateIdentityPoolInput
	{
		// @property (nonatomic, strong) NSNumber * _Nullable allowClassicFlow;
		[NullAllowed, Export ("allowClassicFlow", ArgumentSemantic.Strong)]
		NSNumber AllowClassicFlow { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable allowUnauthenticatedIdentities;
		[NullAllowed, Export ("allowUnauthenticatedIdentities", ArgumentSemantic.Strong)]
		NSNumber AllowUnauthenticatedIdentities { get; set; }

		// @property (nonatomic, strong) NSArray<AWSCognitoIdentityCognitoIdentityProvider *> * _Nullable cognitoIdentityProviders;
		[NullAllowed, Export ("cognitoIdentityProviders", ArgumentSemantic.Strong)]
		AWSCognitoIdentityCognitoIdentityProvider[] CognitoIdentityProviders { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable developerProviderName;
		[NullAllowed, Export ("developerProviderName", ArgumentSemantic.Strong)]
		string DeveloperProviderName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityPoolName;
		[NullAllowed, Export ("identityPoolName", ArgumentSemantic.Strong)]
		string IdentityPoolName { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable identityPoolTags;
		[NullAllowed, Export ("identityPoolTags", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> IdentityPoolTags { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable openIdConnectProviderARNs;
		[NullAllowed, Export ("openIdConnectProviderARNs", ArgumentSemantic.Strong)]
		string[] OpenIdConnectProviderARNs { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable samlProviderARNs;
		[NullAllowed, Export ("samlProviderARNs", ArgumentSemantic.Strong)]
		string[] SamlProviderARNs { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable supportedLoginProviders;
		[NullAllowed, Export ("supportedLoginProviders", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> SupportedLoginProviders { get; set; }
	}

	// @interface AWSCognitoIdentityCredentials : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityCredentials
	{
		// @property (nonatomic, strong) NSString * _Nullable accessKeyId;
		[NullAllowed, Export ("accessKeyId", ArgumentSemantic.Strong)]
		string AccessKeyId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable expiration;
		[NullAllowed, Export ("expiration", ArgumentSemantic.Strong)]
		NSDate Expiration { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable secretKey;
		[NullAllowed, Export ("secretKey", ArgumentSemantic.Strong)]
		string SecretKey { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sessionToken;
		[NullAllowed, Export ("sessionToken", ArgumentSemantic.Strong)]
		string SessionToken { get; set; }
	}

	// @interface AWSCognitoIdentityDeleteIdentitiesInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityDeleteIdentitiesInput
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable identityIdsToDelete;
		[NullAllowed, Export ("identityIdsToDelete", ArgumentSemantic.Strong)]
		string[] IdentityIdsToDelete { get; set; }
	}

	// @interface AWSCognitoIdentityDeleteIdentitiesResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityDeleteIdentitiesResponse
	{
		// @property (nonatomic, strong) NSArray<AWSCognitoIdentityUnprocessedIdentityId *> * _Nullable unprocessedIdentityIds;
		[NullAllowed, Export ("unprocessedIdentityIds", ArgumentSemantic.Strong)]
		AWSCognitoIdentityUnprocessedIdentityId[] UnprocessedIdentityIds { get; set; }
	}

	// @interface AWSCognitoIdentityDeleteIdentityPoolInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityDeleteIdentityPoolInput
	{
		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }
	}

	// @interface AWSCognitoIdentityDescribeIdentityInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityDescribeIdentityInput
	{
		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }
	}

	// @interface AWSCognitoIdentityDescribeIdentityPoolInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityDescribeIdentityPoolInput
	{
		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }
	}

	// @interface AWSCognitoIdentityGetCredentialsForIdentityInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityGetCredentialsForIdentityInput
	{
		// @property (nonatomic, strong) NSString * _Nullable customRoleArn;
		[NullAllowed, Export ("customRoleArn", ArgumentSemantic.Strong)]
		string CustomRoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable logins;
		[NullAllowed, Export ("logins", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Logins { get; set; }
	}

	// @interface AWSCognitoIdentityGetCredentialsForIdentityResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityGetCredentialsForIdentityResponse
	{
		// @property (nonatomic, strong) AWSCognitoIdentityCredentials * _Nullable credentials;
		[NullAllowed, Export ("credentials", ArgumentSemantic.Strong)]
		AWSCognitoIdentityCredentials Credentials { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }
	}

	// @interface AWSCognitoIdentityGetIdInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityGetIdInput
	{
		// @property (nonatomic, strong) NSString * _Nullable accountId;
		[NullAllowed, Export ("accountId", ArgumentSemantic.Strong)]
		string AccountId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable logins;
		[NullAllowed, Export ("logins", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Logins { get; set; }
	}

	// @interface AWSCognitoIdentityGetIdResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityGetIdResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }
	}

	// @interface AWSCognitoIdentityGetIdentityPoolRolesInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityGetIdentityPoolRolesInput
	{
		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }
	}

	// @interface AWSCognitoIdentityGetIdentityPoolRolesResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityGetIdentityPoolRolesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,AWSCognitoIdentityRoleMapping *> * _Nullable roleMappings;
		[NullAllowed, Export ("roleMappings", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSCognitoIdentityRoleMapping> RoleMappings { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable roles;
		[NullAllowed, Export ("roles", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Roles { get; set; }
	}

	// @interface AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityInput
	{
		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable logins;
		[NullAllowed, Export ("logins", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Logins { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable principalTags;
		[NullAllowed, Export ("principalTags", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> PrincipalTags { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable tokenDuration;
		[NullAllowed, Export ("tokenDuration", ArgumentSemantic.Strong)]
		NSNumber TokenDuration { get; set; }
	}

	// @interface AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable token;
		[NullAllowed, Export ("token", ArgumentSemantic.Strong)]
		string Token { get; set; }
	}

	// @interface AWSCognitoIdentityGetOpenIdTokenInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityGetOpenIdTokenInput
	{
		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable logins;
		[NullAllowed, Export ("logins", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Logins { get; set; }
	}

	// @interface AWSCognitoIdentityGetOpenIdTokenResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityGetOpenIdTokenResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable token;
		[NullAllowed, Export ("token", ArgumentSemantic.Strong)]
		string Token { get; set; }
	}

	// @interface AWSCognitoIdentityGetPrincipalTagAttributeMapInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityGetPrincipalTagAttributeMapInput
	{
		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityProviderName;
		[NullAllowed, Export ("identityProviderName", ArgumentSemantic.Strong)]
		string IdentityProviderName { get; set; }
	}

	// @interface AWSCognitoIdentityGetPrincipalTagAttributeMapResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityGetPrincipalTagAttributeMapResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityProviderName;
		[NullAllowed, Export ("identityProviderName", ArgumentSemantic.Strong)]
		string IdentityProviderName { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable principalTags;
		[NullAllowed, Export ("principalTags", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> PrincipalTags { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable useDefaults;
		[NullAllowed, Export ("useDefaults", ArgumentSemantic.Strong)]
		NSNumber UseDefaults { get; set; }
	}

	// @interface AWSCognitoIdentityIdentityDescription : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityIdentityDescription
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable logins;
		[NullAllowed, Export ("logins", ArgumentSemantic.Strong)]
		string[] Logins { get; set; }
	}

	// @interface AWSCognitoIdentityIdentityPool : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityIdentityPool
	{
		// @property (nonatomic, strong) NSNumber * _Nullable allowClassicFlow;
		[NullAllowed, Export ("allowClassicFlow", ArgumentSemantic.Strong)]
		NSNumber AllowClassicFlow { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable allowUnauthenticatedIdentities;
		[NullAllowed, Export ("allowUnauthenticatedIdentities", ArgumentSemantic.Strong)]
		NSNumber AllowUnauthenticatedIdentities { get; set; }

		// @property (nonatomic, strong) NSArray<AWSCognitoIdentityCognitoIdentityProvider *> * _Nullable cognitoIdentityProviders;
		[NullAllowed, Export ("cognitoIdentityProviders", ArgumentSemantic.Strong)]
		AWSCognitoIdentityCognitoIdentityProvider[] CognitoIdentityProviders { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable developerProviderName;
		[NullAllowed, Export ("developerProviderName", ArgumentSemantic.Strong)]
		string DeveloperProviderName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityPoolName;
		[NullAllowed, Export ("identityPoolName", ArgumentSemantic.Strong)]
		string IdentityPoolName { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable identityPoolTags;
		[NullAllowed, Export ("identityPoolTags", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> IdentityPoolTags { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable openIdConnectProviderARNs;
		[NullAllowed, Export ("openIdConnectProviderARNs", ArgumentSemantic.Strong)]
		string[] OpenIdConnectProviderARNs { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable samlProviderARNs;
		[NullAllowed, Export ("samlProviderARNs", ArgumentSemantic.Strong)]
		string[] SamlProviderARNs { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable supportedLoginProviders;
		[NullAllowed, Export ("supportedLoginProviders", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> SupportedLoginProviders { get; set; }
	}

	// @interface AWSCognitoIdentityIdentityPoolShortDescription : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityIdentityPoolShortDescription
	{
		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityPoolName;
		[NullAllowed, Export ("identityPoolName", ArgumentSemantic.Strong)]
		string IdentityPoolName { get; set; }
	}

	// @interface AWSCognitoIdentityListIdentitiesInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityListIdentitiesInput
	{
		// @property (nonatomic, strong) NSNumber * _Nullable hideDisabled;
		[NullAllowed, Export ("hideDisabled", ArgumentSemantic.Strong)]
		NSNumber HideDisabled { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSCognitoIdentityListIdentitiesResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityListIdentitiesResponse
	{
		// @property (nonatomic, strong) NSArray<AWSCognitoIdentityIdentityDescription *> * _Nullable identities;
		[NullAllowed, Export ("identities", ArgumentSemantic.Strong)]
		AWSCognitoIdentityIdentityDescription[] Identities { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSCognitoIdentityListIdentityPoolsInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityListIdentityPoolsInput
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSCognitoIdentityListIdentityPoolsResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityListIdentityPoolsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSCognitoIdentityIdentityPoolShortDescription *> * _Nullable identityPools;
		[NullAllowed, Export ("identityPools", ArgumentSemantic.Strong)]
		AWSCognitoIdentityIdentityPoolShortDescription[] IdentityPools { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSCognitoIdentityListTagsForResourceInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityListTagsForResourceInput
	{
		// @property (nonatomic, strong) NSString * _Nullable resourceArn;
		[NullAllowed, Export ("resourceArn", ArgumentSemantic.Strong)]
		string ResourceArn { get; set; }
	}

	// @interface AWSCognitoIdentityListTagsForResourceResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityListTagsForResourceResponse
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Tags { get; set; }
	}

	// @interface AWSCognitoIdentityLookupDeveloperIdentityInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityLookupDeveloperIdentityInput
	{
		// @property (nonatomic, strong) NSString * _Nullable developerUserIdentifier;
		[NullAllowed, Export ("developerUserIdentifier", ArgumentSemantic.Strong)]
		string DeveloperUserIdentifier { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSCognitoIdentityLookupDeveloperIdentityResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityLookupDeveloperIdentityResponse
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable developerUserIdentifierList;
		[NullAllowed, Export ("developerUserIdentifierList", ArgumentSemantic.Strong)]
		string[] DeveloperUserIdentifierList { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSCognitoIdentityMappingRule : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityMappingRule
	{
		// @property (nonatomic, strong) NSString * _Nullable claim;
		[NullAllowed, Export ("claim", ArgumentSemantic.Strong)]
		string Claim { get; set; }

		// @property (assign, nonatomic) AWSCognitoIdentityMappingRuleMatchType matchType;
		[Export ("matchType", ArgumentSemantic.Assign)]
		AWSCognitoIdentityMappingRuleMatchType MatchType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleARN;
		[NullAllowed, Export ("roleARN", ArgumentSemantic.Strong)]
		string RoleARN { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		string Value { get; set; }
	}

	// @interface AWSCognitoIdentityMergeDeveloperIdentitiesInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityMergeDeveloperIdentitiesInput
	{
		// @property (nonatomic, strong) NSString * _Nullable destinationUserIdentifier;
		[NullAllowed, Export ("destinationUserIdentifier", ArgumentSemantic.Strong)]
		string DestinationUserIdentifier { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable developerProviderName;
		[NullAllowed, Export ("developerProviderName", ArgumentSemantic.Strong)]
		string DeveloperProviderName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sourceUserIdentifier;
		[NullAllowed, Export ("sourceUserIdentifier", ArgumentSemantic.Strong)]
		string SourceUserIdentifier { get; set; }
	}

	// @interface AWSCognitoIdentityMergeDeveloperIdentitiesResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityMergeDeveloperIdentitiesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }
	}

	// @interface AWSCognitoIdentityRoleMapping : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityRoleMapping
	{
		// @property (assign, nonatomic) AWSCognitoIdentityAmbiguousRoleResolutionType ambiguousRoleResolution;
		[Export ("ambiguousRoleResolution", ArgumentSemantic.Assign)]
		AWSCognitoIdentityAmbiguousRoleResolutionType AmbiguousRoleResolution { get; set; }

		// @property (nonatomic, strong) AWSCognitoIdentityRulesConfigurationType * _Nullable rulesConfiguration;
		[NullAllowed, Export ("rulesConfiguration", ArgumentSemantic.Strong)]
		AWSCognitoIdentityRulesConfigurationType RulesConfiguration { get; set; }

		// @property (assign, nonatomic) AWSCognitoIdentityRoleMappingType types;
		[Export ("types", ArgumentSemantic.Assign)]
		AWSCognitoIdentityRoleMappingType Types { get; set; }
	}

	// @interface AWSCognitoIdentityRulesConfigurationType : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityRulesConfigurationType
	{
		// @property (nonatomic, strong) NSArray<AWSCognitoIdentityMappingRule *> * _Nullable rules;
		[NullAllowed, Export ("rules", ArgumentSemantic.Strong)]
		AWSCognitoIdentityMappingRule[] Rules { get; set; }
	}

	// @interface AWSCognitoIdentitySetIdentityPoolRolesInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentitySetIdentityPoolRolesInput
	{
		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,AWSCognitoIdentityRoleMapping *> * _Nullable roleMappings;
		[NullAllowed, Export ("roleMappings", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSCognitoIdentityRoleMapping> RoleMappings { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable roles;
		[NullAllowed, Export ("roles", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Roles { get; set; }
	}

	// @interface AWSCognitoIdentitySetPrincipalTagAttributeMapInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentitySetPrincipalTagAttributeMapInput
	{
		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityProviderName;
		[NullAllowed, Export ("identityProviderName", ArgumentSemantic.Strong)]
		string IdentityProviderName { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable principalTags;
		[NullAllowed, Export ("principalTags", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> PrincipalTags { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable useDefaults;
		[NullAllowed, Export ("useDefaults", ArgumentSemantic.Strong)]
		NSNumber UseDefaults { get; set; }
	}

	// @interface AWSCognitoIdentitySetPrincipalTagAttributeMapResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentitySetPrincipalTagAttributeMapResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityProviderName;
		[NullAllowed, Export ("identityProviderName", ArgumentSemantic.Strong)]
		string IdentityProviderName { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable principalTags;
		[NullAllowed, Export ("principalTags", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> PrincipalTags { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable useDefaults;
		[NullAllowed, Export ("useDefaults", ArgumentSemantic.Strong)]
		NSNumber UseDefaults { get; set; }
	}

	// @interface AWSCognitoIdentityTagResourceInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityTagResourceInput
	{
		// @property (nonatomic, strong) NSString * _Nullable resourceArn;
		[NullAllowed, Export ("resourceArn", ArgumentSemantic.Strong)]
		string ResourceArn { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Tags { get; set; }
	}

	// @interface AWSCognitoIdentityTagResourceResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityTagResourceResponse
	{
	}

	// @interface AWSCognitoIdentityUnlinkDeveloperIdentityInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityUnlinkDeveloperIdentityInput
	{
		// @property (nonatomic, strong) NSString * _Nullable developerProviderName;
		[NullAllowed, Export ("developerProviderName", ArgumentSemantic.Strong)]
		string DeveloperProviderName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable developerUserIdentifier;
		[NullAllowed, Export ("developerUserIdentifier", ArgumentSemantic.Strong)]
		string DeveloperUserIdentifier { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityPoolId;
		[NullAllowed, Export ("identityPoolId", ArgumentSemantic.Strong)]
		string IdentityPoolId { get; set; }
	}

	// @interface AWSCognitoIdentityUnlinkIdentityInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityUnlinkIdentityInput
	{
		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable logins;
		[NullAllowed, Export ("logins", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Logins { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable loginsToRemove;
		[NullAllowed, Export ("loginsToRemove", ArgumentSemantic.Strong)]
		string[] LoginsToRemove { get; set; }
	}

	// @interface AWSCognitoIdentityUnprocessedIdentityId : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityUnprocessedIdentityId
	{
		// @property (assign, nonatomic) AWSCognitoIdentityErrorCode errorCode;
		[Export ("errorCode", ArgumentSemantic.Assign)]
		AWSCognitoIdentityErrorCode ErrorCode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identityId;
		[NullAllowed, Export ("identityId", ArgumentSemantic.Strong)]
		string IdentityId { get; set; }
	}

	// @interface AWSCognitoIdentityUntagResourceInput : AWSRequest
	[BaseType (typeof(AWSRequest))]
	interface AWSCognitoIdentityUntagResourceInput
	{
		// @property (nonatomic, strong) NSString * _Nullable resourceArn;
		[NullAllowed, Export ("resourceArn", ArgumentSemantic.Strong)]
		string ResourceArn { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable tagKeys;
		[NullAllowed, Export ("tagKeys", ArgumentSemantic.Strong)]
		string[] TagKeys { get; set; }
	}

	// @interface AWSCognitoIdentityUntagResourceResponse : AWSModel
	[BaseType (typeof(AWSModel))]
	interface AWSCognitoIdentityUntagResourceResponse
	{
	}

	// @interface AWSCognitoIdentityResources : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSCognitoIdentityResources
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		AWSCognitoIdentityResources SharedInstance ();

		// -(NSDictionary *)JSONObject;
		[Export ("JSONObject")]
		[Verify (MethodToProperty)]
		NSDictionary JSONObject { get; }
	}

	// @interface AWSCognitoIdentity : AWSService
	[BaseType (typeof(AWSService))]
	interface AWSCognitoIdentity
	{
		// @property (readonly, nonatomic, strong) AWSServiceConfiguration * _Nonnull configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		AWSServiceConfiguration Configuration { get; }

		// +(instancetype _Nonnull)defaultCognitoIdentity;
		[Static]
		[Export ("defaultCognitoIdentity")]
		AWSCognitoIdentity DefaultCognitoIdentity ();

		// +(void)registerCognitoIdentityWithConfiguration:(AWSServiceConfiguration * _Nonnull)configuration forKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("registerCognitoIdentityWithConfiguration:forKey:")]
		void RegisterCognitoIdentityWithConfiguration (AWSServiceConfiguration configuration, string key);

		// +(instancetype _Nonnull)CognitoIdentityForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("CognitoIdentityForKey:")]
		AWSCognitoIdentity CognitoIdentityForKey (string key);

		// +(void)removeCognitoIdentityForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("removeCognitoIdentityForKey:")]
		void RemoveCognitoIdentityForKey (string key);

		// -(AWSTask<AWSCognitoIdentityIdentityPool *> * _Nonnull)createIdentityPool:(AWSCognitoIdentityCreateIdentityPoolInput * _Nonnull)request;
		[Export ("createIdentityPool:")]
		AWSTask<AWSCognitoIdentityIdentityPool> CreateIdentityPool (AWSCognitoIdentityCreateIdentityPoolInput request);

		// -(void)createIdentityPool:(AWSCognitoIdentityCreateIdentityPoolInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityIdentityPool * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createIdentityPool:completionHandler:")]
		void CreateIdentityPool (AWSCognitoIdentityCreateIdentityPoolInput request, [NullAllowed] Action<AWSCognitoIdentityIdentityPool, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityDeleteIdentitiesResponse *> * _Nonnull)deleteIdentities:(AWSCognitoIdentityDeleteIdentitiesInput * _Nonnull)request;
		[Export ("deleteIdentities:")]
		AWSTask<AWSCognitoIdentityDeleteIdentitiesResponse> DeleteIdentities (AWSCognitoIdentityDeleteIdentitiesInput request);

		// -(void)deleteIdentities:(AWSCognitoIdentityDeleteIdentitiesInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityDeleteIdentitiesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteIdentities:completionHandler:")]
		void DeleteIdentities (AWSCognitoIdentityDeleteIdentitiesInput request, [NullAllowed] Action<AWSCognitoIdentityDeleteIdentitiesResponse, NSError> completionHandler);

		// -(AWSTask * _Nonnull)deleteIdentityPool:(AWSCognitoIdentityDeleteIdentityPoolInput * _Nonnull)request;
		[Export ("deleteIdentityPool:")]
		AWSTask DeleteIdentityPool (AWSCognitoIdentityDeleteIdentityPoolInput request);

		// -(void)deleteIdentityPool:(AWSCognitoIdentityDeleteIdentityPoolInput * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("deleteIdentityPool:completionHandler:")]
		void DeleteIdentityPool (AWSCognitoIdentityDeleteIdentityPoolInput request, [NullAllowed] Action<NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityIdentityDescription *> * _Nonnull)describeIdentity:(AWSCognitoIdentityDescribeIdentityInput * _Nonnull)request;
		[Export ("describeIdentity:")]
		AWSTask<AWSCognitoIdentityIdentityDescription> DescribeIdentity (AWSCognitoIdentityDescribeIdentityInput request);

		// -(void)describeIdentity:(AWSCognitoIdentityDescribeIdentityInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityIdentityDescription * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeIdentity:completionHandler:")]
		void DescribeIdentity (AWSCognitoIdentityDescribeIdentityInput request, [NullAllowed] Action<AWSCognitoIdentityIdentityDescription, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityIdentityPool *> * _Nonnull)describeIdentityPool:(AWSCognitoIdentityDescribeIdentityPoolInput * _Nonnull)request;
		[Export ("describeIdentityPool:")]
		AWSTask<AWSCognitoIdentityIdentityPool> DescribeIdentityPool (AWSCognitoIdentityDescribeIdentityPoolInput request);

		// -(void)describeIdentityPool:(AWSCognitoIdentityDescribeIdentityPoolInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityIdentityPool * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeIdentityPool:completionHandler:")]
		void DescribeIdentityPool (AWSCognitoIdentityDescribeIdentityPoolInput request, [NullAllowed] Action<AWSCognitoIdentityIdentityPool, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityGetCredentialsForIdentityResponse *> * _Nonnull)getCredentialsForIdentity:(AWSCognitoIdentityGetCredentialsForIdentityInput * _Nonnull)request;
		[Export ("getCredentialsForIdentity:")]
		AWSTask<AWSCognitoIdentityGetCredentialsForIdentityResponse> GetCredentialsForIdentity (AWSCognitoIdentityGetCredentialsForIdentityInput request);

		// -(void)getCredentialsForIdentity:(AWSCognitoIdentityGetCredentialsForIdentityInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityGetCredentialsForIdentityResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getCredentialsForIdentity:completionHandler:")]
		void GetCredentialsForIdentity (AWSCognitoIdentityGetCredentialsForIdentityInput request, [NullAllowed] Action<AWSCognitoIdentityGetCredentialsForIdentityResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityGetIdResponse *> * _Nonnull)getId:(AWSCognitoIdentityGetIdInput * _Nonnull)request;
		[Export ("getId:")]
		AWSTask<AWSCognitoIdentityGetIdResponse> GetId (AWSCognitoIdentityGetIdInput request);

		// -(void)getId:(AWSCognitoIdentityGetIdInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityGetIdResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getId:completionHandler:")]
		void GetId (AWSCognitoIdentityGetIdInput request, [NullAllowed] Action<AWSCognitoIdentityGetIdResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityGetIdentityPoolRolesResponse *> * _Nonnull)getIdentityPoolRoles:(AWSCognitoIdentityGetIdentityPoolRolesInput * _Nonnull)request;
		[Export ("getIdentityPoolRoles:")]
		AWSTask<AWSCognitoIdentityGetIdentityPoolRolesResponse> GetIdentityPoolRoles (AWSCognitoIdentityGetIdentityPoolRolesInput request);

		// -(void)getIdentityPoolRoles:(AWSCognitoIdentityGetIdentityPoolRolesInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityGetIdentityPoolRolesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getIdentityPoolRoles:completionHandler:")]
		void GetIdentityPoolRoles (AWSCognitoIdentityGetIdentityPoolRolesInput request, [NullAllowed] Action<AWSCognitoIdentityGetIdentityPoolRolesResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityGetOpenIdTokenResponse *> * _Nonnull)getOpenIdToken:(AWSCognitoIdentityGetOpenIdTokenInput * _Nonnull)request;
		[Export ("getOpenIdToken:")]
		AWSTask<AWSCognitoIdentityGetOpenIdTokenResponse> GetOpenIdToken (AWSCognitoIdentityGetOpenIdTokenInput request);

		// -(void)getOpenIdToken:(AWSCognitoIdentityGetOpenIdTokenInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityGetOpenIdTokenResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getOpenIdToken:completionHandler:")]
		void GetOpenIdToken (AWSCognitoIdentityGetOpenIdTokenInput request, [NullAllowed] Action<AWSCognitoIdentityGetOpenIdTokenResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityResponse *> * _Nonnull)getOpenIdTokenForDeveloperIdentity:(AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityInput * _Nonnull)request;
		[Export ("getOpenIdTokenForDeveloperIdentity:")]
		AWSTask<AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityResponse> GetOpenIdTokenForDeveloperIdentity (AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityInput request);

		// -(void)getOpenIdTokenForDeveloperIdentity:(AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getOpenIdTokenForDeveloperIdentity:completionHandler:")]
		void GetOpenIdTokenForDeveloperIdentity (AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityInput request, [NullAllowed] Action<AWSCognitoIdentityGetOpenIdTokenForDeveloperIdentityResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityGetPrincipalTagAttributeMapResponse *> * _Nonnull)getPrincipalTagAttributeMap:(AWSCognitoIdentityGetPrincipalTagAttributeMapInput * _Nonnull)request;
		[Export ("getPrincipalTagAttributeMap:")]
		AWSTask<AWSCognitoIdentityGetPrincipalTagAttributeMapResponse> GetPrincipalTagAttributeMap (AWSCognitoIdentityGetPrincipalTagAttributeMapInput request);

		// -(void)getPrincipalTagAttributeMap:(AWSCognitoIdentityGetPrincipalTagAttributeMapInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityGetPrincipalTagAttributeMapResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getPrincipalTagAttributeMap:completionHandler:")]
		void GetPrincipalTagAttributeMap (AWSCognitoIdentityGetPrincipalTagAttributeMapInput request, [NullAllowed] Action<AWSCognitoIdentityGetPrincipalTagAttributeMapResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityListIdentitiesResponse *> * _Nonnull)listIdentities:(AWSCognitoIdentityListIdentitiesInput * _Nonnull)request;
		[Export ("listIdentities:")]
		AWSTask<AWSCognitoIdentityListIdentitiesResponse> ListIdentities (AWSCognitoIdentityListIdentitiesInput request);

		// -(void)listIdentities:(AWSCognitoIdentityListIdentitiesInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityListIdentitiesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listIdentities:completionHandler:")]
		void ListIdentities (AWSCognitoIdentityListIdentitiesInput request, [NullAllowed] Action<AWSCognitoIdentityListIdentitiesResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityListIdentityPoolsResponse *> * _Nonnull)listIdentityPools:(AWSCognitoIdentityListIdentityPoolsInput * _Nonnull)request;
		[Export ("listIdentityPools:")]
		AWSTask<AWSCognitoIdentityListIdentityPoolsResponse> ListIdentityPools (AWSCognitoIdentityListIdentityPoolsInput request);

		// -(void)listIdentityPools:(AWSCognitoIdentityListIdentityPoolsInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityListIdentityPoolsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listIdentityPools:completionHandler:")]
		void ListIdentityPools (AWSCognitoIdentityListIdentityPoolsInput request, [NullAllowed] Action<AWSCognitoIdentityListIdentityPoolsResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityListTagsForResourceResponse *> * _Nonnull)listTagsForResource:(AWSCognitoIdentityListTagsForResourceInput * _Nonnull)request;
		[Export ("listTagsForResource:")]
		AWSTask<AWSCognitoIdentityListTagsForResourceResponse> ListTagsForResource (AWSCognitoIdentityListTagsForResourceInput request);

		// -(void)listTagsForResource:(AWSCognitoIdentityListTagsForResourceInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityListTagsForResourceResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listTagsForResource:completionHandler:")]
		void ListTagsForResource (AWSCognitoIdentityListTagsForResourceInput request, [NullAllowed] Action<AWSCognitoIdentityListTagsForResourceResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityLookupDeveloperIdentityResponse *> * _Nonnull)lookupDeveloperIdentity:(AWSCognitoIdentityLookupDeveloperIdentityInput * _Nonnull)request;
		[Export ("lookupDeveloperIdentity:")]
		AWSTask<AWSCognitoIdentityLookupDeveloperIdentityResponse> LookupDeveloperIdentity (AWSCognitoIdentityLookupDeveloperIdentityInput request);

		// -(void)lookupDeveloperIdentity:(AWSCognitoIdentityLookupDeveloperIdentityInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityLookupDeveloperIdentityResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("lookupDeveloperIdentity:completionHandler:")]
		void LookupDeveloperIdentity (AWSCognitoIdentityLookupDeveloperIdentityInput request, [NullAllowed] Action<AWSCognitoIdentityLookupDeveloperIdentityResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityMergeDeveloperIdentitiesResponse *> * _Nonnull)mergeDeveloperIdentities:(AWSCognitoIdentityMergeDeveloperIdentitiesInput * _Nonnull)request;
		[Export ("mergeDeveloperIdentities:")]
		AWSTask<AWSCognitoIdentityMergeDeveloperIdentitiesResponse> MergeDeveloperIdentities (AWSCognitoIdentityMergeDeveloperIdentitiesInput request);

		// -(void)mergeDeveloperIdentities:(AWSCognitoIdentityMergeDeveloperIdentitiesInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityMergeDeveloperIdentitiesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("mergeDeveloperIdentities:completionHandler:")]
		void MergeDeveloperIdentities (AWSCognitoIdentityMergeDeveloperIdentitiesInput request, [NullAllowed] Action<AWSCognitoIdentityMergeDeveloperIdentitiesResponse, NSError> completionHandler);

		// -(AWSTask * _Nonnull)setIdentityPoolRoles:(AWSCognitoIdentitySetIdentityPoolRolesInput * _Nonnull)request;
		[Export ("setIdentityPoolRoles:")]
		AWSTask SetIdentityPoolRoles (AWSCognitoIdentitySetIdentityPoolRolesInput request);

		// -(void)setIdentityPoolRoles:(AWSCognitoIdentitySetIdentityPoolRolesInput * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("setIdentityPoolRoles:completionHandler:")]
		void SetIdentityPoolRoles (AWSCognitoIdentitySetIdentityPoolRolesInput request, [NullAllowed] Action<NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentitySetPrincipalTagAttributeMapResponse *> * _Nonnull)setPrincipalTagAttributeMap:(AWSCognitoIdentitySetPrincipalTagAttributeMapInput * _Nonnull)request;
		[Export ("setPrincipalTagAttributeMap:")]
		AWSTask<AWSCognitoIdentitySetPrincipalTagAttributeMapResponse> SetPrincipalTagAttributeMap (AWSCognitoIdentitySetPrincipalTagAttributeMapInput request);

		// -(void)setPrincipalTagAttributeMap:(AWSCognitoIdentitySetPrincipalTagAttributeMapInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentitySetPrincipalTagAttributeMapResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("setPrincipalTagAttributeMap:completionHandler:")]
		void SetPrincipalTagAttributeMap (AWSCognitoIdentitySetPrincipalTagAttributeMapInput request, [NullAllowed] Action<AWSCognitoIdentitySetPrincipalTagAttributeMapResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityTagResourceResponse *> * _Nonnull)tagResource:(AWSCognitoIdentityTagResourceInput * _Nonnull)request;
		[Export ("tagResource:")]
		AWSTask<AWSCognitoIdentityTagResourceResponse> TagResource (AWSCognitoIdentityTagResourceInput request);

		// -(void)tagResource:(AWSCognitoIdentityTagResourceInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityTagResourceResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("tagResource:completionHandler:")]
		void TagResource (AWSCognitoIdentityTagResourceInput request, [NullAllowed] Action<AWSCognitoIdentityTagResourceResponse, NSError> completionHandler);

		// -(AWSTask * _Nonnull)unlinkDeveloperIdentity:(AWSCognitoIdentityUnlinkDeveloperIdentityInput * _Nonnull)request;
		[Export ("unlinkDeveloperIdentity:")]
		AWSTask UnlinkDeveloperIdentity (AWSCognitoIdentityUnlinkDeveloperIdentityInput request);

		// -(void)unlinkDeveloperIdentity:(AWSCognitoIdentityUnlinkDeveloperIdentityInput * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("unlinkDeveloperIdentity:completionHandler:")]
		void UnlinkDeveloperIdentity (AWSCognitoIdentityUnlinkDeveloperIdentityInput request, [NullAllowed] Action<NSError> completionHandler);

		// -(AWSTask * _Nonnull)unlinkIdentity:(AWSCognitoIdentityUnlinkIdentityInput * _Nonnull)request;
		[Export ("unlinkIdentity:")]
		AWSTask UnlinkIdentity (AWSCognitoIdentityUnlinkIdentityInput request);

		// -(void)unlinkIdentity:(AWSCognitoIdentityUnlinkIdentityInput * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("unlinkIdentity:completionHandler:")]
		void UnlinkIdentity (AWSCognitoIdentityUnlinkIdentityInput request, [NullAllowed] Action<NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityUntagResourceResponse *> * _Nonnull)untagResource:(AWSCognitoIdentityUntagResourceInput * _Nonnull)request;
		[Export ("untagResource:")]
		AWSTask<AWSCognitoIdentityUntagResourceResponse> UntagResource (AWSCognitoIdentityUntagResourceInput request);

		// -(void)untagResource:(AWSCognitoIdentityUntagResourceInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityUntagResourceResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("untagResource:completionHandler:")]
		void UntagResource (AWSCognitoIdentityUntagResourceInput request, [NullAllowed] Action<AWSCognitoIdentityUntagResourceResponse, NSError> completionHandler);

		// -(AWSTask<AWSCognitoIdentityIdentityPool *> * _Nonnull)updateIdentityPool:(AWSCognitoIdentityIdentityPool * _Nonnull)request;
		[Export ("updateIdentityPool:")]
		AWSTask<AWSCognitoIdentityIdentityPool> UpdateIdentityPool (AWSCognitoIdentityIdentityPool request);

		// -(void)updateIdentityPool:(AWSCognitoIdentityIdentityPool * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSCognitoIdentityIdentityPool * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateIdentityPool:completionHandler:")]
		void UpdateIdentityPool (AWSCognitoIdentityIdentityPool request, [NullAllowed] Action<AWSCognitoIdentityIdentityPool, NSError> completionHandler);
	}
}
