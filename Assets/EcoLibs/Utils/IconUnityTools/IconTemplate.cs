using UnityEngine;
using UnityEngine.UI;
using System;

public class IconTemplate : TrackableBehavior
{
    public enum SpriteBakePolicy
    {
        BakeWithBackground,
        BakeForegroundOnly,
        BakeBoth
    }
    public SpriteBakePolicy BakePolicy;

    //TODO can we remove these references? Though we do not want search by name in baking code.
    public GameObject Icon;
    public Image Background;
    public Image Foreground;
    public Image FullImage;
}

