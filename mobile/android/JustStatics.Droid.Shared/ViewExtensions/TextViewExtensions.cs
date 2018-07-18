using Android.Content.Res;
using Android.Graphics;
using Android.Widget;
using JustStatics.Droid.Shared.AssetsFactories;

namespace JustStatics.Droid.Shared.ViewExtensions
{
    public static class TextViewExtensions
    {
        public static TextView SetCustomTypeface(this TextView view, AssetManager mgr, FontAsset font)
        {
            view.SetTypeface(FontFactory.Build(font, mgr), TypefaceStyle.Normal);

            return view;
        }

        public static TextView SetForegroundGradient(this TextView view, AssetManager mgr, GradientAsset gradient)
        {
            view.Paint.SetShader(GradientFactory.Build(mgr, gradient, view.TextSize));

            return view;
        }
    }
}