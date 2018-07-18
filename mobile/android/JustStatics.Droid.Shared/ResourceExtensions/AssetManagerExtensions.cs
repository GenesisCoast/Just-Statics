using Android.Content.Res;
using Newtonsoft.Json;
using System.IO;

namespace JustStatics.Droid.Shared.ResourceExtensions
{
    public static class AssetManagerExtensions
    {
        public static string OpenAndRead(this AssetManager manager, string path)
        {
            using (var reader = new StreamReader(manager.Open(path)))
            {
                return reader.ReadToEnd();
            }
        }

        public static T OpenAndReadJson<T>(this AssetManager manager, string path)
        {
            return JsonConvert.DeserializeObject<T>(OpenAndRead(manager, path));
        }
    }
}