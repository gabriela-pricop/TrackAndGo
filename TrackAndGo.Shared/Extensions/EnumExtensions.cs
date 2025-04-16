using System.ComponentModel;
using System.Reflection;
using TrackAndGo.Shared.Attributes;

namespace TrackAndGo.Shared.Extensions
{
    public static class EnumExtensions
    {
        public static int GetGuid<TEnum>(this TEnum value)
        {
            return value!.GetType().GetField(value.ToString()!)!.GetCustomAttribute<IntAttribute>()!.Value;
        }

        public static string GetDescription<TEnum>(this TEnum value)
        {
            return value!.GetType().GetField(value.ToString()!)!.GetCustomAttribute<DescriptionAttribute>()!.Description;
        }
    }
}
