using Android.App;
using Android.Support.V7.App;

namespace Answers.Droid
{
    [Activity(Label = "Bardik", Icon = "@drawable/splashscreen", Theme = "@style/splashscreen", MainLauncher = false, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(typeof(MainActivity));
        }
    }
}