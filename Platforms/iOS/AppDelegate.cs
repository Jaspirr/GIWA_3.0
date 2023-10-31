using Foundation;
using Microsoft.Maui;
using UIKit;
using Xamarin.Essentials;

namespace YourNamespace
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate<Startup>
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Platform.Init();

            // Resten av din kod...

            return base.FinishedLaunching(app, options);
        }

        public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
        {
            return Platform.OpenUrl(app, url, options);
        }

        public override void OnActivated(UIApplication uiApplication)
        {
            base.OnActivated(uiApplication);
            Platform.OnActivated();
        }
    }
}
