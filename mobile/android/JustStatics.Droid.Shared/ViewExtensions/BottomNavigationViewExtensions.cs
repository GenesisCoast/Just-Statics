using Android.App;
using Android.Content.Res;
using Android.Support.Design.Internal;
using Android.Support.Design.Widget;
using JustStatics.Droid.Shared.JavaExtensions;

namespace JustStatics.Droid.Shared.ViewExtensions
{
    public static class BottomNavigationViewExtensions
    {
        /// <summary>
        /// Removes the shifting mode from the BottomNavigationView.
        /// </summary>
        /// <param name="view">
        /// The BottomNavigationView to remove the shifting mode from.
        /// </param>
        /// <returns>
        /// Returns the BottomNavigationView so that multiple methods can be chained toegther.
        /// </returns>
        public static BottomNavigationView RemoveShiftingMode(this BottomNavigationView view)
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

        /// <summary>
        /// Sets the Item icon tint list property from the specified ColorStateList.
        /// </summary>
        /// <param name="view">
        /// The BottomNavigationView to update the property of.
        /// </param>
        /// <param name="colors">
        /// The ColorStateList to assign.
        /// </param>
        /// <returns>
        /// Returns the BottomNavigationView so that multiple methods can be chained together.
        /// </returns>
        public static BottomNavigationView SetItemIconTintList(this BottomNavigationView view, ColorStateList colors)
        {
            view.ItemIconTintList = colors;

            return view;
        }

        /// <summary>
        /// Sets the Item icon tint list property from a resource id.
        /// </summary>
        /// <param name="view">
        /// The BottomNavigationView to update the property of.
        /// </param>
        /// <param name="context">
        /// The activity context to retrieve the ColorStateList resource from.
        /// </param>
        /// <param name="id">
        /// The resource id for the ColorStateList.
        /// </param>
        /// <returns>
        /// Returns the BottomNavigationView so that multiple methods can be chained together.
        /// </returns>
        public static BottomNavigationView SetItemIconTintList(this BottomNavigationView view, Activity context, int id)
        {
            ColorStateList colors = context.GetColorStateList(id);

            SetItemIconTintList(view, colors);

            return view;
        }
    }
}