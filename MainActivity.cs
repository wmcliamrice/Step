using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using GR.Net.Maroulis.Library;
using static Android.Resource;
using Android.Views;

namespace StepSplashScreen
{
    [Activity(Label = "StepSplashScreen", MainLauncher = true, Icon = "@drawable/icon",Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Show Splash Screen
            var config = new EasySplashScreen(this)
                .WithFullScreen()
                .WithTargetActivity(Java.Lang.Class.FromType(typeof(TargetActivity)))
                .WithSplashTimeOut(5000) // 5 sec
                .WithBackgroundColor(Android.Graphics.Color.ParseColor("#ffdfe0"))
                .WithLogo(Resource.Drawable.step_logo);
            //Set Text Color
            //config.HeaderTextView.SetTextColor("#b85250");
            //config.FooterTextView.SetTextColor("#b85250");
            //config.BeforeLogoTextView.SetTextColor("#b85250");

            //Create view
            View view = config.Create();

            //Set Content View 
            SetContentView(view);
        }
    }
}

