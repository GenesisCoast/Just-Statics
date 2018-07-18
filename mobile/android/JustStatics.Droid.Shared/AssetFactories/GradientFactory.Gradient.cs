using Android.Graphics;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace JustStatics.Droid.Shared.AssetsFactories
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
                List<float> results = new List<float>();

                for (int i = 1; i < Colors.Length; i++)
                {
                    results.Add(((float)i / Colors.Length));
                }

                return results.ToArray();
            }
        }
    }
}