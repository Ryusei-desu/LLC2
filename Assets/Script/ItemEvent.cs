using System.Diagnostics;
using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    public GameObject EventMark;
    public GameObject Inventory;
    public GameObject ItemObject;

    private bool isPlayerInRange = false;

    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.Space))
        {
            Item giveItem = ItemObject.GetComponent<Item>();

            int id = giveItem.ItemData.Id;
            int num = 1;

            Inventory playerInventory = Inventory.GetComponent<Inventory>();

            playerInventory.AddItem(id, num);
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
