using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ItemData",menuName="ScriptableObject/Item")]
public class ItemData : ScriptableObject
{
    new public string name;
    public Sprite icon;
}
