using UnityEngine;
using System.Collections;

[ExecuteAlways]
public class ItemNameDisplayer : TrackableBehavior
{
	void Update()
    {
        if(this.GetComponent<TMPro.TextMeshProUGUI>().text != this.transform.parent.gameObject.name)
            this.GetComponent<TMPro.TextMeshProUGUI>().text = this.transform.parent.gameObject.name;
	}
}
