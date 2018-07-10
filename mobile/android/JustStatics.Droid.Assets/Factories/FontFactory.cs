using Android.Content.Res;
using Android.Graphics;

namespace JustStatics.Droid.Assets.Factories
{
    public static class FontFactory
    {
        private const string FONT_DIR = "fonts/";

        public static Typeface Build(FontAsset asset, AssetManager manager)
        {
            string fileName = System.IO.Path.Combine(FONT_DIR, asset.ToString() + ".ttf");

            return Typeface.CreateFromAsset(manager, fileName);
        }
    }
}