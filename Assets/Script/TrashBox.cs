using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBox : MonoBehaviour
{
    public GameObject EventMark;
    [SerializeField]
    public GameObject Inventory;
    private bool isPlayerInRange = false;

    private void Update()
    {
        if (isPlayerInRange == true && Input.GetKeyDown(KeyCode.Space))
        {
            SpriteRenderer playerInventory = Inventory.GetComponent<SpriteRenderer>();

            if (playerInventory.sprite != null)
            {
                playerInventory.sprite = null;
                Inventory.tag = "Untagged";
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
