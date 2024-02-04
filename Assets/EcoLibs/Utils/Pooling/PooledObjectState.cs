namespace Eco.Client.Pooling
{
    /// <summary> Enum for <see cref="PooledObject"/> states. </summary>
    public enum PooledObjectState
    {
        New,     // newly instantiated object (if pool was empty)
        Rented,  // object was rented from pool
        Returned,// object was returned to pool (will be set even if object wasn't previously in pool - has New state) and currently available from pool. If object used outside of pool it may cause an error and means that object reference wasn't released when object was returned to pool
        Prefab   // object which used as prefab for pooled object instances (can't be rented or returned)
    }
}