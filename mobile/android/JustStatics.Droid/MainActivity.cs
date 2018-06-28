using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Widget;
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

            // Set the toolbar to the element in the layout
            SetSupportActionBar(FindViewById<ToolbarV7>(R.Id.top_toolbar));

            // Set the custom typeface of the textview
            FindViewById<TextView>(R.Id.app_name).SetCustomTypeface(Assets, "fonts/Harlow Solid Italic.ttf");

            // Set the bottom navigation menu
            FindViewById<BottomNavigationView>(R.Id.bottom_navigation).InflateMenu(R.Menu.navigation);
        }
    }
}