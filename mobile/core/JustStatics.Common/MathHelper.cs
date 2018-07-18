using System;

namespace JustStatics
{
    public static class MathHelper
    {
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
    }
}