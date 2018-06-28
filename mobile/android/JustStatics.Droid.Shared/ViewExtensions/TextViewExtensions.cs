using Android.Content.Res;
using Android.Graphics;
using Android.Widget;

namespace JustStatics.Droid.Shared.ViewExtensions
{
    public static class TextViewExtensions
    {
        public static void SetCustomTypeface(this TextView view, AssetManager mgr, string path, TypefaceStyle style = TypefaceStyle.Normal)
        {
            Typeface font = Typeface.CreateFromAsset(mgr, path);

            view.SetTypeface(font, TypefaceStyle.Normal);
        }
    }
}