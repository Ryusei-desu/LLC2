using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; // UI�̑���ɂ͂��̖��O��Ԃ��K�v�ł�

public class TitleScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �{�^���I�u�W�F�N�g���擾
        Button startButton = GameObject.Find("start").GetComponent<Button>();
        Button setumeiButton = GameObject.Find("setumei").GetComponent<Button>();

        // �{�^���ɃN���b�N�C�x���g��ǉ�
        startButton.onClick.AddListener(OnStartButton);
        setumeiButton.onClick.AddListener(OnInstructionsButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �J�n�{�^���������ꂽ�Ƃ��ɌĂяo�����֐�
    public void OnStartButton()
    {
        SceneManager.LoadScene("Riki_Scene");
    }

    // �����{�^���������ꂽ�Ƃ��ɌĂяo�����֐�
    public void OnInstructionsButton()
    {
       SceneManager.LoadScene("title_setumei"); 
    }
}
