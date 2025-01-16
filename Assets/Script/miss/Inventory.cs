using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemSlot[] ItemSlot;
    private bool checkComp;

    public void InventoryCheck(string name, int quantity, Sprite icon)
    {
        checkComp = false;
        for(int i = 0; i < ItemSlot.Length; i++) 
        {
            if (ItemSlot[i].DisplayName == name && ItemSlot[i].isFull == false)
            {
                ItemSlot[i].AddItem(name, quantity, icon);
                checkComp = true;
                break;
            }
        }
        if (checkComp == false) 
        {
            for (int i = 0; i < ItemSlot.Length; i++)
            {
                if (ItemSlot[i].isUsed == false)
                {
                    ItemSlot[i].AddItem(name, quantity, icon);
                    break;
                }
            }
        }
    }
}
