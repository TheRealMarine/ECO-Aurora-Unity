namespace Utils
{
    using UnityEngine;

    /// <summary> Class which holds reusable co-routine waiters like WaitForFixedUpdate, WaitForEndOfFrame avoiding new instance creation every time when yield. </summary>
    public static class CoroutineWaiters
    {
        public static readonly WaitForFixedUpdate FixedUpdate     = new();
        public static readonly WaitForEndOfFrame  EndOfFrame      = new();
        public static readonly WaitForSeconds     OneSecond       = new(1f);
        public static readonly WaitForSeconds     QuarterOfSecond = new(0.25f);
    }
}
