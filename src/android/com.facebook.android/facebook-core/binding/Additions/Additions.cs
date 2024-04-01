namespace Com.Facebook
{
    partial class GraphRequestAsyncTask
    {
        protected override unsafe global::Java.Lang.Object DoInBackground(params global::Java.Lang.Object[] @params)
        {
            return new global::Android.Runtime.JavaList(DoInBackground());
        }
    }

    partial class GraphRequestBatch
    {
        public override unsafe global::Java.Lang.Object Get(int index) => GetGraphRequest(index);
    }
}

namespace Com.Facebook.Appevents.Internal { 
    using System.Linq;

    partial class FileDownloadTask {
        protected override unsafe global::Java.Lang.Object DoInBackground(params global::Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Select(x => x.ToString()).ToArray());
        }
    }
}