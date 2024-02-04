using System;

public static class UnityUtilsExecution
{
    public static void ExecuteIfNotNull<T>(this T obj, Action<T> action)
    {
        if (!obj.UnityCheckIsNull()) action?.Invoke(obj);
    }
}
