namespace Eco.Client.Pooling
{
    /// <summary>
    /// Can be used with classes (components) which aware about Pool Instantiate event (when object requested from pool, but due to lack of pooled instances a new instance was instantiated).
    /// <see cref="OnPoolInstantiate"/> triggered when a new instance created for the pool.
    /// It won't be triggered if an instance rented from pool.
    /// If you need callback when object returned from pool you should implement <see cref="IPoolReturnAware"/> interface.
    /// </summary>
    public interface IPoolInstantiateAware
    {
        void OnPoolInstantiate();
    }
}