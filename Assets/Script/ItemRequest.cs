using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using TMPro;


public class ItemRequest : MonoBehaviour
{
    public GameObject[] RequestList;
    public GameObject want;
    public GameObject Inventory;
    public GameObject ScoreBoard;

    private SpriteRenderer verywant;
    private SpriteRenderer playerInventory;
    private TextMeshProUGUI scoreboard;

    private bool isPlayerInRange = false;
    private int Score;
    private int ScorePoint;

    void Start()
    {
        verywant = want.GetComponent<SpriteRenderer>();
        playerInventory = Inventory.GetComponent<SpriteRenderer>();
        scoreboard = ScoreBoard.GetComponent<TextMeshProUGUI> ();
        scoreboard.text = Score.ToString();
        RandomRequest();
    }
    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange == true && Input.GetKeyDown(KeyCode.Space)&& playerInventory.tag == verywant.tag)
        {
            verywant.sprite = null;
            playerInventory.sprite = null;
            verywant.tag = "Untagged";
            playerInventory.tag = "Untagged";
            Score += ScorePoint;
            scoreboard.text = Score.ToString();
            RandomRequest();
        }
    }
    void RandomRequest()
    {
        int randomIndex = Random.Range(0, RequestList.Length);
        Item item = RequestList[randomIndex].GetComponent<Item>();
        string name = item.ItemData.Name;
        Sprite icon = item.ItemData.Icon;
        ScorePoint = item.ItemData.Score;
        verywant.sprite = icon;
        want.tag = name;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }
}
