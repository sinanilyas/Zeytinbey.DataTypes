namespace Zeytinbey.DataTypes;

public static class ConvertOrDefault
{
    public static short ToInt16(object? value, short defaultValue = default)
    {
        try
        {
            return Convert.ToInt16(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static int ToInt32(object? value, int defaultValue = default)
    {
        try
        {
            return Convert.ToInt32(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static long ToInt64(object? value, long defaultValue = default)
    {
        try
        {
            return Convert.ToInt64(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static ushort ToUInt16(object? value, ushort defaultValue = default)
    {
        try
        {
            return Convert.ToUInt16(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static uint ToUInt32(object? value, uint defaultValue = default)
    {
        try
        {
            return Convert.ToUInt32(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static ulong ToUInt64(object? value, ulong defaultValue = default)
    {
        try
        {
            return Convert.ToUInt64(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static byte ToByte(object? value, byte defaultValue = default)
    {
        try
        {
            return Convert.ToByte(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static sbyte ToSByte(object? value, sbyte defaultValue = default)
    {
        try
        {
            return Convert.ToSByte(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static float ToSingle(object? value, float defaultValue = default)
    {
        try
        {
            return Convert.ToSingle(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static double ToDouble(object? value, double defaultValue = default)
    {
        try
        {
            return Convert.ToDouble(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static decimal ToDecimal(object? value, decimal defaultValue = default)
    {
        try
        {
            return Convert.ToDecimal(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static bool ToBoolean(object? value, bool defaultValue = default)
    {
        try
        {
            return Convert.ToBoolean(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static char ToChar(object? value, char defaultValue = default)
    {
        try
        {
            return Convert.ToChar(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static DateTime ToDateTime(object? value, DateTime defaultValue = default)
    {
        try
        {
            return Convert.ToDateTime(value);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }
}