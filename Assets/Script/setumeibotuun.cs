using UnityEngine;
using UnityEngine.SceneManagement;

public class SetumeiBotuun : MonoBehaviour
{
    void Update()
    {
        // 左Shiftキーまたはスペースキーが押されたらシーンを変更
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.Space))
        {
            LoadScene();
        }
    }

    private void LoadScene()
    {
        Debug.Log("Shift or Space key pressed. Loading Riki_Scene...");
        SceneManager.LoadScene("game");
    }
}
