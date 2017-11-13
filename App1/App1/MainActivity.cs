using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            MobileCenter.Start("e3f168f1-6102-4c5d-8c22-ac6ef651138a",
                   typeof(Analytics), typeof(Crashes));
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

