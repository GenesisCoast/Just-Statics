﻿using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using JustStatics.Droid.Shared.ResourceExtensions;
using System;
using System.Linq;
using IOPath = System.IO.Path;

namespace JustStatics.Droid.Shared.AssetsFactories
{
    public static partial class GradientFactory
    {
        private const string FILE_EXTENSION = ".json";
        private const string GRADIENT_DIR = "gradients/";

        public static GradientDrawable BuildDrawable(AssetManager manager, GradientAsset asset)
        {
            string filePath = IOPath.Combine(GRADIENT_DIR, asset.ToString() + FILE_EXTENSION);

            var gradient = manager.OpenAndReadJson<Gradient>(filePath);

            //var result = test.GetBottomNavigationItemView(2).GetChildAt<AppCompatImageView>(0);
            //result.Background = GetDrawable(R.Drawable.bg_gradient_soft);

            var shape = new GradientDrawable(GradientDrawable.Orientation.BlTr, gradient.GetColorAsArgb());

            return shape;
        }

        public static LinearGradient BuildGradient(AssetManager manager, GradientAsset asset, double length)
        {
            string filePath = IOPath.Combine(GRADIENT_DIR, asset.ToString() + FILE_EXTENSION);

            var gradient = manager.OpenAndReadJson<Gradient>(filePath);

            //double angleInRadians = MathHelper.ConvertToRadians(gradient.Angle);

            float endX = (float)(Math.Cos(gradient.Angle) * length);
            float endY = (float)(Math.Sin(gradient.Angle) * length);
            int[] colors = gradient.GetColorAsArgb().ToArray();
            //float[] positions = gradient.GetColorPositions().ToArray();

            //return new LinearGradient(0, 0, endX, endY, gradient.GetColorAsArgb(), gradient.GetColorPositions(), Shader.TileMode.Mirror);
            return new LinearGradient(0, 0, endX, endY, Color.ParseColor(gradient.Colors.ToArray()[0]), Color.ParseColor(gradient.Colors.ToArray()[1]), Shader.TileMode.Mirror);
        }
    }
}