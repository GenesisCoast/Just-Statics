using Android.Content.Res;
using Android.Graphics;

namespace JustStatics.Droid.Assets.Factories
{
    public static class FontFactory
    {
        private const string FILE_EXTENSION = ".ttf";
        private const string FONT_DIR = "fonts/";

        public static Typeface Build(FontAsset asset, AssetManager manager)
        {
            string filePath = System.IO.Path.Combine(FONT_DIR, asset.ToString() + FILE_EXTENSION);

            return Typeface.CreateFromAsset(manager, filePath);
        }
    }
}