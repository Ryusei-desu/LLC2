using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapFootstepController : MonoBehaviour
{
    [System.Serializable]
    public class TilemapFootstep
    {
        public Tilemap tilemap; // �Ώۂ̃^�C���}�b�v
        public Footstep[] footsteps; // �^�C�����Ƃ̑����ݒ�
    }

    [System.Serializable]
    public class Footstep
    {
        public string tileName; // �^�C���̖��O
        public AudioClip footstepSound; // �Ή����鑫��
        public float duration; // �Đ�����b��
    }

    public TilemapFootstep[] tilemapFootsteps; // �����̃^�C���}�b�v�ݒ�
    public AudioSource audioSource; // �������Đ�����AudioSource
    public AudioClip defaultFootstep; // �f�t�H���g�̑���
    public float defaultDuration = 0.5f; // �f�t�H���g�Đ�����

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
        Vector3 worldPosition = transform.position; // �L�����N�^�[�̃��[���h���W
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
        return Vector3Int.zero; // �L���ȃ^�C�����Ȃ��ꍇ�̓[�����W��Ԃ�
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
                    string tileName = tile.name; // �^�C���̖��O���擾

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

        // �f�t�H���g�̑������Đ�
        PlayClipForDuration(defaultFootstep, defaultDuration);
    }

    void PlayClipForDuration(AudioClip clip, float duration)
    {
        if (clip == null || audioSource == null)
            return;

        audioSource.clip = clip;
        audioSource.time = 0; // �Đ��ʒu�����Z�b�g
        audioSource.Play();

        // �w�莞�Ԍ�ɒ�~
        Invoke(nameof(StopAudio), duration);
    }

    void StopAudio()
    {
        audioSource.Stop();
    }
}
