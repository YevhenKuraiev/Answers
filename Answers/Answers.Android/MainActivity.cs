using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace Answers.Droid
{
    [Activity(Label = "XAI 2018", ScreenOrientation = ScreenOrientation.Portrait, Icon = "@mipmap/icon",
        Theme = "@style/splashscreen", MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.Window.RequestFeature(WindowFeatures.NoTitle);
            base.SetTheme(Resource.Style.MainTheme);
            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

