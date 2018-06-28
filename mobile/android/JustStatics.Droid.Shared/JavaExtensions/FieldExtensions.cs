using Java.Lang.Reflect;

namespace JustStatics.Droid.Shared.JavaExtensions
{
    public static class FieldExtensions
    {
        /// <summary>
        /// Wraps the setting of the accessible property into a chainable method.
        /// </summary>
        /// <param name="field">
        /// The field to change the accessible property of.
        /// </param>
        /// <param name="accessible">
        /// The new value of the accessible property.
        /// </param>
        /// <returns>
        /// Returns the field so that multiple statements can be chained together.
        /// </returns>
        public static Field SetAccessible(this Field field, bool accessible)
        {
            field.Accessible = accessible;

            return field;
        }

        /// <summary>
        /// Sets the value of the field in the specified object to the boolean value.
        /// </summary>
        /// <param name="field">
        /// The field to set the specified objects boolean value of.
        /// </param>
        /// <param name="obj">
        /// The object to set the field value of.
        /// </param>
        /// <param name="z">
        /// The value to be assigned to the field.
        /// </param>
        /// <returns>
        /// Returns the field so that multiple statements can be chained together.
        /// </returns>
        public static Field SetBooleanPipe(this Field field, Java.Lang.Object obj, bool z)
        {
            field.SetBoolean(obj, z);

            return field;
        }
    }
}