using UnityEngine;

public class OverrideCenterOfMass : TrackableBehavior 
{
    public Transform CenterOfMass;

    private void Awake()
    {
        this.GetComponent<Rigidbody>().centerOfMass = this.CenterOfMass.position;
    }
}
