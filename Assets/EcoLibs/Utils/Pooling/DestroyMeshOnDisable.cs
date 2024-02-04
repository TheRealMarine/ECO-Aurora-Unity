namespace Eco.Client.Pooling
{
    using UnityEngine;

    /// <summary>
    /// Component which ensures that <see cref="Mesh"/> destroyed when component inactive.
    /// It may be useful if you use custom generated mesh which always set before component enabled and wanna to ensure that it released when component disabled (i.e. when returned to pool).
    /// </summary>
    [RequireComponent(typeof(MeshFilter))]
    [SupportsPooling]
    public class DestroyMeshOnDisable : TrackableBehavior
    {
        void OnDisable()
        {
            var meshFilter = this.GetComponent<MeshFilter>();
            if (meshFilter.sharedMesh != null)
                Destroy(meshFilter.sharedMesh);
            meshFilter.sharedMesh = null;
        }
    }
}
