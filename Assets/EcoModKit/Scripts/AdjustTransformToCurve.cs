using UnityEngine;

// this script curves positions on objects to match world curvature.
// most commonly used on lights
public partial class AdjustTransformToCurve : TrackableBehavior
{
    [Tooltip("Maintain local position (useful for lights attached to animated bones)")]
    public bool localPosition;
}
