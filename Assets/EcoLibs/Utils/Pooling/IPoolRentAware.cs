namespace Eco.Client.Pooling
{
    /// <summary>
    /// Can be used with classes (components) which aware about Pool Rent event.
    /// <see cref="OnPoolRent"/> triggered when an instance (previously added to pool) rented.
    /// It won't be triggered if new instance created when pool is empty.
    /// If you need callback when object returned from pool you should implement <see cref="IPoolReturnAware"/> interface.
    /// </summary>
    public interface IPoolRentAware
    {
        /// <summary> Callback for Pool Rent event. </summary>
        void OnPoolRent();
    }
}