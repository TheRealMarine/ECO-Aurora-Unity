namespace EcoEngine.MismatchDetection.Unity
{
    using System.Collections.Generic;
    using System.Linq;
    using global::UnityEngine;

    /// <summary> Composites multiple <see cref="IGameObjectMismatchResolver"/> into single resolver. </summary>
    public class CompositeGameObjectMismatchResolver : IGameObjectMismatchResolver
    {
        public readonly List<IGameObjectMismatchResolver> MismatchResolvers = new List<IGameObjectMismatchResolver>();

        /// <inheritdoc cref="IGameObjectMismatchResolver.ShouldIgnoreExtraGameObject"/>
        public bool ShouldIgnoreExtraGameObject(GameObject gameObject) => this.MismatchResolvers.Any(x => x.ShouldIgnoreExtraGameObject(gameObject));
        /// <inheritdoc cref="IGameObjectMismatchResolver.ShouldIgnoreExtraComponent"/>
        public bool ShouldIgnoreExtraComponent(Component component) => this.MismatchResolvers.Any(x => x.ShouldIgnoreExtraComponent(component));
        /// <inheritdoc cref="IGameObjectMismatchResolver.ShouldIgnoreChildren"/>
        public bool ShouldIgnoreChildren(GameObject gameObject) => this.MismatchResolvers.Any(x => x.ShouldIgnoreChildren(gameObject));
    }
}