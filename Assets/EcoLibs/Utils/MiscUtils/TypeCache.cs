namespace Utils
{
    using System;
    using System.Collections.Generic;

    public static class TypeCache
    {
        private static readonly Dictionary<Type, string> typeNames = new Dictionary<Type, string>();


        /// <summary> Returns cached type name (avoiding memory allocations). </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetCachedName(this Type type) => typeNames.TryGetValue(type, out var name) ? name : (typeNames[type] = type.Name);
    }
}