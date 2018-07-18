using Android.Support.Design.Internal;
using Com.Ittianyu.Bottomnavigationviewex;
using JustStatics.Droid.Shared.JavaExtensions;

namespace JustStatics.Droid.Shared.ViewExtensions
{
    public static class BottomNavigationViewExExExtensions
    {
        /// <summary>
        /// Removes the shifting mode from the BottomNavigationViewEx.
        /// </summary>
        /// <param name="view">
        /// The BottomNavigationViewEx to remove the shifting mode from.
        /// </param>
        /// <returns>
        /// Returns the BottomNavigationViewEx so that multiple methods can be chained toegther.
        /// </returns>
        public static BottomNavigationViewEx RemoveShiftingMode(this BottomNavigationViewEx view)
        {
            // Get the menu view to access the items
            var menuView = view.GetChildAt(0) as BottomNavigationMenuView;

            // Expose and set the Java field
            menuView.Class.GetDeclaredField("mShiftingMode")
                .SetAccessible(true)
                .SetBooleanPipe(menuView, false)
                .SetAccessible(false)
                .Dispose();

            // Loop through the menu items
            for (int i = 0; i < menuView.ChildCount; i++)
            {
                // Get the menu item
                var item = menuView.GetChildAt(i) as BottomNavigationItemView;

                // Set Shifting mode and then set again to update the view
                item.SetShiftingMode(false);
                item.SetChecked(item.ItemData.IsChecked);
            }

            // Force change update
            menuView.UpdateMenuView();

            return view;
        }
    }
}