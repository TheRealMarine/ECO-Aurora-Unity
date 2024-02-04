namespace Eco.Utils
{
    using System.Collections.Generic;

    public static class ListExtensions
    {
        /// <summary>Ensures that capacity of list is greater or equal to passed capacity.</summary>
        public static void EnsureCapacity<T>(this List<T> list, int capacity)
        {
            if (list.Capacity < capacity) list.Capacity = capacity;
        }
    }
}
