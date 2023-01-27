namespace Zeytinbey.DataTypes.Extensions
{
     public static class StringExtensions
     {
        public static short ToInt16OrDefault(this string value, short defaultValue = default)
        {
            return short.TryParse(value, out var result) ? result : defaultValue;
        }

        public static int ToInt32OrDefault(this string value, int defaultValue = default)
        {
            return int.TryParse(value, out var result) ? result : defaultValue;
        }

        public static long ToInt64OrDefault(this string value, long defaultValue = default)
        {
            return long.TryParse(value, out var result) ? result : defaultValue;
        }

        public static ushort ToUInt16OrDefault(this string value, ushort defaultValue = default)
        {
            return ushort.TryParse(value, out var result) ? result : defaultValue;
        }

        public static uint ToUInt32OrDefault(this string value, uint defaultValue = default)
        {
            return uint.TryParse(value, out var result) ? result : defaultValue;
        }

        public static ulong ToUInt64OrDefault(this string value, ulong defaultValue = default)
        {
            return ulong.TryParse(value, out var result) ? result : defaultValue;
        }

        public static byte ToByteOrDefault(this string value, byte defaultValue = default)
        {
            return byte.TryParse(value, out var result) ? result : defaultValue;
        }

        public static sbyte ToSByteOrDefault(this string value, sbyte defaultValue = default)
        {
            return sbyte.TryParse(value, out var result) ? result : defaultValue;
        }

        public static float ToSingleOrDefault(this string value, float defaultValue = default)
        {
            return float.TryParse(value, out var result) ? result : defaultValue;
        }

        public static double ToDoubleOrDefault(this string value, double defaultValue = default)
        {
            return double.TryParse(value, out var result) ? result : defaultValue;
        }

        public static decimal ToDecimalOrDefault(this string value, decimal defaultValue = default)
        {
            return decimal.TryParse(value, out var result) ? result : defaultValue;
        }

        public static bool ToBooleanOrDefault(this string value, bool defaultValue = default)
        {
            return bool.TryParse(value, out var result) ? result : defaultValue;
        }

        public static char ToCharOrDefault(this string value, char defaultValue = default)
        {
            return char.TryParse(value, out var result) ? result : defaultValue;
        }

        public static DateTime ToDateTimeOrDefault(this string value, DateTime defaultValue = default)
        {
            return DateTime.TryParse(value, out var result) ? result : defaultValue;
        }
    }
}
