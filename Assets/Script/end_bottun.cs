using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // UI�̑���ɂ͂��̖��O��Ԃ��K�v�ł�

public class end_bottun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �{�^���I�u�W�F�N�g���擾
        Button startButton = GameObject.Find("start").GetComponent<Button>();
        Button backButton = GameObject.Find("back").GetComponent<Button>(); // back�{�^���̃I�u�W�F�N�g���擾

        // �{�^���ɃN���b�N�C�x���g��ǉ�
        startButton.onClick.AddListener(OnStartButton);
        backButton.onClick.AddListener(OnBackButton); // back�{�^���ɃN���b�N�C�x���g��ǉ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �J�n�{�^���������ꂽ�Ƃ��ɌĂяo�����֐�
    public void OnStartButton()
    {
        SceneManager.LoadScene("game");
    }

    // �o�b�N�{�^���������ꂽ�Ƃ��ɌĂяo�����֐�
    public void OnBackButton()
    {
        SceneManager.LoadScene("title_main"); // �^�C�g����ʂɖ߂�
    }
}
