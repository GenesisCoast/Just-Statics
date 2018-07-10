using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using JustStatics.Droid.Assets.Factories;
using JustStatics.Droid.Shared.ViewExtensions;
using R = JustStatics.Droid.Resource;
using ToolbarV7 = Android.Support.V7.Widget.Toolbar;

namespace JustStatics.Droid
{
    [Activity(
        MainLauncher = true,
        Label = "@string/app_name"
    )]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(R.Layout.activity_main);

            // Configure the toolbar
            FindViewById<ToolbarV7>(R.Id.top_toolbar)
                .SetEmptyTitle()
                .SetAsSupportActionBar(this);

            // Set the custom typeface of the textview
            FindViewById<TextView>(R.Id.app_name)
                .SetCustomTypeface(Assets, FontAsset.harlow_solid_italic)
                .SetForegroundGradient(GradientAsset.grad_mean_fruit);

            // Set the bottom navigation menu
            //FindViewById<BottomNavigationView>(R.Id.bottom_navigation)
            //    .SetItemIconTintList(this, R.Color.bottom_navigation)
            //    .RemoveShiftingMode();
        }
    }
}