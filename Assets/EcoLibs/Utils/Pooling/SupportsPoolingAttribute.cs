namespace Eco.Client.Pooling
{
    using System;

    /// <summary> Marker attribute which marks class as supporting pooling without implementing any pool aware interface like <see cref="IPoolRentAware"/> or <see cref="IPoolReturnAware"/>. </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class SupportsPoolingAttribute : Attribute { }
}
