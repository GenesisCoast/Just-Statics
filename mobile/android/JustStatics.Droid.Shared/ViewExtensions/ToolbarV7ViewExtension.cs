using Android.Support.V7.App;
using ToolbarV7 = Android.Support.V7.Widget.Toolbar;

namespace JustStatics.Droid.Shared.ViewExtensions
{
    public static class ToolbarV7ViewExtension
    {
        public static void SetAsSupportActionBar(this ToolbarV7 view, AppCompatActivity context)
        {
            context.SetSupportActionBar(view);
        }

        public static ToolbarV7 SetEmptyTitle(this ToolbarV7 view)
        {
            view.Title = "";

            return view;
        }
    }
}