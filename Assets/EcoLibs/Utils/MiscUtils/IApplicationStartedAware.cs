namespace EcoEngine.Runtime
{
    /// <summary> Interface for services which aware about <see cref="GameApplicationLifetime.ApplicationStarted"/> event. </summary>
    public interface IApplicationStartedAware
    {
        /// <summary> Callback which is called when application started. </summary>
        void OnApplicationStarted();
    }
}