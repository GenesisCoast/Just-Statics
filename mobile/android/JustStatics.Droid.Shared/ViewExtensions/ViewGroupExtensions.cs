using Android.Views;

namespace JustStatics.Droid.Shared.ViewExtensions
{
    public static class ViewGroupExtensions
    {
        public static T GetChildAt<T>(this ViewGroup view, int index) where T : View
        {
            return view.GetChildAt(index) as T;
        }
    }
}