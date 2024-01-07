namespace Zeytinbey.DataTypes;

public static class BoolExtensions
{
	public static string ToString(this bool value, string trueValue, string falseValue)
	{
		return value ? trueValue : falseValue;
	}
}
