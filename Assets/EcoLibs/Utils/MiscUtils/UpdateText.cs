﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateText : TrackableBehavior
{
    public string format = "{0:0.00}";
    public TMPro.TextMeshProUGUI text;

    public bool valueIsPercent = false;
    public float scalar = 1.0f;

    public void UpdateFromFloat(float value)
    {
        value *= scalar;
        if (valueIsPercent)
            value *= 100.0f;

        text.text = string.Format(format, value);
    }

    public void UpdateFromInt(int value)
    {
        value = (int)(value * scalar);
        if (valueIsPercent)
            value = (int)(value * 100.0f);

        text.text = string.Format(format, value);
    }
}
