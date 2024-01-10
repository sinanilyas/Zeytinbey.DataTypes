namespace Zeytinbey.DataTypes;

public static class EnumHelper
{
	public static IEnumerable<T> GetValues<T>() where T : struct
	{
		return Enum.GetValues(typeof(T)).Cast<T>();
	}

	public static T? FindByValue<T>(string? value) where T : struct
	{
		if (Enum.TryParse(value, out T result)) return result;

		return null;
	}
}