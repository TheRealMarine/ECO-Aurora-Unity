using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class EcoColors : BehaviourSingleton<EcoColors>
{
    public Color Powered;
    public Color Unpowered;
    public Color PoweredOff;
    public Material GrayScaleMaterial;
}
