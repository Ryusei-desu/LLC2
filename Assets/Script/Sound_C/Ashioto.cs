using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapFootstepController : MonoBehaviour
{
    [System.Serializable]
    public class TilemapFootstep
    {
        public Tilemap tilemap; // 対象のタイルマップ
        public Footstep[] footsteps; // タイルごとの足音設定
    }

    [System.Serializable]
    public class Footstep
    {
        public string tileName; // タイルの名前
        public AudioClip footstepSound; // 対応する足音
        public float duration; // 再生する秒数
    }

    public TilemapFootstep[] tilemapFootsteps; // 複数のタイルマップ設定
    public AudioSource audioSource; // 足音を再生するAudioSource
    public AudioClip defaultFootstep; // デフォルトの足音
    public float defaultDuration = 0.5f; // デフォルト再生時間

    private Vector3Int previousTilePosition;

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    void Update()
    {
        Vector3 worldPosition = transform.position; // キャラクターのワールド座標
        Vector3Int tilePosition = GetTilePosition(worldPosition);

        if (tilePosition != previousTilePosition)
        {
            previousTilePosition = tilePosition;
            PlayFootstep(worldPosition, tilePosition);
        }
    }

    Vector3Int GetTilePosition(Vector3 worldPosition)
    {
        foreach (TilemapFootstep tilemapFootstep in tilemapFootsteps)
        {
            if (tilemapFootstep.tilemap != null)
            {
                Vector3Int tilePosition = tilemapFootstep.tilemap.WorldToCell(worldPosition);
                if (tilemapFootstep.tilemap.HasTile(tilePosition))
                {
                    return tilePosition;
                }
            }
        }
        return Vector3Int.zero; // 有効なタイルがない場合はゼロ座標を返す
    }

    void PlayFootstep(Vector3 worldPosition, Vector3Int tilePosition)
    {
        foreach (TilemapFootstep tilemapFootstep in tilemapFootsteps)
        {
            if (tilemapFootstep.tilemap != null && tilemapFootstep.tilemap.HasTile(tilePosition))
            {
                TileBase tile = tilemapFootstep.tilemap.GetTile(tilePosition);
                if (tile != null)
                {
                    string tileName = tile.name; // タイルの名前を取得

                    foreach (Footstep footstep in tilemapFootstep.footsteps)
                    {
                        if (footstep.tileName == tileName)
                        {
                            PlayClipForDuration(footstep.footstepSound, footstep.duration);
                            return;
                        }
                    }
                }
            }
        }

        // デフォルトの足音を再生
        PlayClipForDuration(defaultFootstep, defaultDuration);
    }

    void PlayClipForDuration(AudioClip clip, float duration)
    {
        if (clip == null || audioSource == null)
            return;

        audioSource.clip = clip;
        audioSource.time = 0; // 再生位置をリセット
        audioSource.Play();

        // 指定時間後に停止
        Invoke(nameof(StopAudio), duration);
    }

    void StopAudio()
    {
        audioSource.Stop();
    }
}
