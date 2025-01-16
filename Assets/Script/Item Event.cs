using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMakeEvent : MonoBehaviour
{
    public GameObject EventMark;
    [SerializeField]
    public GameObject Inventory;
    public GameObject ItemObject;
    private bool isPlayerInRange = false;

    private void Update()
    {
        if (isPlayerInRange == true && Input.GetKeyDown(KeyCode.Space))
        {
            Item giveItem = ItemObject.GetComponent<Item>();

            string name = giveItem.ItemData.Name;
            Sprite icon = giveItem.ItemData.Icon;

            SpriteRenderer playerInventory = Inventory.GetComponent<SpriteRenderer>();

            if (playerInventory.sprite ==  null)
            {
                playerInventory.sprite = icon;
                Inventory.tag = name;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            EventMark.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            EventMark.SetActive(false);
        }
    }
}
