using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Zeytinbey.DataTypes;

public static class EnumExtensions
{
    /// <summary>
    /// Extension method to retrieve the 'Name' value specified in the Display DataAnnotation for the given enum value.
    /// </summary>
    /// <param name="enumValue">The enum value for which to retrieve the 'Name' value.</param>
    /// <returns>The 'Name' value specified in the Display DataAnnotation, or null if there is no Display DataAnnotation.</returns>
    public static string? DisplayName(this Enum enumValue)
    {
        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()?
            .GetName();
    }
}