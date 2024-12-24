using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<int> idList = new List<int>();
    public List<int> quantityList = new List<int>();

    public void AddItem(int id, int quantity)
    {
        int checkIndex = idList.IndexOf(id);
        if (checkIndex == -1)
        {
            idList.Add(id);
            quantityList.Add(quantity);
        }
        else
        {
            quantityList[checkIndex] += quantity;
        }
    }
}
