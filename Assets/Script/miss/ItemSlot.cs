using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    public string DisplayName;
    public int Quantity = 0;
    public Sprite Icon;

    public bool isFull = false;
    public bool isUsed = false;

    [SerializeField]
    private Image ItemIcon;
    [SerializeField]
    private TextMeshProUGUI QuantityText;
    [SerializeField]
    int max = 10;



    public void AddItem(string name, int quantity, Sprite icon)
    {
        DisplayName = name;
        Quantity += quantity;
        Icon = icon;

        ItemIcon.sprite = Icon;
        ItemIcon.enabled = true;

        QuantityText.text = Quantity.ToString();
        QuantityText.enabled = true;

        isUsed = true;
        if(Quantity==max)
            isFull = true;
    }
}
