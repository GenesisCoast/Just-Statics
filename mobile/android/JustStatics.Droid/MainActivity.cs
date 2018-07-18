using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Widget;
using Com.Ittianyu.Bottomnavigationviewex;
using JustStatics.Droid.Shared.AssetsFactories;
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
                .SetForegroundGradient(Assets, GradientAsset.grad_mean_fruit);

            int[][] states = new int[][] {
                new int[] { Android.Resource.Attribute.StateEnabled }, // enabled
            };

            int[] colors = new int[] {
                Android.Resource.Color.HoloRedDark
            };

            var test = FindViewById<BottomNavigationViewEx>(R.Id.bnve_bigger_icon);
            test.EnableShiftingMode(false);
            test.EnableItemShiftingMode(false);
            test.SetIconSizeAt(2, 48, 48);
            test.EnableAnimation(false);
            test.SetIconMarginTop(2, 0);
            //test.SetItemBackground(2, Android.Resource.Color.HoloRedDark);
            //var result = test.GetBottomNavigationItemView(2).GetChildAt(0) as AppCompatImageView;

            var result = test.GetBottomNavigationItemView(2).GetChildAt<AppCompatImageView>(0);
            result.Background = GetDrawable(R.Drawable.bg_gradient_soft);

            // Set the bottom navigation menu
            //FindViewById<BottomNavigationView>(R.Id.bottom_navigation)
            //    .SetItemIconTintList(this, R.Color.bottom_navigation)
            //    .RemoveShiftingMode();
        }
    }
}