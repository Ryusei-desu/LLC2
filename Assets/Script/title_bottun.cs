using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; // UIの操作にはこの名前空間が必要です

public class TitleScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ボタンオブジェクトを取得
        Button startButton = GameObject.Find("start").GetComponent<Button>();
        Button setumeiButton = GameObject.Find("setumei").GetComponent<Button>();

        // ボタンにクリックイベントを追加
        startButton.onClick.AddListener(OnStartButton);
        setumeiButton.onClick.AddListener(OnInstructionsButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 開始ボタンが押されたときに呼び出される関数
    public void OnStartButton()
    {
        SceneManager.LoadScene("Riki_Scene");
    }

    // 説明ボタンが押されたときに呼び出される関数
    public void OnInstructionsButton()
    {
       SceneManager.LoadScene("title_setumei"); 
    }
}
