using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace SwipeCTDroid
{
    [Activity(Label = "SwipeCTDroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);



            SetContentView(Resource.Layout.Main);
            ActionBar.Hide(); 
            WebView webView = FindViewById<WebView>(Resource.Id.LocalWebView);
            webView.SetWebViewClient(new WebViewClient()); // stops request going to Web Browser
            webView.Settings.JavaScriptEnabled = true;
            webView.LoadUrl("http://ryanyang.me/SwipeCount/");

        }
    }
}

