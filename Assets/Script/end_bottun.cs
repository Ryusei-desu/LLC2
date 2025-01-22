using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // UIの操作にはこの名前空間が必要です

public class end_bottun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ボタンオブジェクトを取得
        Button startButton = GameObject.Find("start").GetComponent<Button>();
        Button backButton = GameObject.Find("back").GetComponent<Button>(); // backボタンのオブジェクトを取得

        // ボタンにクリックイベントを追加
        startButton.onClick.AddListener(OnStartButton);
        backButton.onClick.AddListener(OnBackButton); // backボタンにクリックイベントを追加
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 開始ボタンが押されたときに呼び出される関数
    public void OnStartButton()
    {
        SceneManager.LoadScene("game");
    }

    // バックボタンが押されたときに呼び出される関数
    public void OnBackButton()
    {
        SceneManager.LoadScene("title_main"); // タイトル画面に戻る
    }
}
