namespace Zeytinbey.DataTypes;

public static class StringExtensions
{
    #region ToType

    public static short ToInt16(this string value)
    {
        return Convert.ToInt16(value);
    }

    public static int ToInt32(this string value)
    {
        return Convert.ToInt32(value);
    }

    public static long ToInt64(this string value)
    {
        return Convert.ToInt64(value);
    }

    public static ushort ToUInt16(this string value)
    {
        return Convert.ToUInt16(value);
    }

    public static uint ToUInt32(this string value)
    {
        return Convert.ToUInt32(value);
    }

    public static ulong ToUInt64(this string value)
    {
        return Convert.ToUInt64(value);
    }

    public static byte ToByte(this string value)
    {
        return Convert.ToByte(value);
    }

    public static sbyte ToSByte(this string value)
    {
        return Convert.ToSByte(value);
    }

    public static float ToSingle(this string value)
    {
        return Convert.ToSingle(value);
    }

    public static double ToDouble(this string value)
    {
        return Convert.ToDouble(value);
    }

    public static decimal ToDecimal(this string value)
    {
        return Convert.ToDecimal(value);
    }

    public static bool ToBoolean(this string value)
    {
        return Convert.ToBoolean(value);
    }

    public static char ToChar(this string value)
    {
        return Convert.ToChar(value);
    }

    public static DateTime ToDateTime(this string value)
    {
        return Convert.ToDateTime(value);
    }

    #endregion

    #region ToTypeOrDefault

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

    #endregion
}

