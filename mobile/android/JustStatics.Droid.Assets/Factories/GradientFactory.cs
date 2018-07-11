using Android.Content.Res;
using Android.Graphics;
using Newtonsoft.Json;
using System.IO;

namespace JustStatics.Droid.Assets.Factories
{
    public static partial class GradientFactory
    {
        private const string FILE_EXTENSION = ".json";
        private const string GRADIENT_DIR = "gradients/";

        public static LinearGradient Build(AssetManager manager, GradientAsset asset, float size)
        {
            string filePath = System.IO.Path.Combine(GRADIENT_DIR, asset.ToString() + FILE_EXTENSION);

            var gradient = OpenAndReadGradient(manager, filePath);

            return new LinearGradient(0, 0, 0, 0, gradient.GetColorAsArgb(), gradient.GetColorPositions(), Shader.TileMode.Mirror);
        }

        private static Gradient OpenAndReadGradient(AssetManager manager, string path)
        {
            using (var reader = new StreamReader(manager.Open(path)))
            {
                return JsonConvert.DeserializeObject<Gradient>(reader.ReadToEnd());
            }
        }
    }
}