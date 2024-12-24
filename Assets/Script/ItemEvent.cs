using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    public GameObject EventMark;
    public GameObject Inventory;
    public GameObject Item;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EventMark.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                Item giveItem = Item.GetComponent<Item>();
                int id = giveItem.ItemData.id;
                int num = 1;
                Inventory playerInvetory = Inventory.GetComponent<Inventory>();
                playerInvetory.AddItem(id, num);
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EventMark.SetActive(false);
        }
    }
}
