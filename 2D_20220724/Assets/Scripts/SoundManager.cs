using UnityEngine;

namespace LP
{
    /// <summary>
    /// ���ĺ޲z��
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;

        private AudioSource aud;

        private void Awake()
        {
            instance = this;
            aud = GetComponent<AudioSource>();
        }

        public void PlaySound(AudioClip sound ,Vector2 rageVolume)
        {
            aud.PlayOneShot(sound, Random.Range(rageVolume.x, rageVolume.y));
        }
    }

}
