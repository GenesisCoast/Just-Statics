using Android.Graphics;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace JustStatics.Droid.Assets.Factories
{
    public static partial class GradientFactory
    {
        private class Gradient
        {
            [JsonProperty(PropertyName = "angle")]
            public int Angle { get; set; }

            [JsonProperty(PropertyName = "colors")]
            public string[] Colors { get; set; }

            public int[] GetColorAsArgb()
            {
                return Colors.Select(c => Color.ParseColor(c).ToArgb()).ToArray();
            }

            public float[] GetColorPositions()
            {
                return Colors.Select(c => (float)(Array.IndexOf(Colors, c) / (Colors.Count()))).ToArray();
            }
        }
    }
}