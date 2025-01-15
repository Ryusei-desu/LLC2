using UnityEngine;

public class BGMController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // AudioSourceコンポーネントを取得
        audioSource = GetComponent<AudioSource>();

        // BGMを再生（オートスタートの場合は省略可）
        audioSource.Play();
    }

    public void StopBGM()
    {
        audioSource.Stop(); // BGMを停止
    }

    public void PauseBGM()
    {
        audioSource.Pause(); // BGMを一時停止
    }

    public void ResumeBGM()
    {
        audioSource.UnPause(); // 一時停止から再開
    }
}

