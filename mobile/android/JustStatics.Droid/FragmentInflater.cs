using Android.App;
using Android.OS;
using Android.Views;

namespace JustStatics.Droid
{
    public class FragmentInflater : Fragment
    {
        public int FragmentId { get; private set; }

        public FragmentInflater(int fragmentId)
        {
            FragmentId = fragmentId;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(FragmentId, container);
        }
    }
}