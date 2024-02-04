using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public static class UnityGameTools
{
    public static void SortChildrenByName(GameObject[] gameObjects)
	{
		foreach (GameObject obj in gameObjects)
			SortChildrenByName(obj);
	}

	public static void SortChildrenByName(GameObject obj)
	{
		List<Transform> children = new List<Transform>();
		for (int i = obj.transform.childCount - 1; i >= 0; i--)
		{
			Transform child = obj.transform.GetChild(i);
			children.Add(child);
			child.parent = null;
		}
		children.Sort((Transform t1, Transform t2) => { return t1.name.CompareTo(t2.name); });
		foreach (Transform child in children)
			child.parent = obj.transform;
	}
}
