using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ItemData",menuName="ScriptableObject/Item")]
public class ItemData : ScriptableObject
{
    [SerializeField]
    new private string name;
    [SerializeField]
    private Sprite icon;
    //以下は各パラメータを取得したいときに使う
    public string Name => name;
    public  Sprite　Icon => icon;
}
