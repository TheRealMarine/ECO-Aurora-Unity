using UnityEngine;
using System.Collections;
using Eco.Client.Utils;

public class AnimatedUVs : TrackableBehavior
{
    public int materialIndex = 0;
    public Vector2 uvAnimationRate = new Vector2(1.0f, 0.0f);
    public string textureName = "_MainTex";

    Vector2 uvOffset = Vector2.zero;
    void LateUpdate()
    {
        uvOffset += this.uvAnimationRate * Time.deltaTime;
        if (this.GetComponent<Renderer>().enabled)
        {
            this.GetComponent<Renderer>().materials[materialIndex].SetTextureOffset(textureName, uvOffset);
        }
    }

}
