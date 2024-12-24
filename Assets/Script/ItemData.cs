using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ItemData",menuName="ScriptableObject/Item")]
public class ItemData : ScriptableObject
{
    [SerializeField]
    private int id;
    [SerializeField]
    new private string name;
    [SerializeField]
    private Sprite icon;
    //以下は各パラメータを取得したいときに使う
    public int Id => id;
    public string Name => name;
    public  Sprite　Icon => icon;
}
