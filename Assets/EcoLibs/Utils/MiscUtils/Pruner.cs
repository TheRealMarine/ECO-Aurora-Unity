using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruner : TrackableBehavior
{
    public Camera cameraComponent;
    public float pruneMin = .05f;
}
