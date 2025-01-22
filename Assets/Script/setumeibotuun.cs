using UnityEngine;
using UnityEngine.SceneManagement;

public class SetumeiBotuun : MonoBehaviour
{
    void Update()
    {
        // ��Shift�L�[�܂��̓X�y�[�X�L�[�������ꂽ��V�[����ύX
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
