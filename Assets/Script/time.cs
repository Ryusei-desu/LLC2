using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class time : MonoBehaviour
{
    public float CountTime = 5;
    public TextMeshProUGUI Timetext;

    private int min;
    private int sec;
    private bool isPaused = false; // 一時停止フラグ

    void Update()
    {
        // エスケープキーが押されたら一時停止を切り替える
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }

        // 一時停止中は処理を停止
        if (!isPaused)
        {
            CountTime -= Time.deltaTime;
            if (CountTime < 0) TogglePause();

            min = (int)(CountTime / 60);
            sec = (int)(CountTime % 60);
            Timetext.text = min.ToString("D2") + ":" + sec.ToString("D2");
        }
    }

    // 一時停止を切り替えるメソッド
    void TogglePause()
    {
        isPaused = !isPaused;

        // タイムスケールを変更
        if (isPaused)
        {
            Time.timeScale = 0; // ゲームを一時停止
        }
        else
        {
            Time.timeScale = 1; // ゲームを再開
        }
    }
}