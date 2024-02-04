using UnityEngine;

/// <summary> Basic component to setup item animation overrider. Including Modkit. </summary>
public class ItemAnimationData : TrackableBehavior
{
    [Tooltip("Custom animation set for animation states. Override this to get custom animation and behaviours with this item." +
             " If this is used on tpv tool - avatar animator will be used, and hands animator for fpv tool prefab")]
    public CustomAnimsetOverride CustomAnimset; // Set of overriden animation for general actions. Allows to reuse 1 animator for all tools/items
}
