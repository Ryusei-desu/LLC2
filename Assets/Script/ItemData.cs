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
    //�ȉ��͊e�p�����[�^���擾�������Ƃ��Ɏg��
    public string Name => name;
    public  Sprite�@Icon => icon;
}
