using System.Text.RegularExpressions;
using Android.Util;
using Com.UK.Tsl.Rfid.Asciiprotocol.Device;

namespace Com.Tsl.Rfid.DeviceList;

public class ReaderMedia
{
    /**
     * Get a list view image Id for the given Reader
     * @return
     */
    public static int listImageFor(Reader reader)
    {
        string model = modelFor(reader);

        if (model == null) return Resource.Drawable.list_unknown_device;

        if (model == "3166") return Resource.Drawable.list_3166;
        if (model == ("3128")) return Resource.Drawable.list_3128;

        if (model == ("3066")) return Resource.Drawable.list_3066;

        if (model == ("1128")) return Resource.Drawable.list_1128_s1;
        if (model == ("1153")) return Resource.Drawable.list_1153;
        if (model == ("1166")) return Resource.Drawable.list_1166;
        if (model == ("2128")) return Resource.Drawable.list_2128_s1;
        if (model == ("IH21")) return Resource.Drawable.list_ih21_a1;

        if (model == ("2128P")) return Resource.Drawable.list_2128p;
        if (model == ("2128L")) return Resource.Drawable.list_2128l;
        if (model == ("2166")) return Resource.Drawable.list_2166;
        if (model == ("2173")) return Resource.Drawable.list_2173;
        if (model == ("IH21L")) return Resource.Drawable.list_ih21l;

        return Resource.Drawable.list_unknown_device;
    }

    public static int descriptionFor(Reader reader)
    {
        string model = modelFor(reader);

        if (model == null) return Resource.String.description_unknown_device;

        if (model == ("3166")) return Resource.String.description_3166;
        if (model == ("3128")) return Resource.String.description_3128;

        if (model == ("3066")) return Resource.String.description_3066;

        if (model == ("2128P")) return Resource.String.description_2128p;
        if (model == ("2128L")) return Resource.String.description_2128l;
        if (model == ("IH21L")) return Resource.String.description_ih21l;
        if (model == ("1128")) return Resource.String.description_1128;
        if (model == ("1153")) return Resource.String.description_1153;
        if (model == ("1119")) return Resource.String.description_1119;
        if (model == ("1126")) return Resource.String.description_1126;
        if (model == ("2166")) return Resource.String.description_2166;
        if (model == ("1166")) return Resource.String.description_1166;
        if (model == ("2128")) return Resource.String.description_2128;
        if (model == ("IH21")) return Resource.String.description_ih21;
        if (model == ("2173")) return Resource.String.description_2173;


        return Resource.String.description_unknown_device;
    }



    /**
     * Return the
     * @param reader
     * @return
     */
    private static string modelFor(Reader reader)
    {
        string serialNumber = reader.SerialNumber;

        if (D) Log.Debug(TAG, string.Format("SN: {0}", serialNumber));

        string model = null;

        if (serialNumber == null)
        {
            // Use the display name
            string displayName = reader.DisplayName;
            if (D) Log.Debug(TAG, string.Format("DN: {0}", displayName));

            foreach (string regex in sDisplayNamePatterns)
            {
                Regex pattern = new Regex(regex);
                var matcher = pattern.Match(displayName);
                if (matcher.Success)
                {
                    model = matcher.Groups[MODEL_GROUP].Value;
                    if (model != null) break;
                }
            }
        }
        else
        {
            // Try all
            foreach (string regex in sSerialNumberPatterns)
            {
                Regex pattern = new Regex(regex);
                var matcher = pattern.Match(serialNumber);
                if (matcher.Success)
                {
                    model = matcher.Groups[MODEL_GROUP].Value;
                    if (model != null) break;
                }
            }
        }
        return model;
    }

    //
    // Warning
    //
    // Cannot use named capture groups in Android API < 26
    // so patterns must ALWAYS have the same group offsets
    // capture groups are:
    readonly static int MODEL_GROUP = 1;

    private static string[] sSerialNumberPatterns =
            {
                    //"(?<model>(\\d{2}|IH)\\d{2})-.+"
                    //"((\\d{2}|IH)\\d{2})-.+",
                    "((\\d{2}|IH)\\d{2}(L|P)*)-.+",

                    };

    private static string[] sDisplayNamePatterns =
            {
        //".+-(?<model>(\\d{2}|IH)\\d{2})"
        //".+-((\\d{2}|IH)\\d{2})",
                    ".+-((\\d{2}|IH)\\d{2}(L|P)*)",
                    };


    private static readonly string TAG = "ReaderMedia";
    private static readonly bool D =
#if DEBUG
    true
#else
        false
#endif
    ;
}