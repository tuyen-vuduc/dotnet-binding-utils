using System;
using Xamarin.Build.Download;

namespace Xamarin.Build.Download;

public class DownloadUtils
{
    public static Stream? ObtainExclusiveFileLock(string file, CancellationToken cancelToken, TimeSpan timeout, ILogger? log = null)
    {
        var linkedCancelTokenSource = CancellationTokenSource.CreateLinkedTokenSource(
            cancelToken,
            new CancellationTokenSource(timeout).Token);

        while (!linkedCancelTokenSource.IsCancellationRequested)
        {
            try
            {
                var lockStream = File.Open(file, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                return lockStream;
            }
            catch (Exception ex) when (ex is UnauthorizedAccessException || ex is IOException)
            {
                Thread.Sleep(100);
            }
            catch (Exception ex)
            {
                log?.LogErrorFromException(ex);
            }
        }

        return null;
    }
}

