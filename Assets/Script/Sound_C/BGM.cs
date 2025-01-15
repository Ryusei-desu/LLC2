using UnityEngine;

public class BGMController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // AudioSource�R���|�[�l���g���擾
        audioSource = GetComponent<AudioSource>();

        // BGM���Đ��i�I�[�g�X�^�[�g�̏ꍇ�͏ȗ��j
        audioSource.Play();
    }

    public void StopBGM()
    {
        audioSource.Stop(); // BGM���~
    }

    public void PauseBGM()
    {
        audioSource.Pause(); // BGM���ꎞ��~
    }

    public void ResumeBGM()
    {
        audioSource.UnPause(); // �ꎞ��~����ĊJ
    }
}

