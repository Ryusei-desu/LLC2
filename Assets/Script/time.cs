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
    private bool isPaused = false; // �ꎞ��~�t���O

    void Update()
    {
        // �G�X�P�[�v�L�[�������ꂽ��ꎞ��~��؂�ւ���
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }

        // �ꎞ��~���͏������~
        if (!isPaused)
        {
            CountTime -= Time.deltaTime;
            if (CountTime < 0) TogglePause();

            min = (int)(CountTime / 60);
            sec = (int)(CountTime % 60);
            Timetext.text = min.ToString("D2") + ":" + sec.ToString("D2");
        }
    }

    // �ꎞ��~��؂�ւ��郁�\�b�h
    void TogglePause()
    {
        isPaused = !isPaused;

        // �^�C���X�P�[����ύX
        if (isPaused)
        {
            Time.timeScale = 0; // �Q�[�����ꎞ��~
        }
        else
        {
            Time.timeScale = 1; // �Q�[�����ĊJ
        }
    }
}