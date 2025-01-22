using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItmeMake2 : MonoBehaviour
{
    public GameObject EventMark;
    [SerializeField]
    public GameObject Inventory;
    public GameObject GiveItem;
    public GameObject NeedItem;
    public float CountTime = 5;
    private float count;

    private bool isPlayerInRange = false;
    private bool maked = false;
    private bool timer = false;

    void Update()
    {
        if (isPlayerInRange == true && Input.GetKeyDown(KeyCode.Space) && timer == false || isPlayerInRange == true && Input.GetKeyDown(KeyCode.Space) && maked ==true)
        {
            SpriteRenderer playerInventory = Inventory.GetComponent<SpriteRenderer>();

            if (Inventory.tag == "Untagged" && maked == true)
            {
                Item giveitem = GiveItem.GetComponent<Item>();
                string name = giveitem.ItemData.Name;
                Sprite icon = giveitem.ItemData.Icon;
                playerInventory.sprite = icon;
                Inventory.tag = name;
                maked = false;
                timer = false;
            }
            Item needitem = NeedItem.GetComponent<Item>();
            string needname = needitem.ItemData.Name;
            if (Inventory.tag == needname && maked==false)
            {
                playerInventory.sprite = null;
                Inventory.tag = "Untagged";
                timer = true;
                count = CountTime;
            }
        }
        if (timer == true)
        {
            count -= Time.deltaTime;
            if (count <= 0)
            {
                EventMark.SetActive(true);
                maked = true;
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
