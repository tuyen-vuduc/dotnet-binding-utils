using Android.Content;
using Android.OS;

namespace Com.Tsl.Rfid.AsciiProtocolQs;

public class ModelException : Exception
{
    public ModelException(string? message) : base(message)
    {
    }
}

public class XBroadcastReceiver : BroadcastReceiver
{
    private Action<Context, Intent> onReceive;

    public XBroadcastReceiver(Action<Context, Intent> onReceive)
    {
        this.onReceive = onReceive;
    }

    public override void OnReceive(Context? context, Intent? intent)
    {
        onReceive?.Invoke(context, intent);
    }
}

public class XAsyncTask : AsyncTask
{
    private readonly Action? preExecute;
    private readonly Action execute;
    private readonly Action? postExecute;

    public XAsyncTask(
        Action execute,
        Action? preExecute = default,
        Action? postExecute = default)
    {
        this.preExecute = preExecute;
        this.execute = execute;
        this.postExecute = postExecute;
    }

    protected override void OnPreExecute()
    {
        preExecute?.Invoke();
    }

    protected override Java.Lang.Object? DoInBackground(params Java.Lang.Object[]? @params)
    {
        execute?.Invoke();
        return null;
    }

    protected override void OnPostExecute(Java.Lang.Object? result)
    {
        postExecute?.Invoke();
    }
}
