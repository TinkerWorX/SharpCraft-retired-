using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft
{
    static class TypeExtensions
    {
        public static Boolean Implements<T>(this Type type)
        {
            return type.GetInterfaces().Any(o => o.ToString().Contains(typeof(T).FullName));
        }

        public static IEnumerable<String> GetRequires(this Type type)
        {
            foreach (var attribute in type.GetCustomAttributesData())
            {
                if (attribute.ToString().Contains(typeof(RequiresAttribute).FullName))
                    yield return attribute.ConstructorArguments[0].Value.ToString();
            }
        }
    }
}
