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
    //�ȉ��͊e�p�����[�^���擾�������Ƃ��Ɏg��
    public int Id => id;
    public string Name => name;
    public  Sprite�@Icon => icon;
}
