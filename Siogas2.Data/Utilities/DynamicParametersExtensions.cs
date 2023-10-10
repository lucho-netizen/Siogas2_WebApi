using Dapper;
using System;
using System.Collections;
using System.Linq;

namespace Siogas2.Data.Utilities
{
    internal static class DynamicParametersExtensions
    {
        private static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName)?.GetValue(src, null);
        }

        public static DynamicParameters GetDynamicParameters<T>(this T incoming)
        {
            return GetDynamicParameters(incoming, true, new string[] { });
        }

        public static DynamicParameters GetDynamicParameters<T>(this T incoming, bool excludeList = true, params string[] excludedProperties)
        {
            var dynamicParameters = new DynamicParameters();

            var excludedProps = excludedProperties ?? Enumerable.Empty<string>();

            foreach (var property in incoming.GetType().GetProperties())
            {
                if (!property.CanWrite || excludedProps.Any(ep => property.Name == ep)) continue;

                object value = GetPropValue(incoming, property.Name);

                if (excludeList == true && value is IList) continue;

                if (value is Enum) value = (int)value;

                dynamicParameters.Add(property.Name, value);
            }

            return dynamicParameters;
        }
    }
}
