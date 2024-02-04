using UnityEngine;

public class GIOnly : TrackableBehavior
{
    public void Start()
    {
        gameObject.layer = LayerMask.NameToLayer("OnlyGI");
    }
}
