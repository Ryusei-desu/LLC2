using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    public GameObject EventMark;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EventMark.SetActive(true);
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