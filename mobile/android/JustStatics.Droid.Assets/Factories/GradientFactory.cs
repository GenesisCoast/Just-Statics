using Android.Graphics;
using Newtonsoft.Json;
using System.IO;

namespace JustStatics.Droid.Assets.Factories
{
    public static partial class GradientFactory
    {
        private const string GRADIENT_DIR = "../Assets/gradients";

        public static LinearGradient Build(GradientAsset asset, float size)
        {
            string fileName = System.IO.Path.Combine(GRADIENT_DIR, asset.ToString() + ".json");

            var gradient = JsonConvert.DeserializeObject<Gradient>(File.ReadAllText(fileName));

            return new LinearGradient(0, 0, 0, 0, gradient.GetColorAsArgb(), gradient.GetColorPositions(), Shader.TileMode.Mirror);
        }
    }
}